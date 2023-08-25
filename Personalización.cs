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
        bool modo_dibujo = false;
        bool dibujando = false;
        Color color_pincel_inicial;
        Personalización___perfil color_wheel;
        Point punto_anterior;
        Graphics g;
        List<Rectangle> rectangles = new List<Rectangle>();
        Pen pen= new Pen()

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
                color_wheel.Close();
                panel_wheel.Controls.Remove(color_wheel);
                color_wheel.Dispose();
                panel_wheel.Invalidate();
            }
            else
            {
                panel_perfil.Visible = true;
                bt_pincel.Visible = true;
                bt_mouse.Visible = true;
                panel_imgs.Visible = false;
                bt_anterior_img.Visible = false;
                bt_siguiente_img.Visible = false;
                panel_wheel.Visible = true;
                panel_wheel.Controls.Add(color_wheel);
                color_wheel.Show();

                color_pincel_inicial = color_wheel.Color_del_panel();
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
            dibujando = false;
        }
        
        //Perfil 1

        string nombre_perfil_1="";
        int y1 = 88;
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

        // Eventos

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
        private void bt_mouse_Click(object sender, EventArgs e)
        {
            bt_mouse.Enabled = false;
            bt_pincel.Enabled = true;
            modo_dibujo = false;
        }
        private void bt_pincel_Click(object sender, EventArgs e)
        {
            bt_mouse.Enabled = true;
            bt_pincel.Enabled = false;
            modo_dibujo = true;
        }
        private void Comb_tipos__personalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comb_tipos_personalizados.SelectedIndex == 0)
            {
                panel_imgs.Visible = true;
                bt_anterior_img.Visible = true;
                bt_siguiente_img.Visible = true;
                //iniciializar_paneles();
            }

        }

        private void panel_imgs_MouseDown(object sender, MouseEventArgs e)
        {
            dibujando = true;
            punto_anterior = e.Location;
            label1.BackColor = color_wheel.Color_del_panel();
        }

        private void panel_imgs_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando && modo_dibujo)
            {
                if(color_wheel.Color_del_panel() != color_pincel_inicial)
                {
                    foreach (Control control in panel_imgs.Controls)
                    {
                        if (control.Bounds.Contains(punto_anterior))
                        {
                            control.BackColor = color_wheel.Color_del_panel();
                            punto_anterior = e.Location;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error", "Error");
                }

            }

        }

        private void panel_imgs_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;
            label1.BackColor = Color.Black;
        }

        private void panel_imgs_Paint(object sender, PaintEventArgs e)
        {
            int num_columnas = 8;
            int num_filas = 8;
            int celda_ancho = 836 / num_columnas;
            int celda_altura = 574 / num_filas;

            int total_ancho = num_columnas * celda_ancho;
            int total_altura = num_filas * celda_altura;

            int desplazamiento_horizontal = (836 - total_ancho) / 2;
            int verticalOffset = (574 - total_altura) / 2;

            for (int fila = 0; fila < num_filas; fila++)
            {
                for (int col = 0; col < num_columnas; col++)
                {
                    int x = desplazamiento_horizontal + col * celda_ancho;
                    int y = verticalOffset + fila * celda_altura;
                    Rectangle rectangle = new Rectangle(x, y, celda_ancho, celda_altura);
                    rectangles.Add(rectangle);
                }
            }

            for (int i=0; i < 64; i++)
            {
                g.DrawRectangles(rectangles[i]);
            }
        }
    }
}
