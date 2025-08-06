using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrGrill.SupporterFunctions
{
    public static class UIFeatures
    {
        public static void RedondearPanel(Panel panel, int radio)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        public static void EstilizarBotonPlano(Button boton, string hexColor)
        {
            boton.BackColor = ColorTranslator.FromHtml(hexColor);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.ForeColor = Color.White;
            boton.Cursor = Cursors.Hand;
            boton.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }


        public static void RedondearBoton(Button boton, int radio)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(boton.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(boton.Width - radio, boton.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, boton.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            boton.Region = new Region(path);
        }

        public static void AgregarHoverEfecto(Button boton, Color colorNormal, Color colorHover)
        {
            boton.BackColor = colorNormal;

            boton.MouseEnter += (s, e) =>
            {
                boton.BackColor = colorHover;
            };

            boton.MouseLeave += (s, e) =>
            {
                boton.BackColor = colorNormal;
            };
        }
    }
}
