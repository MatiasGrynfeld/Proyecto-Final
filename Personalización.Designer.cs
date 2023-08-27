
namespace Proyecto_Final___Wingo
{
    partial class Personalización
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_volver = new System.Windows.Forms.Button();
            this.bt_perfil_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_nom = new System.Windows.Forms.Panel();
            this.bt_enviar_nombre = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.bt_perfil_2 = new System.Windows.Forms.Button();
            this.panel_wheel = new System.Windows.Forms.Panel();
            this.bt_mouse = new System.Windows.Forms.Button();
            this.bt_pincel = new System.Windows.Forms.Button();
            this.panel_perfil = new System.Windows.Forms.Panel();
            this.comb_angulo = new System.Windows.Forms.ComboBox();
            this.Comb_tipos_personalizados = new System.Windows.Forms.ComboBox();
            this.panel_arriba = new System.Windows.Forms.Panel();
            this.bt_cambiar_nombre = new System.Windows.Forms.Button();
            this.panel_nom.SuspendLayout();
            this.panel_perfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(0, 421);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(61, 23);
            this.bt_volver.TabIndex = 0;
            this.bt_volver.Text = "Cerrar";
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // bt_perfil_1
            // 
            this.bt_perfil_1.Location = new System.Drawing.Point(0, 0);
            this.bt_perfil_1.Name = "bt_perfil_1";
            this.bt_perfil_1.Size = new System.Drawing.Size(61, 217);
            this.bt_perfil_1.TabIndex = 1;
            this.bt_perfil_1.Text = "Nuevo\r\nPerfil\r\n";
            this.bt_perfil_1.UseVisualStyleBackColor = true;
            this.bt_perfil_1.Click += new System.EventHandler(this.bt_perfil_1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_nom
            // 
            this.panel_nom.Controls.Add(this.bt_enviar_nombre);
            this.panel_nom.Controls.Add(this.txt_nombre);
            this.panel_nom.Controls.Add(this.lbl_nombre);
            this.panel_nom.Location = new System.Drawing.Point(0, 672);
            this.panel_nom.Name = "panel_nom";
            this.panel_nom.Size = new System.Drawing.Size(240, 65);
            this.panel_nom.TabIndex = 0;
            // 
            // bt_enviar_nombre
            // 
            this.bt_enviar_nombre.Location = new System.Drawing.Point(152, 16);
            this.bt_enviar_nombre.Name = "bt_enviar_nombre";
            this.bt_enviar_nombre.Size = new System.Drawing.Size(75, 40);
            this.bt_enviar_nombre.TabIndex = 2;
            this.bt_enviar_nombre.Text = "Enviar";
            this.bt_enviar_nombre.UseVisualStyleBackColor = true;
            this.bt_enviar_nombre.Click += new System.EventHandler(this.bt_enviar_nombre_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(6, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(3, 16);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre del perfil:\r\n";
            // 
            // bt_perfil_2
            // 
            this.bt_perfil_2.Location = new System.Drawing.Point(0, 214);
            this.bt_perfil_2.Name = "bt_perfil_2";
            this.bt_perfil_2.Size = new System.Drawing.Size(60, 208);
            this.bt_perfil_2.TabIndex = 4;
            this.bt_perfil_2.Text = "Nuevo\r\nPerfil\r\n";
            this.bt_perfil_2.UseVisualStyleBackColor = true;
            this.bt_perfil_2.Click += new System.EventHandler(this.bt_perfil_2_Click);
            // 
            // panel_wheel
            // 
            this.panel_wheel.Location = new System.Drawing.Point(983, 67);
            this.panel_wheel.Name = "panel_wheel";
            this.panel_wheel.Size = new System.Drawing.Size(375, 551);
            this.panel_wheel.TabIndex = 5;
            // 
            // bt_mouse
            // 
            this.bt_mouse.Enabled = false;
            this.bt_mouse.Location = new System.Drawing.Point(1052, 12);
            this.bt_mouse.Name = "bt_mouse";
            this.bt_mouse.Size = new System.Drawing.Size(39, 36);
            this.bt_mouse.TabIndex = 6;
            this.bt_mouse.Text = "m";
            this.bt_mouse.UseVisualStyleBackColor = true;
            this.bt_mouse.Click += new System.EventHandler(this.bt_mouse_Click);
            // 
            // bt_pincel
            // 
            this.bt_pincel.Location = new System.Drawing.Point(1120, 12);
            this.bt_pincel.Name = "bt_pincel";
            this.bt_pincel.Size = new System.Drawing.Size(39, 36);
            this.bt_pincel.TabIndex = 7;
            this.bt_pincel.Text = "p";
            this.bt_pincel.UseVisualStyleBackColor = true;
            this.bt_pincel.Click += new System.EventHandler(this.bt_pincel_Click);
            // 
            // panel_perfil
            // 
            this.panel_perfil.Controls.Add(this.comb_angulo);
            this.panel_perfil.Controls.Add(this.Comb_tipos_personalizados);
            this.panel_perfil.Controls.Add(this.panel_arriba);
            this.panel_perfil.Controls.Add(this.bt_cambiar_nombre);
            this.panel_perfil.Location = new System.Drawing.Point(66, 0);
            this.panel_perfil.Name = "panel_perfil";
            this.panel_perfil.Size = new System.Drawing.Size(911, 666);
            this.panel_perfil.TabIndex = 3;
            // 
            // comb_angulo
            // 
            this.comb_angulo.FormattingEnabled = true;
            this.comb_angulo.Items.AddRange(new object[] {
            "Arriba",
            "Lado izquierdo",
            "Lado derecho"});
            this.comb_angulo.Location = new System.Drawing.Point(86, 12);
            this.comb_angulo.Name = "comb_angulo";
            this.comb_angulo.Size = new System.Drawing.Size(173, 21);
            this.comb_angulo.TabIndex = 6;
            this.comb_angulo.SelectionChangeCommitted += new System.EventHandler(this.comb_angulo_SelectionChangeCommitted);
            // 
            // Comb_tipos_personalizados
            // 
            this.Comb_tipos_personalizados.FormattingEnabled = true;
            this.Comb_tipos_personalizados.Items.AddRange(new object[] {
            "Independiente"});
            this.Comb_tipos_personalizados.Location = new System.Drawing.Point(86, 40);
            this.Comb_tipos_personalizados.Name = "Comb_tipos_personalizados";
            this.Comb_tipos_personalizados.Size = new System.Drawing.Size(173, 21);
            this.Comb_tipos_personalizados.TabIndex = 4;
            this.Comb_tipos_personalizados.SelectedIndexChanged += new System.EventHandler(this.Comb_tipos__personalizados_SelectedIndexChanged);
            // 
            // panel_arriba
            // 
            this.panel_arriba.Location = new System.Drawing.Point(38, 67);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(836, 574);
            this.panel_arriba.TabIndex = 1;
            this.panel_arriba.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_arriba_Paint);
            this.panel_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_arriba_MouseDown);
            this.panel_arriba.MouseLeave += new System.EventHandler(this.panel_arriba_MouseLeave);
            this.panel_arriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_arriba_MouseMove);
            this.panel_arriba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_arriba_MouseUp);
            // 
            // bt_cambiar_nombre
            // 
            this.bt_cambiar_nombre.Location = new System.Drawing.Point(587, 3);
            this.bt_cambiar_nombre.Name = "bt_cambiar_nombre";
            this.bt_cambiar_nombre.Size = new System.Drawing.Size(147, 58);
            this.bt_cambiar_nombre.TabIndex = 0;
            this.bt_cambiar_nombre.Text = "Cambiar nombre";
            this.bt_cambiar_nombre.UseVisualStyleBackColor = true;
            this.bt_cambiar_nombre.Click += new System.EventHandler(this.bt_cambiar_nombre_Click_1);
            // 
            // Personalización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bt_pincel);
            this.Controls.Add(this.bt_mouse);
            this.Controls.Add(this.panel_wheel);
            this.Controls.Add(this.bt_perfil_2);
            this.Controls.Add(this.panel_nom);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.panel_perfil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_perfil_1);
            this.Name = "Personalización";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalización";
            this.Load += new System.EventHandler(this.Personalización_Load);
            this.panel_nom.ResumeLayout(false);
            this.panel_nom.PerformLayout();
            this.panel_perfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Button bt_perfil_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_perfil_2;
        private System.Windows.Forms.Panel panel_nom;
        private System.Windows.Forms.Button bt_enviar_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Panel panel_wheel;
        private System.Windows.Forms.Button bt_mouse;
        private System.Windows.Forms.Button bt_pincel;
        private System.Windows.Forms.Panel panel_perfil;
        private System.Windows.Forms.Button bt_cambiar_nombre;
        private System.Windows.Forms.Panel panel_arriba;
        private System.Windows.Forms.ComboBox Comb_tipos_personalizados;
        private System.Windows.Forms.ComboBox comb_angulo;
    }
}