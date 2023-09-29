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
    public partial class Ajustes : Form
    {
        public string puerto_seleccionado = "";
        
        public Ajustes()
        {
            InitializeComponent();
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            string[] nombres_puertos = SerialPort.GetPortNames();
            for (int i = 0; i < nombres_puertos.Length; i++)
            {
                Comb_puertos.Items.Add(nombres_puertos[i]);
            }

        }

        void cerrar() 
        {
            Pantalla_principal mostrar0 = new Pantalla_principal();
            if (Comb_puertos.SelectedItem != null)
            {
                //subir a base de datos -> Comb_puertos.SelectedItem.ToString();
            }
            mostrar0.Show();
            this.Close();
        }
        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void Ajustes_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrar();
        }
    }
}
