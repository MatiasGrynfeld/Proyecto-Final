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
        Point punto_anterior;
        Pen pen_color= new Pen(Color.Black);
        Color color_pincel_inicial;

        //Form
        public Personalización()
        {
            InitializeComponent();
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
            Personalización___perfil color_picker = new Personalización___perfil() { TopLevel = false, Dock = DockStyle.Fill };
            if (nombre_previo == "")
            {
                panel_perfil.Visible=false;
                panel_nom.Location = new Point(x, y);
                panel_nom.Visible = true;
                bt_pincel.Visible = false;
                bt_mouse.Visible = false;
                panel_wheel.Visible=false;
                color_picker.Close();
                panel_wheel.Controls.Remove(color_picker);
                color_picker.Dispose();
                panel_wheel.Invalidate();
            }
            else
            {
                panel_perfil.Visible = true;
                bt_pincel.Visible = true;
                bt_mouse.Visible = true;
                panel_wheel.Visible = true;
                panel_wheel.Controls.Add(color_picker);
                color_picker.Show();

                //color_pincel_inicial = color_para_led();
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

        //Color color_para_led()
        //{
        //    Bitmap perimetro = new Bitmap(this.Width,this.Height);
        //    Point punto_saca_color = new Point(panel_wheel.Location.X + 285,panel_wheel.Location.Y + 35);
        //    Color pixel_seleccionado = perimetro.GetPixel(punto_saca_color.X, punto_saca_color.Y);

        //    Color color_seleccionado = Color.FromArgb(pixel_seleccionado.R, pixel_seleccionado.G, pixel_seleccionado.B);
        //    return color_seleccionado;
            
        //}

        //Perfil 1

        string nombre_perfil_1="";
        int y1 = 88;

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
        private void bt_cambiar_nombre_Click(object sender, EventArgs e)
        {
            panel_perfil.Visible = false;
            panel_nom.Visible = true;
        }
        private void panel_perfil_MouseDown(object sender, MouseEventArgs e)
        {
            dibujando = true;
            punto_anterior = e.Location;
        }
        private void panel_perfil_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando && modo_dibujo)
            {
                Graphics dibujo = panel_perfil.CreateGraphics();
                //if(color_para_led() != color_pincel_inicial)
                //{
                //    pen_color.Color =color_para_led();
                    dibujo.DrawLine(pen_color, punto_anterior, e.Location);
                    punto_anterior = e.Location;
                //}
                //else
                //{
                    //MessageBox.Show("Por faovr, seleccioná un color primero.", "Error");
                //    dibujando = false;
                //}
            }
        }
        private void panel_perfil_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;
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
    }
}
