using System;
using System.Drawing;
using System.Windows.Forms;
using MrGrill.Controllers;
using MrGrill.Models;

namespace MrGrill.Views
{
    public class CashRegisterView : Form
    {
        private readonly CashRegisterController controller;
        private readonly int currentUserId;

        private SplitContainer split;
        private NumericUpDown nudMontoInicial;
        private TextBox txtObs;
        private NumericUpDown nudMontoFinal;
        private Label lblEstado;
        private Label lblIdCaja;
        private int? currentCashId;

        // proporción deseada del panel izquierdo
        private const double LEFT_RATIO = 0.56;
        // mínimos “deseados”. Si el host es muy pequeño, se relajan temporalmente
        private const int MIN_LEFT_DESIRED = 360;
        private const int MIN_RIGHT_DESIRED = 320;

        public CashRegisterView(int idUser)
        {
            currentUserId = idUser;
            controller = new CashRegisterController();

            Text = "Caja";
            BackColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;

            // Header color
            var headerBand = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                BackColor = ColorTranslator.FromHtml("#FF6A00")
            };
            Controls.Add(headerBand);

            var title = new Label
            {
                Text = "Caja",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true
            };
            headerBand.Controls.Add(title);
            headerBand.Resize += (s, e) =>
            {
                title.Location = new Point((headerBand.Width - title.Width) / 2,
                                           (headerBand.Height - title.Height) / 2);
            };

            // Info fila superior
            var infoRow = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 32,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(12, 6, 12, 0),
                BackColor = Color.White
            };
            Controls.Add(infoRow);
            infoRow.BringToFront();

            var lblFecha = new Label
            {
                Text = $"Fecha: {DateTime.Today:yyyy-MM-dd}",
                AutoSize = true
            };
            infoRow.Controls.Add(lblFecha);

            lblEstado = new Label
            {
                Text = "   Estado: Cerrada",
                AutoSize = true,
                ForeColor = Color.Firebrick,
                Margin = new Padding(12, 0, 0, 0)
            };
            infoRow.Controls.Add(lblEstado);

            lblIdCaja = new Label
            {
                Text = "   IdCaja: -",
                AutoSize = true,
                ForeColor = Color.DimGray,
                Margin = new Padding(12, 0, 0, 0)
            };
            infoRow.Controls.Add(lblIdCaja);

            // Contenido principal
            CreateCashLayout();

