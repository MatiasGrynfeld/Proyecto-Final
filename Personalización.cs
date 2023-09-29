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
using System.IO.Ports;
using System.Threading;

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
        Rectangle[,] ellipses = new Rectangle[8, 8];
        Pen pen = new Pen(Color.Black);
        bool validado_seguido = false;
        bool cambia_nombre = false;

        //Form
        public Personalización()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //TopMost = true;
            color_wheel = new Personalización___perfil() { TopLevel = false, Dock = DockStyle.Fill };
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
            panel_derecha.Location = panel_arriba.Location;
            panel_izquierda.Location = panel_arriba.Location;
            bt_enviar_configuraciones.Visible = false;
        }

        // Funciones

        void open_form()
        {
            panel_wheel.Visible = true;
            panel_wheel.Controls.Add(color_wheel);
            color_wheel.Show();
            color_pincel_inicial = color_wheel.color_default;
            color_wheel.panel_muestra.BackColor = color_pincel_inicial;
        }
        bool abrir_ventana(string nombre_previo, int x, int y, int perfil_selec)
        {
            bool abrir_seguido = false;
            if (nombre_previo == "")
            {
                panel_perfil.Visible = false;
                panel_nom.Location = new Point(x, y);
                panel_nom.Visible = true;
                bt_pincel.Visible = false;
                bt_mouse.Visible = false;
                panel_wheel.Visible = false;
                panel_arriba.Visible = false;
                panel_izquierda.Visible = false;
                panel_derecha.Visible = false;
                abrir_seguido = true;
                return abrir_seguido;
            }
            else
            {
                comb_angulo.SelectedItem = null;
                Comb_tipos_personalizados.SelectedItem = null;
                panel_perfil.Visible = true;
                panel_arriba.Visible = false;
                panel_izquierda.Visible = false;
                panel_derecha.Visible = false;
                Comb_tipos_personalizados.Visible = false;
                bt_mouse.Visible = false;
                bt_pincel.Visible = false;
                bt_mouse.Enabled = false;
                bt_pincel.Enabled = true;
                Modo_dibujo = false;
                if (perfil_selec == 1)
                {
                    bt_perfil_1.Enabled = false;
                    bt_perfil_2.Enabled = true;
                }
                else
                {
                    bt_perfil_1.Enabled = true;
                    bt_perfil_2.Enabled = false;
                }
                abrir_seguido = false;
                return abrir_seguido;
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
                    ellipses[horizontalmente, arriba] = ellip;
                }
            }
        }

        (bool, int, int, SolidBrush color) coloreando(bool dibujando, bool modo_dibujo, Color color_inicial, Color nuevo_color, Point punto, Graphics g)
        {
            SolidBrush color = new SolidBrush(nuevo_color);
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
                    modalidad_angulos_perfil2[ang_selec] = modalidad; return;
            }
        }

        //Perfil 1

        string nombre_perfil_1 = "";
        int y1 = 88;
        string[] modalidad_angulos_perfil1 = new string[3];
        string[] values_angulo_perfil1 = new string[3];
        Color[,] colores_arriba_perfil1 = new Color[8, 8];
        Color[,] colores_izq_perfil1 = new Color[8, 8];
        Color[,] colores_der_perfil1 = new Color[8, 8];

        int filas_arr = 8;
        int columnas_arr = 8;
        int filas_izq = 8;
        int columnas_izq = 8;
        int filas_der = 8;
        int columnas_der = 8;
        private void bt_perfil_1_Click(object sender, EventArgs e)
        {
            bt_perfil_2.Enabled = true;
            bt_pincel.Visible = false;
            bt_mouse.Visible = false;
            perfil_seleccionado = 0;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            perfil_seleccionado = 1;
            validado_seguido = abrir_ventana(nombre_perfil_1, x, y1, perfil_seleccionado);
        }

        //Perfil 2

        string nombre_perfil_2 = "";
        int y2 = 264;
        string[] modalidad_angulos_perfil2 = new string[3];
        string[] values_angulo_perfil2 = new string[3];
        Color[,] colores_arriba_perfil2 = new Color[8, 8];
        Color[,] colores_izq_perfil2 = new Color[8, 8];
        Color[,] colores_der_perfil2 = new Color[8, 8];

        private void bt_perfil_2_Click(object sender, EventArgs e)
        {
            bt_perfil_1.Enabled = true;
            bt_pincel.Visible = false;
            bt_mouse.Visible = false;
            perfil_seleccionado = 0;
            panel_nom.Visible = false;
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            perfil_seleccionado = 2;
            validado_seguido = abrir_ventana(nombre_perfil_2, x, y2, perfil_seleccionado);
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
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_perfil_1, x, y1, perfil_seleccionado);
                        }
                        cambia_nombre = false;
                        return;
                    case 2:
                        nombre_perfil_2 = nombre;
                        bt_perfil_2.Text = nombre;
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_perfil_2, x, y2, perfil_seleccionado);
                        }
                        cambia_nombre = false;
                        return;

                }
            }
        }
        private void bt_cambiar_nombre_Click_1(object sender, EventArgs e)
        {
            panel_perfil.Visible = false;
            panel_wheel.Visible = false;
            bt_mouse.Visible = false;
            bt_pincel.Visible = false;
            panel_nom.Visible = true;
            cambia_nombre = true;
        }
        private void bt_manejo_Click(object sender, EventArgs e)
        {
            Manejo manejo = new Manejo();
            manejo.Show();
            this.Close();
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

        void reset_paneles()
        {
            if (Comb_tipos_personalizados.SelectedIndex != 0)
            {
                panel_wheel.Visible = false;
            }
            lbl_selec_velocidad_arr.Visible = false;
            lbl_selec_velocidad_izq.Visible = false;
            lbl_selec_velocidad_der.Visible = false;
            lbl_selec_velocidad_arr.Location = new Point(100, 50);
            lbl_selec_velocidad_izq.Location = new Point(100, 50);
            lbl_selec_velocidad_der.Location = new Point(100, 50);
            int x_velocidades = 150;
            int y_rap = 75;
            int y_len = 414;
            int y_med = 217;
            lbl_rap_arr.Visible = false;
            lbl_rap_izq.Visible = false;
            lbl_rap_der.Visible = false;
            lbl_med_arr.Visible = false;
            lbl_med_izq.Visible = false;
            lbl_med_der.Visible = false;
            lbl_len_arr.Visible = false;
            lbl_len_izq.Visible = false;
            lbl_len_der.Visible = false;
            lbl_rap_arr.Location = new Point(x_velocidades, y_rap);
            lbl_rap_izq.Location = new Point(x_velocidades, y_rap);
            lbl_rap_der.Location = new Point(x_velocidades, y_rap);
            lbl_med_arr.Location = new Point(x_velocidades, y_med);
            lbl_med_izq.Location = new Point(x_velocidades, y_med);
            lbl_med_der.Location = new Point(x_velocidades, y_med);
            lbl_len_arr.Location = new Point(x_velocidades, y_len);
            lbl_len_izq.Location = new Point(x_velocidades, y_len);
            lbl_len_der.Location = new Point(x_velocidades, y_len);
            trackBar_arr.Visible = false;
            trackBar_izq.Visible = false;
            trackBar_der.Visible = false;
            bt_enviar_configuraciones.Visible = true;
            trackBar_arr.Value = trackBar_arr.Minimum;
            trackBar_izq.Value = trackBar_izq.Minimum;
            trackBar_der.Value = trackBar_der.Minimum;
            bt_mouse.Enabled = false;
            bt_pincel.Enabled = true;
            Modo_dibujo = false;
            bt_mouse.Visible = false;
            bt_pincel.Visible = false;
        }
        private void comb_angulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel_arriba.Visible = false;
            panel_derecha.Visible = false;
            panel_izquierda.Visible = false;
            panel_wheel.Visible = false;
            Comb_tipos_personalizados.Visible = true;
            bt_enviar_configuraciones.Visible = false;
            bt_mouse.Visible = false;
            bt_pincel.Visible = false;
            bt_mouse.Enabled = false;
            bt_pincel.Enabled = true;
            Modo_dibujo = false;
            angulo_seleccionado =comb_angulo.SelectedIndex;
            Comb_tipos_personalizados.SelectedItem = null;
        }

        //Evento seleccionar tipo de iluminación
        private void Comb_tipos__personalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comb_tipos_personalizados.SelectedItem != null)
            {
                reset_paneles();
                panel_arriba.Invalidate();
                panel_izquierda.Invalidate();
                panel_derecha.Invalidate();
                asignar_modalidad(perfil_seleccionado, angulo_seleccionado, Comb_tipos_personalizados.SelectedItem.ToString().ToLower());
                bt_enviar_configuraciones.Visible = true;
                if (Comb_tipos_personalizados.SelectedItem.ToString().ToLower() == "apagado")
                {
                    SolidBrush xx = new SolidBrush(Color.White);
                    asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString().ToLower(), -1, -1, xx, -1);
                }
                switch (angulo_seleccionado)
                {
                    case 0:
                        panel_arriba.Visible = true; return;
                    case 1:
                        panel_izquierda.Visible = true; return;
                    case 2:
                        panel_derecha.Visible = true; return;
                }
            }

        }

        //Funciones paneles
        void panel_paint(string modo_de_luz, Graphics graph)
        {
            if (modo_de_luz == "Independiente")
            {
                open_form();
                crear_ellipses(panel_arriba.Width, panel_arriba.Height, 8, 8);
                bt_pincel.Visible = true;
                bt_mouse.Visible = true;
                foreach (Rectangle rectangle in ellipses)
                {
                    graph.DrawEllipse(pen, rectangle);
                }
            }
            else if (modo_de_luz=="Apagado") { }
            else
            {
                lbl_selec_velocidad_arr.Visible = true;
                lbl_selec_velocidad_izq.Visible = true;
                lbl_selec_velocidad_der.Visible = true;
                switch (angulo_seleccionado)
                {
                    case 0:
                        trackBar_arr.Visible = true;
                        lbl_rap_arr.Visible = true;
                        lbl_med_arr.Visible = true;
                        lbl_len_arr.Visible = true;
                        break;
                    case 1:
                        trackBar_izq.Visible = true;
                        lbl_rap_izq.Visible = true;
                        lbl_med_izq.Visible = true;
                        lbl_len_izq.Visible = true;
                        break;
                    case 2:
                        trackBar_der.Visible = true;
                        lbl_rap_der.Visible = true;
                        lbl_med_der.Visible = true;
                        lbl_len_der.Visible = true;
                        break;
                }
            }
        }
        void Mouse_down_move(string modo_de_luz, Graphics graph, Point lugar_clickeado, bool Mouse_down)
        {
            if (modo_de_luz == "Independiente")
            {
                if (Mouse_down)
                {
                    Dibujando = true;
                }
                var (validado, arriba, horizontalmente, color) = coloreando(Dibujando, Modo_dibujo, color_pincel_inicial, color_wheel.Color_del_panel(), lugar_clickeado, graph);
                if (validado)
                {
                    asignar_valores(modo_de_luz, horizontalmente, arriba, color, -1);
                }
            }

        }
        void Mouse_leave_up(string modo_de_luz)
        {
            if (modo_de_luz == "Independiente")
            {
                Dibujando = false;
            }
        }
        string valor_track(int valor_ingresado)
        {
            int valor_final = 1001 - valor_ingresado;
            return valor_final.ToString();
        }
        void asignar_valores(string modo_luz, int horizontalmente, int arriba, SolidBrush color, int trackbar_value)
        {
            if (modo_luz == "Independiente")
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                colores_arriba_perfil1[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil1[0] = "";
                                return;
                            case 1:
                                colores_izq_perfil1[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil1[1] = "";
                                return;
                            case 2:
                                colores_der_perfil1[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil1[2] = "";
                                return;
                        }
                        return;
                    case 2:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                colores_arriba_perfil2[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil2[0] = "";
                                return;
                            case 1:
                                colores_izq_perfil2[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil2[1] = "";
                                return;
                            case 2:
                                colores_der_perfil2[arriba, horizontalmente] = color.Color;
                                values_angulo_perfil2[2] = "";
                                return;
                        }
                        return;
                }
            }
            else if (modo_luz == "Apagado")
            {
                switch (perfil_seleccionado)
                {
                    case 1:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil1[0] = "apagado";
                                return;
                            case 1:
                                values_angulo_perfil1[1] = "apagado";
                                return;
                            case 2:
                                values_angulo_perfil1[2] = "apagado";
                                return;
                        }
                        return;
                    case 2:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil2[0] = "apagado";
                                return;
                            case 1:
                                values_angulo_perfil2[1] = "apagado";
                                return;
                            case 2:
                                values_angulo_perfil2[2] = "apagado";
                                return;
                        }
                        return;
                }
            }
            else
            {
                string valor_final = valor_track(trackbar_value);
                switch (perfil_seleccionado)
                {
                    case 1:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil1[0] = valor_final;
                                return;
                            case 1:
                                values_angulo_perfil1[1] = valor_final;
                                return;
                            case 2:
                                values_angulo_perfil1[2] = valor_final;
                                return;
                        }
                        return;
                    case 2:
                        switch (angulo_seleccionado)
                        {
                            case 0:
                                values_angulo_perfil2[0] = valor_final;
                                return;
                            case 1:
                                values_angulo_perfil2[1] = valor_final;
                                return;
                            case 2:
                                values_angulo_perfil2[2] = valor_final;
                                return;
                        }
                        return;
                }
            }
        }

        //Eventos panel arriba

        Graphics graphs_arriba;
        private void panel_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = true;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_arriba, punto_click, activar_dibujar);
        }

        private void panel_arriba_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = false;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_arriba, punto_click, activar_dibujar);
        }

        private void panel_arriba_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }

        private void panel_arriba_Paint(object sender, PaintEventArgs e)
        {
            graphs_arriba = panel_arriba.CreateGraphics();
            if (Comb_tipos_personalizados.SelectedItem != null)
            {
                panel_paint(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_arriba);
            }
        }

        private void panel_arriba_MouseLeave(object sender, EventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void trackBar_arr_Scroll(object sender, EventArgs e)
        {
            SolidBrush col = new SolidBrush(Color.White);
            asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString(), -1, -1, col, trackBar_arr.Value);
        }

        //Eventos panel derecha

        Graphics graphs_derecha;

        private void panel_derecha_Paint(object sender, PaintEventArgs e)
        {
            graphs_derecha = panel_derecha.CreateGraphics();
            panel_paint(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_derecha);
        }
        private void panel_derecha_MouseDown(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = true;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_derecha, punto_click, activar_dibujar);
        }
        private void panel_derecha_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = false;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_derecha, punto_click, activar_dibujar);
        }
        private void panel_derecha_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void panel_derecha_MouseLeave(object sender, EventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void trackBar_der_Scroll(object sender, EventArgs e)
        {
            SolidBrush col = new SolidBrush(Color.White);
            asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString(), -1, -1, col, trackBar_der.Value);
        }

        //Eventos panel izquierda
        Graphics graphs_izq;
        private void panel_izquierda_Paint(object sender, PaintEventArgs e)
        {
            graphs_izq = panel_izquierda.CreateGraphics();
            panel_paint(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_izq);
        }
        private void panel_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = true;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_izq, punto_click, activar_dibujar);
        }
        private void panel_izquierda_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto_click = e.Location;
            bool activar_dibujar = false;
            Mouse_down_move(Comb_tipos_personalizados.SelectedItem.ToString(), graphs_izq, punto_click, activar_dibujar);

        }
        private void panel_izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void panel_izquierda_MouseLeave(object sender, EventArgs e)
        {
            Mouse_leave_up(Comb_tipos_personalizados.SelectedItem.ToString());
        }
        private void trackBar_izq_Scroll(object sender, EventArgs e)
        {
            SolidBrush col = new SolidBrush(Color.White);
            asignar_valores(Comb_tipos_personalizados.SelectedItem.ToString(), -1, -1, col, trackBar_izq.Value);
        }

        //Enviar configuraciones
        List<string> hacer_mensaje(int angulo, int cant_filas, int cant_columnas, string modalidad, Color[,] matriz_colores1, Color[,] matriz_colores2, int perfil)
        {
            List<string> mensajes=new List<string>();
            Funciones func_enviar = new Funciones();
            string mensaje = null;
            if (modalidad == "independiente") {
                switch (perfil)
                {
                    case 1:
                        for (int fila = 0; fila < cant_filas; fila++)
                        {
                            for (int columna = 0; columna < cant_columnas; columna++)
                            {
                                mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil1[angulo], values_angulo_perfil1[angulo], matriz_colores1[fila,columna],fila,columna,-1,-1,"",-1);
                                mensajes.Add(mensaje);
                            }
                        }
                        return mensajes;
                    case 2:
                        for (int fila = 0; fila < cant_filas; fila++)
                        {
                             for (int columna = 0; columna < cant_columnas; columna++)
                             {
                                mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil1[angulo], values_angulo_perfil1[angulo], matriz_colores2[fila,columna], fila, columna, -1, -1, "", -1);
                                mensajes.Add(mensaje);
                             }
                        }
                        return mensajes;
                }
            }
            else
            {
                switch (perfil)
                {
                    case 1:
                        mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil1[angulo], values_angulo_perfil1[angulo], Color.White,-1, -1, -1, -1, "", -1);
                        mensajes.Add(mensaje);
                        return mensajes;
                    case 2:
                        mensaje = func_enviar.string_a_enviar("personalizacion", perfil, angulo, modalidad_angulos_perfil2[angulo], values_angulo_perfil2[angulo], Color.White,-1, -1, -1, -1, "", -1);
                        mensajes.Add(mensaje);
                        return mensajes;
                }
            }
            mensajes.Add(mensaje);
            return mensajes;
        }
        private void bt_enviar_configuraciones_Click(object sender, EventArgs e)
        {
            List<string> msgs_angulo_arr1 = new List<string>();
            List<string> msgs_angulo_izq1 = new List<string>();
            List<string> msgs_angulo_der1 = new List<string>();
            List<string> msgs_angulo_arr2 = new List<string>();
            List<string> msgs_angulo_izq2 = new List<string>();
            List<string> msgs_angulo_der2 = new List<string>();
            for (int i=0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        msgs_angulo_arr1 = hacer_mensaje(i, filas_arr, columnas_arr, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2,1);
                        msgs_angulo_arr2 = hacer_mensaje(i, filas_arr, columnas_arr, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2, 2);
                        break;
                    case 1:
                        msgs_angulo_izq1 = hacer_mensaje(i, filas_izq, columnas_izq, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2,1);
                        msgs_angulo_izq2 = hacer_mensaje(i, filas_izq, columnas_izq, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2, 2);
                        break;
                    case 2:
                        msgs_angulo_der1 = hacer_mensaje(i, filas_der, columnas_der, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2,1);
                        msgs_angulo_der2 = hacer_mensaje(i, filas_der, columnas_der, modalidad_angulos_perfil1[i], colores_arriba_perfil1, colores_arriba_perfil2, 2);
                        break;
                }
            }
            string[] nombres_puertos = SerialPort.GetPortNames();
            if (nombres_puertos.Length == 0)
            {
                MessageBox.Show("Por favor, conectar el auto a la computadora.", "Error");
            }
            else
            {
                foreach (string nom_puerto in nombres_puertos)
                {
                    serialPort_arduino.PortName = nom_puerto;
                    serialPort_arduino.BaudRate = 9600;
                    try
                    {
                        List<string>[] todos_msgs = new List<string>[6];
                        todos_msgs[0] = msgs_angulo_arr1;
                        todos_msgs[1] = msgs_angulo_arr2;
                        todos_msgs[2] = msgs_angulo_izq1;
                        todos_msgs[3] = msgs_angulo_izq2;
                        todos_msgs[4] = msgs_angulo_der1;
                        todos_msgs[5] = msgs_angulo_der2;
                        serialPort_arduino.Open();
                        foreach (List<string> parte in todos_msgs)
                        {
                            foreach (string mensaje in parte)
                            {
                                serialPort_arduino.WriteLine(mensaje + '\n');
                                Thread.Sleep(10);
                            }
                        }
                        serialPort_arduino.WriteLine("end" + '\n');
                        serialPort_arduino.Close();
                        MessageBox.Show("Mensajes enviados exitosamente", "Enviado");
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error");
                        throw;
                    }
                }
            }
        }

        //Num modalidad en funciones
        //Base de datos
        //Diseño
    }
}
