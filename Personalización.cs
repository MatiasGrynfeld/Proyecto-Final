using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___Wingo
{
    public partial class Personalización : Form
    {
        // Variables

        int x = 60;
        int perfil_seleccionado;
        int angulo_seleccionado;
        bool Modo_dibujo = false;
        bool Dibujando = false;
        Color color_pincel_inicial;
        Personalización___perfil color_wheel;
        Rectangle[,] ellipses = new Rectangle[8,8];
        Pen pen = new Pen(Color.Black);

        //Form
        public Personalización()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        private void bt_volver_Click(object sender, EventArgs e)
        {
            Pantalla_principal mostrar0 = new Pantalla_principal();
            mostrar0.Show();
            this.Close();
        }
        private void Personalización_Load(object sender, EventArgs e)
        {
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            bt_pincel.Visible = false;
            bt_mouse.Visible = false;
        }

        // Funciones
        void abrir_ventana(string nombre_previo, int x, int y)
        {
            color_wheel = new Personalización___perfil() { TopLevel = false, Dock = DockStyle.Fill };
            if (nombre_previo == "")
            {
                panel_perfil.Visible=false;
                panel_nom.Location = new Point(x, y);
                panel_nom.Visible = true;
                bt_pincel.Visible = false;
                bt_mouse.Visible = false;
                panel_wheel.Visible=false;
                panel_wheel.Controls.Remove(color_wheel);
                color_wheel.Dispose();
                panel_wheel.Invalidate();
                color_wheel.Close();
            }
            else
            {
                panel_perfil.Visible = true;
                bt_pincel.Visible = true;
                bt_mouse.Visible = true;
                panel_arriba.Visible = false;
                Comb_tipos_personalizados.Visible = false;
                panel_wheel.Visible = true;
                bt_mouse.Visible = false;
                bt_pincel.Visible=false;
                comb_angulo.SelectedItem=null;
                Comb_tipos_personalizados.SelectedItem = null;
                bt_mouse.Enabled = false;
                bt_pincel.Enabled = true;
                Modo_dibujo = false;
                panel_wheel.Controls.Add(color_wheel);
                color_wheel.Show();
                color_pincel_inicial = color_wheel.color_default;
                color_wheel.panel_muestra.BackColor = color_pincel_inicial;
            }
        }
        (bool, string) validar_nombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Por favor, ingresar un nombre.", "Error");
                txt_nombre.Text = "";
                return (false, "");
            }
            else
            {
                panel_nom.Visible = false;
                txt_nombre.Text = "";
                return (true, nombre);
            }
        }
        void Mouse_click_levanta_panel_MouseUp(object sender, EventArgs e)
        {
            Dibujando = false;
        }

        void crear_ellipses(int panelwidth, int panelheight, int numcellshor, int numcellsver)
        {
            int cell_width = panelwidth / numcellshor;
            int cell_height = panelheight / numcellsver;

            int startpositioninx = panelwidth / 2 - cell_width * 4;
            int startpositioniny = panelheight / 2 - cell_height * 4;

            for (int arriba = 0; arriba < 8; arriba++)
            {
                for (int horizontalmente = 0; horizontalmente < 8; horizontalmente++)
                {
                    int x = startpositioninx + horizontalmente * cell_width;
                    int y = startpositioniny + arriba * cell_height;
                    Rectangle ellip = new Rectangle(x, y, cell_width, cell_height);
                    ellipses[horizontalmente,arriba]=ellip;
                }
            }
        }

        (bool, int, int, SolidBrush color) coloreando(bool dibujando, bool modo_dibujo, Color color_inicial, Color nuevo_color, Point punto, Graphics g)
        {
            SolidBrush color = new SolidBrush(nuevo_color);
            //Pen pen = new Pen(Color.White);
            int arriba_devuelve = -1;
            int horizontalmente_devuelve = -1;
            bool validado = false;

            if (!dibujando || !modo_dibujo)
            {
                return (validado, arriba_devuelve, horizontalmente_devuelve, color);
            }

            if (nuevo_color == color_inicial)
            {
                MessageBox.Show("Por favor, seleccioná un color", "Error");
                return (validado, arriba_devuelve, horizontalmente_devuelve, color);
            }

            for (int arriba = 0; arriba < 8; arriba++)
            {
                for (int horizontalmente = 0; horizontalmente < 8; horizontalmente++)
                {
                    Rectangle rectangle = ellipses[horizontalmente, arriba];
                    if (rectangle.Contains(punto))
                    {
                        g.FillEllipse(color, rectangle);
                        //g.DrawEllipse(pen, rectangle);
                        validado = true;
                        arriba_devuelve = arriba;
                        horizontalmente_devuelve = horizontalmente;
                        return (validado, arriba_devuelve, horizontalmente_devuelve, color);
                    }
                }
            }

            return (validado, arriba_devuelve, horizontalmente_devuelve, color);
        }

        void asignar_modalidad(int perf_selec, int ang_selec, string modalidad)
        {
            switch (perf_selec)
            {
                case 1:
                    modalidad_angulos_perfil1[ang_selec] = modalidad; return;
                case 2:
                    modalidad_angulos_perfil1[ang_selec] = modalidad; return;
            }
        }

        //Perfil 1

        string nombre_perfil_1="";
        int y1 = 88;
        string[] modalidad_angulos_perfil1 = new string[3];
        Color[,] colores_arriba_perfil1 = new Color[8,8];
        Color[,] colores_izq_perfil1 = new Color[8, 8];
        Color[,] colores_der_perfil1 = new Color[8, 8];

        private void bt_perfil_1_Click(object sender, EventArgs e)
        {
            bt_pincel.Visible = false;
            bt_mouse.Visible = false;
            perfil_seleccionado = 0;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible=false;
            abrir_ventana(nombre_perfil_1, x, y1);
            perfil_seleccionado = 1;
        }

        //Perfil 2

        string nombre_perfil_2="";
        int y2 = 264;
        string[]  modalidad_angulos_perfil2= new string[3];
        Color[,] colores_arriba_perfil2 = new Color[8, 8];
        Color[,] colores_izq_perfil2 = new Color[8, 8];
        Color[,] colores_der_perfil2 = new Color[8, 8];

        private void bt_perfil_2_Click(object sender, EventArgs e)
        {
            bt_pincel.Visible = false;
            bt_mouse.Visible = false;
            perfil_seleccionado = 0;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            abrir_ventana(nombre_perfil_2, x, y2);
            perfil_seleccionado = 2;
        }

        //Eventos nombre

        private void bt_enviar_nombre_Click(object sender, EventArgs e)
        {
            var (validado, nombre) = validar_nombre(txt_nombre.Text);
            if (validado)
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        nombre_perfil_1 = nombre;
                        bt_perfil_1.Text = nombre;
                        return;
                    case 2:
                        nombre_perfil_2 = nombre;
                        bt_perfil_2.Text = nombre;
                        return;

                }
            }
        }
        private void bt_cambiar_nombre_Click_1(object sender, EventArgs e)
        {
            panel_perfil.Visible = false;
            panel_nom.Visible = true;
        }

        //Eventos modos

        private void bt_mouse_Click(object sender, EventArgs e)
        {
            bt_mouse.Enabled = false;
            bt_pincel.Enabled = true;
            Modo_dibujo = false;
        }
        private void bt_pincel_Click(object sender, EventArgs e)
        {
            bt_mouse.Enabled = true;
            bt_pincel.Enabled = false;
            Modo_dibujo = true;
        }

        //Evento seleccionar angulo
        private void comb_angulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Comb_tipos_personalizados.Visible = true;
            angulo_seleccionado=comb_angulo.SelectedIndex;
        }

        //Evento seleccionar tipo de iluminación
        private void Comb_tipos__personalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comb_tipos_personalizados.SelectedIndex == 0)
            {
                panel_arriba.Visible = true;
                bt_pincel.Visible = true;
                bt_mouse.Visible = true;
                asignar_modalidad(perfil_seleccionado, angulo_seleccionado, Comb_tipos_personalizados.SelectedItem.ToString().ToLower());
            }

        }

        //Eventos panel arriba
        private void panel_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            Dibujando = true;
            Graphics graphs = panel_arriba.CreateGraphics();
            var (validado, arriba, horizontalmente, color) = coloreando(Dibujando, Modo_dibujo, color_pincel_inicial, color_wheel.Color_del_panel(), e.Location, graphs);
            if (validado)
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        colores_arriba_perfil1[horizontalmente, arriba] = color.Color;
                        return;
                    case 2:
                        colores_arriba_perfil2[horizontalmente, arriba] = color.Color;
                        return;
                }
            }
        }

        private void panel_arriba_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphs = panel_arriba.CreateGraphics();
            var (validado, arriba, horizontalmente, color) = coloreando(Dibujando, Modo_dibujo, color_pincel_inicial, color_wheel.Color_del_panel(), e.Location, graphs);
            if (validado)
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        colores_arriba_perfil1[horizontalmente, arriba] = color.Color;
                        return;
                    case 2:
                        colores_arriba_perfil2[horizontalmente, arriba] = color.Color;
                        return;
                }
            }

        }

        private void panel_arriba_MouseUp(object sender, MouseEventArgs e)
        {
            Dibujando = false;
        }

        private void panel_arriba_Paint(object sender, PaintEventArgs e)
        {
            crear_ellipses(panel_arriba.Width, panel_arriba.Height, 8, 8);
            foreach (Rectangle rectangle in ellipses)
            {
                e.Graphics.DrawEllipse(pen, rectangle);
            }
        }

        private void panel_arriba_MouseLeave(object sender, EventArgs e)
        {
            Dibujando = false;
        }
    }
}
