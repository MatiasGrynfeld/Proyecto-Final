using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final___Wingo
{
    public partial class Pantalla_principal : Form
    {
        public int ult_puerto_selec = -1;
        public Pantalla_principal()
        {
            InitializeComponent();
        }

        private void bt_personalización_Click(object sender, EventArgs e)
        {
            Personalización mostrar1 = new Personalización();
            mostrar1.Show();
            this.Hide();
        }

        private void bt_manejo_Click(object sender, EventArgs e)
        {
            Manejo mostrar2 = new Manejo();
            mostrar2.Show();
            this.Hide();
        }

        private void bt_cerrar_app_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ajustes_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
            this.Hide();
        }
    }
}
