using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Proyecto_Final___Wingo
{
    public partial class Manejo : Form
    {
        //Configurar botones de conectar y enviar recorrido
        // Variables generales

        string unidad;
        string nueva_unidad;
        int x = 150;
        int recor_seleccionado;
        bool nececitar_cant;
        bool nuevo_necesitar_cant;
        bool validado_seguido = false;
        bool cambia_nombre = false;
        // Funciones

        bool comprobar_si_es_num(string texto_a_analizar)
        {
            for (int i = 0; i < texto_a_analizar.Length; i++)
            {
                char letra = texto_a_analizar[i];
                if (char.IsDigit(letra))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool abrir_ventana(string nombre_previo, int x, int y)
        {
            bool abrir_seguido = false;
            if (nombre_previo == null)
            {
                gb_nom.Location = new Point(x, y);
                gb_nom.Visible = true;
                abrir_seguido = true;
                return abrir_seguido;
            }
            else
            {
                gb_pasos.Visible = true;
                lbl_tipo_de_paso.Visible = false;
                lbl_cant_paso.Visible = false;
                comb_tipo_paso.Visible = false;
                txt_cant_paso.Visible = false;
                bt_enviar_paso.Visible = false;
                lbl_pasos_hechos.Visible = false;
                comb_pasos_hechos_recor1.Visible = false;
                comb_pasos_hechos_recor2.Visible = false;
                comb_pasos_hechos_recor3.Visible = false;
                bt_modificar_paso.Visible = false;
                abrir_seguido = false;
                return abrir_seguido;
            }
        }
        (bool, string) validar_nombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Por favor, ingresar un nombre.", "Error");
                txt_nom.Text = "";
                return (false, "");
            }
            else
            {
                gb_nom.Visible = false;
                txt_nom.Text = "";
                return (true, nombre);
            }
        }
        (bool, string, string, string) enviar_y_verificar_paso(string tipo_paso_ingresado, string cant_paso_ingresado, bool necesitar_cantidad)
        {
            if (tipo_paso_ingresado == "")
            {
                MessageBox.Show("Por favor, seleccionar el tipo de paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else if (necesitar_cantidad && cant_paso_ingresado == "")
            {
                MessageBox.Show("Por favor, agregar la cantidad del paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else
            {
                bool es_num = comprobar_si_es_num(cant_paso_ingresado);
                if (!es_num)
                {
                    MessageBox.Show("Por favor, no ingresar ninguna letra o símbolo en el número", "Error");
                    txt_cant_paso.Text = "";
                    return (false, "", "", "");
                }
                else
                {
                    string paso_hecho = tipo_paso_ingresado + ", " + cant_paso_ingresado;
                    lbl_tipo_de_paso.Visible = false;
                    lbl_cant_paso.Visible = false;
                    comb_tipo_paso.Visible = false;
                    txt_cant_paso.Visible = false;
                    bt_enviar_paso.Visible = false;
                    comb_tipo_paso.Text = "";
                    return (true, tipo_paso_ingresado, cant_paso_ingresado, paso_hecho);
                }
            }
        }
        (bool, string, string, string) cambiar_y_verificar_paso(string tipo_paso_modificado, string cant_paso_modificado, bool necesitar_nueva_cant)
        {
            if (tipo_paso_modificado == "")
            {
                MessageBox.Show("Por favor, seleccionar el tipo de paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else if (necesitar_nueva_cant && cant_paso_modificado == "")
            {
                MessageBox.Show("Por favor, agregar la cantidad del paso que quiere realizar.", "Error");
                return (false, "", "", "");
            }
            else
            {
                bool es_num = comprobar_si_es_num(cant_paso_modificado);
                if (!es_num)
                {
                    MessageBox.Show("Por favor, no ingresar ninguna letra o símbolo en el número", "Error");
                    txt_cant_paso.Text = "";
                    return (false, "", "", "");
                }
                else
                {
                    gb_modificar_paso.Visible = false;
                    comb_nuevo_tipo_paso.Text = "";
                    string new_paso_hecho = tipo_paso_modificado + ", " + cant_paso_modificado;
                    return (true, tipo_paso_modificado, cant_paso_modificado, new_paso_hecho);
                }
            }
        }

        // Form
        public Manejo()
        {
            InitializeComponent();
        }
        private void Manejo_Load(object sender, EventArgs e)
        {
            gb_nom.Visible = false;
            gb_pasos.Visible = false;
            gb_modificar_paso.Visible = false;
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            Pantalla_principal mostrar0 = new Pantalla_principal();
            mostrar0.Show();
            this.Close();
        }

        // Recor 1

        string nombre_recor1;
        int y1 = 30;
        List<string> paso_recor_1 = new List<string>();
        List<int> cant_paso_recor_1 = new List<int>();

        private void bt_recorrido1_Click(object sender, EventArgs e)
        {
            recor_seleccionado = 0;
            gb_nom.Visible = false;
            gb_pasos.Visible = false;
            comb_tipo_paso.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            lbl_pasos_hechos_recor1.Text = "";
            validado_seguido = abrir_ventana(nombre_recor1, x, y1);
            recor_seleccionado = 1;
            bt_recorrido1.Enabled = false;
            bt_recorrido2.Enabled = true;
            bt_recorrido3.Enabled = true;
        }

        // Recor 2

        string nombre_recor2;
        int y2 = 75;
        List<string> paso_recor_2 = new List<string>();
        List<int> cant_paso_recor_2 = new List<int>();

        private void bt_recorrido2_Click(object sender, EventArgs e)
        {
            recor_seleccionado = 0;
            gb_nom.Visible = false;
            gb_pasos.Visible = false;
            comb_tipo_paso.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            lbl_pasos_hechos_recor1.Text = "";
            validado_seguido = abrir_ventana(nombre_recor2, x, y2);
            recor_seleccionado = 2;
            bt_recorrido1.Enabled = true;
            bt_recorrido2.Enabled = false;
            bt_recorrido3.Enabled = true;
        }

        // Recor 3

        string nombre_recor3;
        int y3 = 110;
        List<string> paso_recor_3 = new List<string>();
        List<int> cant_paso_recor_3 = new List<int>();

        private void bt_recorrido3_Click(object sender, EventArgs e)
        {
            recor_seleccionado = 0;
            gb_nom.Visible = false;
            gb_pasos.Visible = false;
            comb_tipo_paso.Text = "";
            txt_cant_paso.Text = "";
            txt_nom.Text = "";
            lbl_pasos_hechos_recor1.Text = "";
            validado_seguido = abrir_ventana(nombre_recor3, x, y3);
            recor_seleccionado = 3;
            bt_recorrido1.Enabled = true;
            bt_recorrido2.Enabled = true;
            bt_recorrido3.Enabled = false;
        }

        // Group boxes
        private void bt_enviar_nom_recor_1_Click(object sender, EventArgs e)
        {
            var (validado, nombre) = validar_nombre(txt_nom.Text);
            if (validado)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        nombre_recor1 = nombre;
                        bt_recorrido1.Text = nombre_recor1;
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_recor1, x, y1);
                        }
                        cambia_nombre = false;
                        return;
                    case 2:
                        nombre_recor2 = nombre;
                        bt_recorrido2.Text = nombre_recor2;
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_recor2, x, y2);
                        }
                        cambia_nombre = false;
                        return;
                    case 3:
                        nombre_recor3 = nombre;
                        bt_recorrido3.Text = nombre_recor3;
                        if (validado_seguido || cambia_nombre)
                        {
                            validado_seguido = abrir_ventana(nombre_recor3, x, y3);
                        }
                        cambia_nombre = false;
                        return;

                }
            }
        }

        private void bt_cambiar_nombre_recor1_Click(object sender, EventArgs e)
        {
            gb_pasos.Visible = false;
            gb_nom.Visible = true;
            cambia_nombre = true;
        }

        private void bt_agregar_paso_recor1_Click(object sender, EventArgs e)
        {
            lbl_tipo_de_paso.Visible = true;
            comb_tipo_paso.Visible = true;
        }

        private void cb_tipo_paso_recor1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comb_tipo_paso.SelectedIndex == 6 || comb_tipo_paso.SelectedIndex == 7)
            {
                bt_enviar_paso.Visible = true;
                nececitar_cant = false;
                lbl_cant_paso.Visible = false;
                txt_cant_paso.Visible = false;
            }
            else if (comb_tipo_paso.SelectedIndex == 2 || comb_tipo_paso.SelectedIndex == 3)
            {
                lbl_cant_paso.Text = "¿Cuántos grados va a girar?";
                unidad = "grados";
                lbl_cant_paso.Visible = true;
                txt_cant_paso.Visible = true;
                bt_enviar_paso.Visible = true;
                nececitar_cant = true;
            }
            else
            {
                lbl_cant_paso.Text = "¿Cuántos segundos va a durar la acción?";
                unidad = "segundos";
                lbl_cant_paso.Visible = true;
                txt_cant_paso.Visible = true;
                bt_enviar_paso.Visible = true;
                nececitar_cant = true;
            }

        }

        private void bt_enviar_paso_recor1_Click(object sender, EventArgs e)
        {
            var (verificado, tipo_paso, cant_paso, paso_hecho) = enviar_y_verificar_paso(comb_tipo_paso.Text, txt_cant_paso.Text, nececitar_cant);
            if (verificado)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        paso_recor_1.Add(tipo_paso);
                        if (!nececitar_cant)
                        {
                            cant_paso_recor_1.Add(0);
                            comb_pasos_hechos_recor1.Items.Add($"{paso_hecho}");
                        }
                        else
                        {
                            cant_paso_recor_1.Add(Convert.ToInt32(cant_paso));
                            comb_pasos_hechos_recor1.Items.Add($"{paso_hecho} {unidad}.");
                        }
                        txt_cant_paso.Text = "";
                        comb_pasos_hechos_recor1.Visible = true;
                        lbl_pasos_hechos.Visible = true;
                        return;
                    case 2:
                        paso_recor_2.Add(tipo_paso);
                        if (!nececitar_cant)
                        {
                            cant_paso_recor_2.Add(0);
                            comb_pasos_hechos_recor2.Items.Add($"{paso_hecho}");
                        }
                        else
                        {
                            cant_paso_recor_2.Add(Convert.ToInt32(cant_paso));
                            comb_pasos_hechos_recor2.Items.Add($"{paso_hecho} {unidad}.");
                        }
                        txt_cant_paso.Text = "";
                        comb_pasos_hechos_recor2.Visible = true;
                        lbl_pasos_hechos.Visible = true;
                        return;
                    case 3:
                        paso_recor_3.Add(tipo_paso);
                        if (!nececitar_cant)
                        {
                            cant_paso_recor_3.Add(0);
                            comb_pasos_hechos_recor3.Items.Add($"{paso_hecho}");
                        }
                        else
                        {
                            cant_paso_recor_3.Add(Convert.ToInt32(cant_paso));
                            comb_pasos_hechos_recor3.Items.Add($"{paso_hecho} {unidad}.");
                        }
                        txt_cant_paso.Text = "";
                        comb_pasos_hechos_recor3.Visible = true;
                        lbl_pasos_hechos.Visible = true;
                        return;
                }

            }
        }

        private void comb_pasos_hechos_recor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_modificar_paso.Visible = true;
        }

        private void bt_modificar_paso_Click(object sender, EventArgs e)
        {
            gb_modificar_paso.Visible = true;
            bt_enviar_nuevo_paso.Visible = false;
            lbl_nuevo_cant_paso.Visible = false;
            txt_nuevo_cant_paso.Visible = false;
        }

        private void comb_nuevo_tipo_paso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_nuevo_tipo_paso.SelectedIndex == 6 || comb_nuevo_tipo_paso.SelectedIndex == 7)
            {
                nuevo_necesitar_cant = false;
                lbl_nuevo_cant_paso.Visible = false;
                txt_nuevo_cant_paso.Visible = false;
                bt_enviar_nuevo_paso.Visible = true;
                nueva_unidad = "";
            }
            else if (comb_nuevo_tipo_paso.SelectedIndex == 3 || comb_nuevo_tipo_paso.SelectedIndex == 4)
            {
                nueva_unidad = "grados";
                nuevo_necesitar_cant = true;
                bt_enviar_nuevo_paso.Visible = true;
                lbl_nuevo_cant_paso.Visible = true;
                txt_nuevo_cant_paso.Text = "";
                txt_nuevo_cant_paso.Visible = true;
            }
            else
            {
                nueva_unidad = "segundos";
                nuevo_necesitar_cant = true;
                bt_enviar_nuevo_paso.Visible = true;
                lbl_nuevo_cant_paso.Visible = true;
                txt_nuevo_cant_paso.Text = "";
                txt_nuevo_cant_paso.Visible = true;
            }

        }

        private void bt_enviar_nuevo_paso_Click(object sender, EventArgs e)
        {
            var (nuevo_paso_verificado, nuevo_tipo_paso, nuevo_cant_paso, nuevo_paso_hecho) = cambiar_y_verificar_paso(comb_nuevo_tipo_paso.Text, txt_nuevo_cant_paso.Text, nuevo_necesitar_cant);
            if (nuevo_paso_verificado)
            {
                switch (recor_seleccionado)
                {
                    case 1:
                        paso_recor_1[comb_pasos_hechos_recor1.SelectedIndex] = nuevo_tipo_paso;
                        if (!nuevo_necesitar_cant)
                        {
                            cant_paso_recor_1[comb_pasos_hechos_recor1.SelectedIndex] = 0;
                            comb_pasos_hechos_recor1.Items[comb_pasos_hechos_recor1.SelectedIndex] = $"{nuevo_paso_hecho}";
                        }
                        else
                        {
                            cant_paso_recor_1[comb_pasos_hechos_recor1.SelectedIndex] = Convert.ToInt32(nuevo_cant_paso);
                            comb_pasos_hechos_recor1.Items[comb_pasos_hechos_recor1.SelectedIndex] = $"{nuevo_paso_hecho} {nueva_unidad}.";
                        }
                        txt_nuevo_cant_paso.Text = "";
                        return;
                    case 2:

                        return;
                    case 3:

                        return;
                }
            }
        }

        //Enviar

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            Funciones func = new Funciones();
            List<string> mensajes = new List<string>();
            for (int i = 0; i < paso_recor_1.Count; i++)
            {
                mensajes.Add(func.string_a_enviar("manejo", -1, -1, "", "", Color.White, -1, 1, i, paso_recor_1[i], cant_paso_recor_1[i]));
            }
            for (int i = 0; i < paso_recor_2.Count; i++)
            {
                mensajes.Add(func.string_a_enviar("manejo", -1, -1, "", "", Color.White, -1, 2, i, paso_recor_2[i], cant_paso_recor_2[i]));
            }
            for (int i = 0; i < paso_recor_3.Count; i++)
            {
                mensajes.Add(func.string_a_enviar("manejo", -1, -1, "", "", Color.White, -1, 3, i, paso_recor_3[i], cant_paso_recor_3[i]));
            }

            string[] nombres_puertos = SerialPort.GetPortNames();
            foreach (string nom_puerto in nombres_puertos)
            {
                serialPortArduino.PortName = nom_puerto;
                serialPortArduino.BaudRate = 9600;
                try
                {
                    serialPortArduino.Open();
                    foreach (string mensaje in mensajes)
                    {
                        serialPortArduino.WriteLine(mensaje + '\n');
                    }
                    serialPortArduino.WriteLine("end");
                    serialPortArduino.Close();
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
        
        private void bt_personalizacion_Click(object sender, EventArgs e)
        {
            Personalización personalización = new Personalización();
            personalización.Show();
            this.Close();
        }
    }
}

