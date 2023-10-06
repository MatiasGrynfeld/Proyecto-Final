
namespace Proyecto_Final___Wingo
{
    partial class Pantalla_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_personalización = new System.Windows.Forms.Button();
            this.bt_manejo = new System.Windows.Forms.Button();
            this.bt_cerrar_app = new System.Windows.Forms.Button();
            this.bt_ajustes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_personalización
            // 
            this.bt_personalización.AutoEllipsis = true;
            this.bt_personalización.Location = new System.Drawing.Point(319, 95);
            this.bt_personalización.Name = "bt_personalización";
            this.bt_personalización.Size = new System.Drawing.Size(163, 61);
            this.bt_personalización.TabIndex = 0;
            this.bt_personalización.Text = "Ir a personalización";
            this.bt_personalización.UseVisualStyleBackColor = true;
            this.bt_personalización.Click += new System.EventHandler(this.bt_personalización_Click);
            // 
            // bt_manejo
            // 
            this.bt_manejo.Location = new System.Drawing.Point(319, 195);
            this.bt_manejo.Name = "bt_manejo";
            this.bt_manejo.Size = new System.Drawing.Size(163, 61);
            this.bt_manejo.TabIndex = 1;
            this.bt_manejo.Text = "Ir a manejo";
            this.bt_manejo.UseVisualStyleBackColor = true;
            this.bt_manejo.Click += new System.EventHandler(this.bt_manejo_Click);
            // 
            // bt_cerrar_app
            // 
            this.bt_cerrar_app.Location = new System.Drawing.Point(713, 404);
            this.bt_cerrar_app.Name = "bt_cerrar_app";
            this.bt_cerrar_app.Size = new System.Drawing.Size(75, 23);
            this.bt_cerrar_app.TabIndex = 2;
            this.bt_cerrar_app.Text = "Cerrar";
            this.bt_cerrar_app.UseVisualStyleBackColor = true;
            this.bt_cerrar_app.Click += new System.EventHandler(this.bt_cerrar_app_Click);
            // 
            // bt_ajustes
            // 
            this.bt_ajustes.Location = new System.Drawing.Point(685, 12);
            this.bt_ajustes.Name = "bt_ajustes";
            this.bt_ajustes.Size = new System.Drawing.Size(103, 53);
            this.bt_ajustes.TabIndex = 3;
            this.bt_ajustes.Text = "Configuraciones";
            this.bt_ajustes.UseVisualStyleBackColor = true;
            this.bt_ajustes.Click += new System.EventHandler(this.bt_ajustes_Click);
            // 
            // Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ajustes);
            this.Controls.Add(this.bt_cerrar_app);
            this.Controls.Add(this.bt_manejo);
            this.Controls.Add(this.bt_personalización);
            this.Name = "Pantalla_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_personalización;
        private System.Windows.Forms.Button bt_manejo;
        private System.Windows.Forms.Button bt_cerrar_app;
        private System.Windows.Forms.Button bt_ajustes;
    }
}