            // Eventos de ciclo de vida para ajustar el split SIN lanzar excepción
            HandleCreated += (_, __) => SafeFitSplit();
            Shown += (_, __) => SafeFitSplit();
            Resize += (_, __) => SafeFitSplit();
            ParentChanged += (_, __) => SafeFitSplit();
        }

        private void CreateCashLayout()
        {
            split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                BackColor = Color.White,
                SplitterWidth = 6,

                // Comenzamos con mins modestos. Luego SafeFitSplit() los sube si hay espacio
                Panel1MinSize = 120,
                Panel2MinSize = 120,
                SplitterDistance = 200
            };
            Controls.Add(split);

            // Ajustar también ante cambios del propio split (redimensionado interno)
            split.Resize += (_, __) => SafeFitSplit();

            BuildLeft(split.Panel1);
            BuildRight(split.Panel2);

            // Ajuste diferido cuando ya hay tamaño real
            // antes: BeginInvoke((Action)SafeFitSplit);
            PostToUi(SafeFitSplit);

        }

        private void BuildLeft(Control host)
        {
            host.BackColor = Color.White;

            var grid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(12),
                BackColor = Color.White
            };
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));       // inputs
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));  // observaciones (Fill)
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 52f));  // footer
            host.Controls.Add(grid);

            // Inputs
            var inputs = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 2,
                AutoSize = true
            };
            inputs.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            inputs.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            var lblIni = new Label
            {
                Text = "Monto inicial (C$)",
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Margin = new Padding(0, 0, 8, 6)
            };
            nudMontoInicial = new NumericUpDown
            {
                DecimalPlaces = 2,
                Maximum = 100000000,
                ThousandsSeparator = true,
                Width = 140
            };

            inputs.Controls.Add(lblIni, 0, 0);
            inputs.Controls.Add(nudMontoInicial, 1, 0);
            grid.Controls.Add(inputs, 0, 0);

            // Observaciones
            var obsPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 8, 0, 0) };
            var lblObs = new Label { Text = "Observaciones", AutoSize = true, Dock = DockStyle.Top, Margin = new Padding(0, 0, 0, 4) };
            txtObs = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill
            };
            obsPanel.Controls.Add(txtObs);
            obsPanel.Controls.Add(lblObs);
            grid.Controls.Add(obsPanel, 0, 1);

            // Footer (abrir)
            var footer = new Panel { Dock = DockStyle.Fill };
            var btnOpen = new Button
            {
                Text = "Abrir caja",
                Size = new Size(120, 34),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            btnOpen.Click += BtnOpen_Click;

            footer.Controls.Add(btnOpen);
            footer.Resize += (s, e) =>
            {
                btnOpen.Location = new Point(footer.Width - btnOpen.Width - 8,
                                             footer.Height - btnOpen.Height - 8);
            };
            grid.Controls.Add(footer, 0, 2);
        }

        private void BuildRight(Control host)
        {
            host.BackColor = Color.White;

            var container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12) };
            host.Controls.Add(container);

            var header = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 2,
                AutoSize = true
            };
            header.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            header.Controls.Add(new Label { Text = "Monto final (C$)", AutoSize = true, Margin = new Padding(0, 0, 8, 0) }, 0, 0);

            nudMontoFinal = new NumericUpDown
            {
                DecimalPlaces = 2,
                Maximum = 100000000,
                Width = 140
            };
            header.Controls.Add(nudMontoFinal, 1, 0);
            container.Controls.Add(header);

            // Footer (cerrar)
            var footer = new Panel { Dock = DockStyle.Bottom, Height = 52 };
            var btnClose = new Button
            {
                Text = "Cerrar caja",
                Size = new Size(120, 34),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            btnClose.Click += BtnClose_Click;

            footer.Controls.Add(btnClose);
            footer.Resize += (s, e) =>
            {
                btnClose.Location = new Point(footer.Width - btnClose.Width - 8,
                                              footer.Height - btnClose.Height - 8);
            };
            container.Controls.Add(footer);
        }

        /// <summary>
        /// Ajuste SEGURO del SplitterDistance: respeta Panel1MinSize/Panel2MinSize y evita InvalidOperationException.
        /// Llama a esto en Shown/Resize/ParentChanged/BeginInvoke.
        /// </summary>
        private void SafeFitSplit()
        {
            if (split == null || !split.IsHandleCreated) return;

            // Si todavía no hay ancho util, no hacemos nada
            int total = split.ClientSize.Width;
            if (total <= 0) return;

            // Subimos mínimos al deseado si el host lo permite, si no, relajamos
            // para evitar el estado imposible (minLeft + minRight + splitter > total)
            int minLeft = MIN_LEFT_DESIRED;
            int minRight = MIN_RIGHT_DESIRED;

            if (minLeft + minRight + split.SplitterWidth > total)
            {
                // Relax: usa la mitad disponible para cada lado (como base)
                minLeft = Math.Max(0, (total - split.SplitterWidth) / 2);
                minRight = Math.Max(0, (total - split.SplitterWidth) / 2);
            }

            try
            {
                split.Panel1MinSize = minLeft;
                split.Panel2MinSize = minRight;
            }
            catch
            {
                // Si por timing no deja, lo dejamos como esté; seguimos al cálculo de distancia
            }

            // Recalcular límites tras setear mins (o con los actuales si falló)
            int effectiveMinLeft = split.Panel1MinSize;
            int effectiveMinRight = split.Panel2MinSize;

            int maxLeft = total - split.SplitterWidth - effectiveMinRight;
            if (maxLeft < effectiveMinLeft)
            {
                // Estado aún imposible. Forzamos mins temporales muy pequeños.
                try
                {
                    split.Panel1MinSize = Math.Min(effectiveMinLeft, 1);
                    split.Panel2MinSize = Math.Min(effectiveMinRight, 1);
                }
                catch { /* ignore */ }

                effectiveMinLeft = split.Panel1MinSize;
                effectiveMinRight = split.Panel2MinSize;
                maxLeft = total - split.SplitterWidth - effectiveMinRight;
            }

            int desired = (int)(total * LEFT_RATIO);
            int safeDistance = Math.Max(effectiveMinLeft, Math.Min(desired, maxLeft));

            try
            {
                split.SplitterDistance = safeDistance;
            }
            catch
            {
                // En hosts extremadamente pequeños, último recurso: mitad
                try { split.SplitterDistance = Math.Max(0, (total - split.SplitterWidth) / 2); }
                catch { /* swallow */ }
            }
        }

        // --- Acciones
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var cr = new CashRegister
            {
                date = DateTime.Today,
                idUser = currentUserId,
                OpeningTime = DateTime.Now,
                initialAmount = nudMontoInicial.Value,
                observations = txtObs.Text?.Trim() ?? ""
            };

            if (controller.OpenCashRegister(cr))
            {
                lblEstado.Text = "   Estado: Abierta";
                lblEstado.ForeColor = Color.ForestGreen;
                lblIdCaja.Text = "   IdCaja: (abierta)";
                currentCashId = (currentCashId ?? 0) + 1; // placeholder local si no tienes fetch del Id
                MessageBox.Show("Caja abierta correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (!currentCashId.HasValue)
            {
                MessageBox.Show("No hay caja abierta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ok = controller.CloseCashRegister(currentCashId.Value, DateTime.Now, nudMontoFinal.Value);
            if (ok)
            {
                lblEstado.Text = "   Estado: Cerrada";
                lblEstado.ForeColor = Color.Firebrick;
                lblIdCaja.Text = "   IdCaja: -";
                currentCashId = null;
                MessageBox.Show("Caja cerrada correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Permite que el host (MrGrillHomeScreen) dispare un ajuste final cuando ya está montado
        public void NotifyHosted()
        {
            // antes: BeginInvoke((Action)SafeFitSplit);
            PostToUi(SafeFitSplit);

        }
        // Post seguro a la cola de UI sin explotar cuando no hay handle aún
        private void PostToUi(Action a)
        {
            if (IsHandleCreated)
            {
                BeginInvoke(a);
                return;
            }

            EventHandler h = null;
            h = (s, e) =>
            {
                try { BeginInvoke(a); }
                catch { /* swallow */ }
                finally { HandleCreated -= h; }
            };
            HandleCreated += h;
        }

    }
}
