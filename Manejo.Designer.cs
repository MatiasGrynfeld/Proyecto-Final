
namespace Proyecto_Final___Wingo
{
    partial class Manejo
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
            this.components = new System.ComponentModel.Container();
            this.bt_volver = new System.Windows.Forms.Button();
            this.lbl_crear_recor = new System.Windows.Forms.Label();
            this.bt_recorrido1 = new System.Windows.Forms.Button();
            this.bt_recorrido2 = new System.Windows.Forms.Button();
            this.bt_recorrido3 = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gb_nom = new System.Windows.Forms.GroupBox();
            this.bt_enviar_nom = new System.Windows.Forms.Button();
            this.gb_pasos = new System.Windows.Forms.GroupBox();
            this.bt_eliminar_paso = new System.Windows.Forms.Button();
            this.gb_modificar_paso = new System.Windows.Forms.GroupBox();
            this.comb_nuevo_tipo_paso = new System.Windows.Forms.ComboBox();
            this.txt_nuevo_cant_paso = new System.Windows.Forms.TextBox();
            this.bt_enviar_nuevo_paso = new System.Windows.Forms.Button();
            this.lbl_nuevo_cant_paso = new System.Windows.Forms.Label();
            this.lbl_nuevo_tipo_paso = new System.Windows.Forms.Label();
            this.bt_modificar_paso = new System.Windows.Forms.Button();
            this.comb_pasos_hechos_recor3 = new System.Windows.Forms.ComboBox();
            this.comb_pasos_hechos_recor2 = new System.Windows.Forms.ComboBox();
            this.lbl_pasos_hechos = new System.Windows.Forms.Label();
            this.comb_pasos_hechos_recor1 = new System.Windows.Forms.ComboBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.lbl_pasos_hechos_recor1 = new System.Windows.Forms.Label();
            this.bt_enviar_paso = new System.Windows.Forms.Button();
            this.txt_cant_paso = new System.Windows.Forms.TextBox();
            this.comb_tipo_paso = new System.Windows.Forms.ComboBox();
            this.lbl_cant_paso = new System.Windows.Forms.Label();
            this.lbl_tipo_de_paso = new System.Windows.Forms.Label();
            this.bt_agregar_paso = new System.Windows.Forms.Button();
            this.bt_cambiar_nombre = new System.Windows.Forms.Button();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.bt_personalizacion = new System.Windows.Forms.Button();
            this.txt_delay_carga = new System.Windows.Forms.TextBox();
            this.lbl_delay_carga = new System.Windows.Forms.Label();
            this.gb_nom.SuspendLayout();
            this.gb_pasos.SuspendLayout();
            this.gb_modificar_paso.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(701, 404);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(75, 23);
            this.bt_volver.TabIndex = 1;
            this.bt_volver.Text = "Cerrar";
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // lbl_crear_recor
            // 
            this.lbl_crear_recor.AutoSize = true;
            this.lbl_crear_recor.Location = new System.Drawing.Point(22, 24);
            this.lbl_crear_recor.Name = "lbl_crear_recor";
            this.lbl_crear_recor.Size = new System.Drawing.Size(81, 13);
            this.lbl_crear_recor.TabIndex = 2;
            this.lbl_crear_recor.Text = "Crear recorridos";
            // 
            // bt_recorrido1
            // 
            this.bt_recorrido1.Location = new System.Drawing.Point(25, 54);
            this.bt_recorrido1.Name = "bt_recorrido1";
            this.bt_recorrido1.Size = new System.Drawing.Size(102, 23);
            this.bt_recorrido1.TabIndex = 3;
            this.bt_recorrido1.Text = "Nuevo recorrido";
            this.bt_recorrido1.UseVisualStyleBackColor = true;
            this.bt_recorrido1.Click += new System.EventHandler(this.bt_recorrido1_Click);
            // 
            // bt_recorrido2
            // 
            this.bt_recorrido2.Location = new System.Drawing.Point(25, 94);
            this.bt_recorrido2.Name = "bt_recorrido2";
            this.bt_recorrido2.Size = new System.Drawing.Size(102, 23);
            this.bt_recorrido2.TabIndex = 4;
            this.bt_recorrido2.Text = "Nuevo recorrido";
            this.bt_recorrido2.UseVisualStyleBackColor = true;
            this.bt_recorrido2.Click += new System.EventHandler(this.bt_recorrido2_Click);
            // 
            // bt_recorrido3
            // 
            this.bt_recorrido3.Location = new System.Drawing.Point(25, 137);
            this.bt_recorrido3.Name = "bt_recorrido3";
            this.bt_recorrido3.Size = new System.Drawing.Size(102, 23);
            this.bt_recorrido3.TabIndex = 5;
            this.bt_recorrido3.Text = "Nuevo recorrido";
            this.bt_recorrido3.UseVisualStyleBackColor = true;
            this.bt_recorrido3.Click += new System.EventHandler(this.bt_recorrido3_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(9, 32);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 6;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 16);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(174, 13);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Ingresá un nombre para el recorrido";
            // 
            // gb_nom
            // 
            this.gb_nom.Controls.Add(this.bt_enviar_nom);
            this.gb_nom.Controls.Add(this.lbl_nombre);
            this.gb_nom.Controls.Add(this.txt_nom);
            this.gb_nom.Location = new System.Drawing.Point(10, 391);
            this.gb_nom.Name = "gb_nom";
            this.gb_nom.Size = new System.Drawing.Size(194, 62);
            this.gb_nom.TabIndex = 8;
            this.gb_nom.TabStop = false;
            // 
            // bt_enviar_nom
            // 
            this.bt_enviar_nom.Location = new System.Drawing.Point(113, 33);
            this.bt_enviar_nom.Name = "bt_enviar_nom";
            this.bt_enviar_nom.Size = new System.Drawing.Size(75, 23);
            this.bt_enviar_nom.TabIndex = 8;
            this.bt_enviar_nom.Text = "Enviar";
            this.bt_enviar_nom.UseVisualStyleBackColor = true;
            this.bt_enviar_nom.Click += new System.EventHandler(this.bt_enviar_nom_recor_1_Click);
            // 
            // gb_pasos
            // 
            this.gb_pasos.Controls.Add(this.lbl_delay_carga);
            this.gb_pasos.Controls.Add(this.txt_delay_carga);
            this.gb_pasos.Controls.Add(this.bt_eliminar_paso);
            this.gb_pasos.Controls.Add(this.gb_modificar_paso);
            this.gb_pasos.Controls.Add(this.bt_modificar_paso);
            this.gb_pasos.Controls.Add(this.comb_pasos_hechos_recor3);
            this.gb_pasos.Controls.Add(this.comb_pasos_hechos_recor2);
            this.gb_pasos.Controls.Add(this.lbl_pasos_hechos);
            this.gb_pasos.Controls.Add(this.comb_pasos_hechos_recor1);
            this.gb_pasos.Controls.Add(this.bt_enviar);
            this.gb_pasos.Controls.Add(this.lbl_pasos_hechos_recor1);
            this.gb_pasos.Controls.Add(this.bt_enviar_paso);
            this.gb_pasos.Controls.Add(this.txt_cant_paso);
            this.gb_pasos.Controls.Add(this.comb_tipo_paso);
            this.gb_pasos.Controls.Add(this.lbl_cant_paso);
            this.gb_pasos.Controls.Add(this.lbl_tipo_de_paso);
            this.gb_pasos.Controls.Add(this.bt_agregar_paso);
            this.gb_pasos.Controls.Add(this.bt_cambiar_nombre);
            this.gb_pasos.Location = new System.Drawing.Point(148, 11);
            this.gb_pasos.Name = "gb_pasos";
            this.gb_pasos.Size = new System.Drawing.Size(471, 374);
            this.gb_pasos.TabIndex = 9;
            this.gb_pasos.TabStop = false;
            // 
            // bt_eliminar_paso
            // 
            this.bt_eliminar_paso.Location = new System.Drawing.Point(258, 165);
            this.bt_eliminar_paso.Name = "bt_eliminar_paso";
            this.bt_eliminar_paso.Size = new System.Drawing.Size(92, 23);
            this.bt_eliminar_paso.TabIndex = 16;
            this.bt_eliminar_paso.Text = "Eliminar paso";
            this.bt_eliminar_paso.UseVisualStyleBackColor = true;
            this.bt_eliminar_paso.Click += new System.EventHandler(this.bt_eliminar_paso_Click);
            // 
            // gb_modificar_paso
            // 
            this.gb_modificar_paso.Controls.Add(this.comb_nuevo_tipo_paso);
            this.gb_modificar_paso.Controls.Add(this.txt_nuevo_cant_paso);
            this.gb_modificar_paso.Controls.Add(this.bt_enviar_nuevo_paso);
            this.gb_modificar_paso.Controls.Add(this.lbl_nuevo_cant_paso);
            this.gb_modificar_paso.Controls.Add(this.lbl_nuevo_tipo_paso);
            this.gb_modificar_paso.Location = new System.Drawing.Point(142, 194);
            this.gb_modificar_paso.Name = "gb_modificar_paso";
            this.gb_modificar_paso.Size = new System.Drawing.Size(307, 96);
            this.gb_modificar_paso.TabIndex = 15;
            this.gb_modificar_paso.TabStop = false;
            // 
            // comb_nuevo_tipo_paso
            // 
            this.comb_nuevo_tipo_paso.FormattingEnabled = true;
            this.comb_nuevo_tipo_paso.Items.AddRange(new object[] {
            "Avanzar",
            "Retroceder",
            "Girar hacia la izquierda",
            "Girar hacia la derecha",
            "Esperar",
            "Hacer sonido",
            "Prender luz",
            "Apagar luz",
            "Mantener luz"});
            this.comb_nuevo_tipo_paso.Location = new System.Drawing.Point(10, 27);
            this.comb_nuevo_tipo_paso.Name = "comb_nuevo_tipo_paso";
            this.comb_nuevo_tipo_paso.Size = new System.Drawing.Size(122, 21);
            this.comb_nuevo_tipo_paso.TabIndex = 16;
            this.comb_nuevo_tipo_paso.SelectedIndexChanged += new System.EventHandler(this.comb_nuevo_tipo_paso_SelectedIndexChanged);
            // 
            // txt_nuevo_cant_paso
            // 
            this.txt_nuevo_cant_paso.Location = new System.Drawing.Point(177, 27);
            this.txt_nuevo_cant_paso.Name = "txt_nuevo_cant_paso";
            this.txt_nuevo_cant_paso.Size = new System.Drawing.Size(100, 20);
            this.txt_nuevo_cant_paso.TabIndex = 17;
            // 
            // bt_enviar_nuevo_paso
            // 
            this.bt_enviar_nuevo_paso.Location = new System.Drawing.Point(226, 64);
            this.bt_enviar_nuevo_paso.Name = "bt_enviar_nuevo_paso";
            this.bt_enviar_nuevo_paso.Size = new System.Drawing.Size(75, 23);
            this.bt_enviar_nuevo_paso.TabIndex = 16;
            this.bt_enviar_nuevo_paso.Text = "Enviar";
            this.bt_enviar_nuevo_paso.UseVisualStyleBackColor = true;
            this.bt_enviar_nuevo_paso.Click += new System.EventHandler(this.bt_enviar_nuevo_paso_Click);
            // 
            // lbl_nuevo_cant_paso
            // 
            this.lbl_nuevo_cant_paso.AutoSize = true;
            this.lbl_nuevo_cant_paso.Location = new System.Drawing.Point(162, 11);
            this.lbl_nuevo_cant_paso.Name = "lbl_nuevo_cant_paso";
            this.lbl_nuevo_cant_paso.Size = new System.Drawing.Size(124, 13);
            this.lbl_nuevo_cant_paso.TabIndex = 1;
            this.lbl_nuevo_cant_paso.Text = "Nueva cantidad de paso";
            // 
            // lbl_nuevo_tipo_paso
            // 
            this.lbl_nuevo_tipo_paso.AutoSize = true;
            this.lbl_nuevo_tipo_paso.Location = new System.Drawing.Point(7, 11);
            this.lbl_nuevo_tipo_paso.Name = "lbl_nuevo_tipo_paso";
            this.lbl_nuevo_tipo_paso.Size = new System.Drawing.Size(100, 13);
            this.lbl_nuevo_tipo_paso.TabIndex = 0;
            this.lbl_nuevo_tipo_paso.Text = "Nuevo tipo de paso";
            // 
            // bt_modificar_paso
            // 
            this.bt_modificar_paso.Location = new System.Drawing.Point(357, 165);
            this.bt_modificar_paso.Name = "bt_modificar_paso";
            this.bt_modificar_paso.Size = new System.Drawing.Size(92, 23);
            this.bt_modificar_paso.TabIndex = 14;
            this.bt_modificar_paso.Text = "Modificar paso";
            this.bt_modificar_paso.UseVisualStyleBackColor = true;
            this.bt_modificar_paso.Click += new System.EventHandler(this.bt_modificar_paso_Click);
            // 
            // comb_pasos_hechos_recor3
            // 
            this.comb_pasos_hechos_recor3.FormattingEnabled = true;
            this.comb_pasos_hechos_recor3.Location = new System.Drawing.Point(220, 70);
            this.comb_pasos_hechos_recor3.Name = "comb_pasos_hechos_recor3";
            this.comb_pasos_hechos_recor3.Size = new System.Drawing.Size(191, 21);
            this.comb_pasos_hechos_recor3.TabIndex = 13;
            this.comb_pasos_hechos_recor3.SelectedIndexChanged += new System.EventHandler(this.comb_pasos_hechos_recor3_SelectedIndexChanged);
            // 
            // comb_pasos_hechos_recor2
            // 
            this.comb_pasos_hechos_recor2.FormattingEnabled = true;
            this.comb_pasos_hechos_recor2.Location = new System.Drawing.Point(146, 32);
            this.comb_pasos_hechos_recor2.Name = "comb_pasos_hechos_recor2";
            this.comb_pasos_hechos_recor2.Size = new System.Drawing.Size(191, 21);
            this.comb_pasos_hechos_recor2.TabIndex = 12;
            this.comb_pasos_hechos_recor2.SelectedIndexChanged += new System.EventHandler(this.comb_pasos_hechos_recor2_SelectedIndexChanged);
            // 
            // lbl_pasos_hechos
            // 
            this.lbl_pasos_hechos.AutoSize = true;
            this.lbl_pasos_hechos.Location = new System.Drawing.Point(255, 106);
            this.lbl_pasos_hechos.Name = "lbl_pasos_hechos";
            this.lbl_pasos_hechos.Size = new System.Drawing.Size(77, 13);
            this.lbl_pasos_hechos.TabIndex = 11;
            this.lbl_pasos_hechos.Text = "Pasos hechos:";
            // 
            // comb_pasos_hechos_recor1
            // 
            this.comb_pasos_hechos_recor1.FormattingEnabled = true;
            this.comb_pasos_hechos_recor1.Location = new System.Drawing.Point(258, 128);
            this.comb_pasos_hechos_recor1.Name = "comb_pasos_hechos_recor1";
            this.comb_pasos_hechos_recor1.Size = new System.Drawing.Size(191, 21);
            this.comb_pasos_hechos_recor1.TabIndex = 10;
            this.comb_pasos_hechos_recor1.SelectedIndexChanged += new System.EventHandler(this.comb_pasos_hechos_recor1_SelectedIndexChanged);
            // 
            // bt_enviar
            // 
            this.bt_enviar.Location = new System.Drawing.Point(350, 320);
            this.bt_enviar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(99, 49);
            this.bt_enviar.TabIndex = 8;
            this.bt_enviar.Text = "Enviar recorrido";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // lbl_pasos_hechos_recor1
            // 
            this.lbl_pasos_hechos_recor1.AutoSize = true;
            this.lbl_pasos_hechos_recor1.Location = new System.Drawing.Point(214, 91);
            this.lbl_pasos_hechos_recor1.Name = "lbl_pasos_hechos_recor1";
            this.lbl_pasos_hechos_recor1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pasos_hechos_recor1.TabIndex = 7;
            // 
            // bt_enviar_paso
            // 
            this.bt_enviar_paso.Location = new System.Drawing.Point(23, 258);
            this.bt_enviar_paso.Name = "bt_enviar_paso";
            this.bt_enviar_paso.Size = new System.Drawing.Size(75, 23);
            this.bt_enviar_paso.TabIndex = 6;
            this.bt_enviar_paso.Text = "Enviar";
            this.bt_enviar_paso.UseVisualStyleBackColor = true;
            this.bt_enviar_paso.Click += new System.EventHandler(this.bt_enviar_paso_recor1_Click);
            // 
            // txt_cant_paso
            // 
            this.txt_cant_paso.Location = new System.Drawing.Point(22, 209);
            this.txt_cant_paso.Name = "txt_cant_paso";
            this.txt_cant_paso.Size = new System.Drawing.Size(100, 20);
            this.txt_cant_paso.TabIndex = 5;
            // 
            // comb_tipo_paso
            // 
            this.comb_tipo_paso.FormattingEnabled = true;
            this.comb_tipo_paso.Items.AddRange(new object[] {
            "Avanzar",
            "Retroceder",
            "Girar hacia la izquierda",
            "Girar hacia la derecha",
            "Esperar"});
            this.comb_tipo_paso.Location = new System.Drawing.Point(23, 128);
            this.comb_tipo_paso.Name = "comb_tipo_paso";
            this.comb_tipo_paso.Size = new System.Drawing.Size(122, 21);
            this.comb_tipo_paso.TabIndex = 4;
            this.comb_tipo_paso.SelectionChangeCommitted += new System.EventHandler(this.cb_tipo_paso_recor1_SelectionChangeCommitted);
            // 
            // lbl_cant_paso
            // 
            this.lbl_cant_paso.AutoSize = true;
            this.lbl_cant_paso.Location = new System.Drawing.Point(26, 175);
            this.lbl_cant_paso.Name = "lbl_cant_paso";
            this.lbl_cant_paso.Size = new System.Drawing.Size(53, 13);
            this.lbl_cant_paso.TabIndex = 3;
            this.lbl_cant_paso.Text = "¿Cuánto?";
            // 
            // lbl_tipo_de_paso
            // 
            this.lbl_tipo_de_paso.AutoSize = true;
            this.lbl_tipo_de_paso.Location = new System.Drawing.Point(26, 106);
            this.lbl_tipo_de_paso.Name = "lbl_tipo_de_paso";
            this.lbl_tipo_de_paso.Size = new System.Drawing.Size(135, 13);
            this.lbl_tipo_de_paso.TabIndex = 2;
            this.lbl_tipo_de_paso.Text = "Seleccionar el tipo de paso";
            // 
            // bt_agregar_paso
            // 
            this.bt_agregar_paso.Location = new System.Drawing.Point(23, 18);
            this.bt_agregar_paso.Name = "bt_agregar_paso";
            this.bt_agregar_paso.Size = new System.Drawing.Size(106, 46);
            this.bt_agregar_paso.TabIndex = 1;
            this.bt_agregar_paso.Text = "Agregar Paso";
            this.bt_agregar_paso.UseVisualStyleBackColor = true;
            this.bt_agregar_paso.Click += new System.EventHandler(this.bt_agregar_paso_recor1_Click);
            // 
            // bt_cambiar_nombre
            // 
            this.bt_cambiar_nombre.Location = new System.Drawing.Point(343, 18);
            this.bt_cambiar_nombre.Name = "bt_cambiar_nombre";
            this.bt_cambiar_nombre.Size = new System.Drawing.Size(106, 46);
            this.bt_cambiar_nombre.TabIndex = 0;
            this.bt_cambiar_nombre.Text = "Cambiar nombre del recorrido";
            this.bt_cambiar_nombre.UseVisualStyleBackColor = true;
            this.bt_cambiar_nombre.Click += new System.EventHandler(this.bt_cambiar_nombre_recor1_Click);
            // 
            // bt_personalizacion
            // 
            this.bt_personalizacion.Location = new System.Drawing.Point(25, 181);
            this.bt_personalizacion.Name = "bt_personalizacion";
            this.bt_personalizacion.Size = new System.Drawing.Size(102, 48);
            this.bt_personalizacion.TabIndex = 10;
            this.bt_personalizacion.Text = "Ir a personalización";
            this.bt_personalizacion.UseVisualStyleBackColor = true;
            this.bt_personalizacion.Click += new System.EventHandler(this.bt_personalizacion_Click);
            // 
            // txt_delay_carga
            // 
            this.txt_delay_carga.Location = new System.Drawing.Point(220, 336);
            this.txt_delay_carga.Name = "txt_delay_carga";
            this.txt_delay_carga.Size = new System.Drawing.Size(100, 20);
            this.txt_delay_carga.TabIndex = 17;
            // 
            // lbl_delay_carga
            // 
            this.lbl_delay_carga.AutoSize = true;
            this.lbl_delay_carga.Location = new System.Drawing.Point(40, 330);
            this.lbl_delay_carga.Name = "lbl_delay_carga";
            this.lbl_delay_carga.Size = new System.Drawing.Size(150, 26);
            this.lbl_delay_carga.TabIndex = 18;
            this.lbl_delay_carga.Text = "Seleccionar el delay de carga \r\ndespués de subir los mensajes";
            // 
            // Manejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_personalizacion);
            this.Controls.Add(this.gb_pasos);
            this.Controls.Add(this.gb_nom);
            this.Controls.Add(this.bt_recorrido3);
            this.Controls.Add(this.bt_recorrido2);
            this.Controls.Add(this.bt_recorrido1);
            this.Controls.Add(this.lbl_crear_recor);
            this.Controls.Add(this.bt_volver);
            this.Name = "Manejo";
            this.Text = "Manejo";
            this.Load += new System.EventHandler(this.Manejo_Load);
            this.gb_nom.ResumeLayout(false);
            this.gb_nom.PerformLayout();
            this.gb_pasos.ResumeLayout(false);
            this.gb_pasos.PerformLayout();
            this.gb_modificar_paso.ResumeLayout(false);
            this.gb_modificar_paso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Label lbl_crear_recor;
        private System.Windows.Forms.Button bt_recorrido1;
        private System.Windows.Forms.Button bt_recorrido2;
        private System.Windows.Forms.Button bt_recorrido3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.GroupBox gb_nom;
        private System.Windows.Forms.Button bt_enviar_nom;
        private System.Windows.Forms.GroupBox gb_pasos;
        private System.Windows.Forms.Button bt_enviar_paso;
        private System.Windows.Forms.TextBox txt_cant_paso;
        private System.Windows.Forms.ComboBox comb_tipo_paso;
        private System.Windows.Forms.Label lbl_cant_paso;
        private System.Windows.Forms.Label lbl_tipo_de_paso;
        private System.Windows.Forms.Button bt_agregar_paso;
        private System.Windows.Forms.Button bt_cambiar_nombre;
        private System.Windows.Forms.Label lbl_pasos_hechos_recor1;
        private System.Windows.Forms.Button bt_enviar;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.Label lbl_pasos_hechos;
        private System.Windows.Forms.ComboBox comb_pasos_hechos_recor1;
        private System.Windows.Forms.ComboBox comb_pasos_hechos_recor3;
        private System.Windows.Forms.ComboBox comb_pasos_hechos_recor2;
        private System.Windows.Forms.Button bt_modificar_paso;
        private System.Windows.Forms.GroupBox gb_modificar_paso;
        private System.Windows.Forms.ComboBox comb_nuevo_tipo_paso;
        private System.Windows.Forms.TextBox txt_nuevo_cant_paso;
        private System.Windows.Forms.Button bt_enviar_nuevo_paso;
        private System.Windows.Forms.Label lbl_nuevo_cant_paso;
        private System.Windows.Forms.Label lbl_nuevo_tipo_paso;
        private System.Windows.Forms.Button bt_personalizacion;
        private System.Windows.Forms.Button bt_eliminar_paso;
        private System.Windows.Forms.Label lbl_delay_carga;
        private System.Windows.Forms.TextBox txt_delay_carga;
    }
}