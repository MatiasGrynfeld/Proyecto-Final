﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manejo));
            this.lbl_crear_recor = new System.Windows.Forms.Label();
            this.bt_recorrido1 = new System.Windows.Forms.Button();
            this.bt_recorrido2 = new System.Windows.Forms.Button();
            this.bt_recorrido3 = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.bt_enviar_nom = new System.Windows.Forms.Button();
            this.lbl_delay_carga = new System.Windows.Forms.Label();
            this.txt_delay_carga = new System.Windows.Forms.TextBox();
            this.bt_eliminar_paso = new System.Windows.Forms.Button();
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
            this.bt_personalizacion = new System.Windows.Forms.Button();
            this.panel_recors = new System.Windows.Forms.Panel();
            this.panel_nom = new System.Windows.Forms.Panel();
            this.panel_pasos = new System.Windows.Forms.Panel();
            this.panel_modificar_paso = new System.Windows.Forms.Panel();
            this.panel_envio = new System.Windows.Forms.Panel();
            this.bt_cerrar = new FontAwesome.Sharp.IconButton();
            this.panel_recors.SuspendLayout();
            this.panel_nom.SuspendLayout();
            this.panel_pasos.SuspendLayout();
            this.panel_modificar_paso.SuspendLayout();
            this.panel_envio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_crear_recor
            // 
            this.lbl_crear_recor.AutoSize = true;
            this.lbl_crear_recor.Location = new System.Drawing.Point(3, 9);
            this.lbl_crear_recor.Name = "lbl_crear_recor";
            this.lbl_crear_recor.Size = new System.Drawing.Size(53, 26);
            this.lbl_crear_recor.TabIndex = 2;
            this.lbl_crear_recor.Text = "    Crear\r\nrecorridos";
            // 
            // bt_recorrido1
            // 
            this.bt_recorrido1.Location = new System.Drawing.Point(0, 72);
            this.bt_recorrido1.Name = "bt_recorrido1";
            this.bt_recorrido1.Size = new System.Drawing.Size(213, 60);
            this.bt_recorrido1.TabIndex = 3;
            this.bt_recorrido1.Text = "Nuevo recorrido";
            this.bt_recorrido1.UseVisualStyleBackColor = true;
            this.bt_recorrido1.Click += new System.EventHandler(this.bt_recorrido1_Click);
            // 
            // bt_recorrido2
            // 
            this.bt_recorrido2.Location = new System.Drawing.Point(0, 154);
            this.bt_recorrido2.Name = "bt_recorrido2";
            this.bt_recorrido2.Size = new System.Drawing.Size(213, 60);
            this.bt_recorrido2.TabIndex = 4;
            this.bt_recorrido2.Text = "Nuevo recorrido";
            this.bt_recorrido2.UseVisualStyleBackColor = true;
            this.bt_recorrido2.Click += new System.EventHandler(this.bt_recorrido2_Click);
            // 
            // bt_recorrido3
            // 
            this.bt_recorrido3.Location = new System.Drawing.Point(0, 233);
            this.bt_recorrido3.Name = "bt_recorrido3";
            this.bt_recorrido3.Size = new System.Drawing.Size(213, 60);
            this.bt_recorrido3.TabIndex = 5;
            this.bt_recorrido3.Text = "Nuevo recorrido";
            this.bt_recorrido3.UseVisualStyleBackColor = true;
            this.bt_recorrido3.Click += new System.EventHandler(this.bt_recorrido3_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(9, 52);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(171, 20);
            this.txt_nom.TabIndex = 6;
            this.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 7);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(174, 13);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Ingresá un nombre para el recorrido";
            // 
            // bt_enviar_nom
            // 
            this.bt_enviar_nom.Location = new System.Drawing.Point(194, 37);
            this.bt_enviar_nom.Name = "bt_enviar_nom";
            this.bt_enviar_nom.Size = new System.Drawing.Size(87, 52);
            this.bt_enviar_nom.TabIndex = 8;
            this.bt_enviar_nom.Text = "Enviar";
            this.bt_enviar_nom.UseVisualStyleBackColor = true;
            this.bt_enviar_nom.Click += new System.EventHandler(this.bt_enviar_nom_recor_1_Click);
            // 
            // lbl_delay_carga
            // 
            this.lbl_delay_carga.AutoSize = true;
            this.lbl_delay_carga.Location = new System.Drawing.Point(75, 24);
            this.lbl_delay_carga.Name = "lbl_delay_carga";
            this.lbl_delay_carga.Size = new System.Drawing.Size(193, 26);
            this.lbl_delay_carga.TabIndex = 18;
            this.lbl_delay_carga.Text = "Seleccionar el delay de carga después \r\nde subir los mensajes (en segundos)";
            // 
            // txt_delay_carga
            // 
            this.txt_delay_carga.Location = new System.Drawing.Point(78, 112);
            this.txt_delay_carga.Name = "txt_delay_carga";
            this.txt_delay_carga.Size = new System.Drawing.Size(190, 20);
            this.txt_delay_carga.TabIndex = 17;
            // 
            // bt_eliminar_paso
            // 
            this.bt_eliminar_paso.Location = new System.Drawing.Point(733, 104);
            this.bt_eliminar_paso.Name = "bt_eliminar_paso";
            this.bt_eliminar_paso.Size = new System.Drawing.Size(111, 41);
            this.bt_eliminar_paso.TabIndex = 16;
            this.bt_eliminar_paso.Text = "Eliminar paso";
            this.bt_eliminar_paso.UseVisualStyleBackColor = true;
            this.bt_eliminar_paso.Click += new System.EventHandler(this.bt_eliminar_paso_Click);
            // 
            // comb_nuevo_tipo_paso
            // 
            this.comb_nuevo_tipo_paso.FormattingEnabled = true;
            this.comb_nuevo_tipo_paso.Items.AddRange(new object[] {
            "Avanzar",
            "Retroceder",
            "Girar hacia la izquierda",
            "Girar hacia la derecha",
            "Esperar"});
            this.comb_nuevo_tipo_paso.Location = new System.Drawing.Point(23, 56);
            this.comb_nuevo_tipo_paso.Name = "comb_nuevo_tipo_paso";
            this.comb_nuevo_tipo_paso.Size = new System.Drawing.Size(122, 21);
            this.comb_nuevo_tipo_paso.TabIndex = 16;
            this.comb_nuevo_tipo_paso.SelectedIndexChanged += new System.EventHandler(this.comb_nuevo_tipo_paso_SelectedIndexChanged);
            // 
            // txt_nuevo_cant_paso
            // 
            this.txt_nuevo_cant_paso.Location = new System.Drawing.Point(24, 168);
            this.txt_nuevo_cant_paso.Name = "txt_nuevo_cant_paso";
            this.txt_nuevo_cant_paso.Size = new System.Drawing.Size(100, 20);
            this.txt_nuevo_cant_paso.TabIndex = 17;
            // 
            // bt_enviar_nuevo_paso
            // 
            this.bt_enviar_nuevo_paso.Location = new System.Drawing.Point(219, 66);
            this.bt_enviar_nuevo_paso.Name = "bt_enviar_nuevo_paso";
            this.bt_enviar_nuevo_paso.Size = new System.Drawing.Size(168, 78);
            this.bt_enviar_nuevo_paso.TabIndex = 16;
            this.bt_enviar_nuevo_paso.Text = "Enviar";
            this.bt_enviar_nuevo_paso.UseVisualStyleBackColor = true;
            this.bt_enviar_nuevo_paso.Click += new System.EventHandler(this.bt_enviar_nuevo_paso_Click);
            // 
            // lbl_nuevo_cant_paso
            // 
            this.lbl_nuevo_cant_paso.AutoSize = true;
            this.lbl_nuevo_cant_paso.Location = new System.Drawing.Point(21, 121);
            this.lbl_nuevo_cant_paso.Name = "lbl_nuevo_cant_paso";
            this.lbl_nuevo_cant_paso.Size = new System.Drawing.Size(124, 13);
            this.lbl_nuevo_cant_paso.TabIndex = 1;
            this.lbl_nuevo_cant_paso.Text = "Nueva cantidad de paso";
            // 
            // lbl_nuevo_tipo_paso
            // 
            this.lbl_nuevo_tipo_paso.AutoSize = true;
            this.lbl_nuevo_tipo_paso.Location = new System.Drawing.Point(21, 13);
            this.lbl_nuevo_tipo_paso.Name = "lbl_nuevo_tipo_paso";
            this.lbl_nuevo_tipo_paso.Size = new System.Drawing.Size(100, 13);
            this.lbl_nuevo_tipo_paso.TabIndex = 0;
            this.lbl_nuevo_tipo_paso.Text = "Nuevo tipo de paso";
            // 
            // bt_modificar_paso
            // 
            this.bt_modificar_paso.Location = new System.Drawing.Point(861, 104);
            this.bt_modificar_paso.Name = "bt_modificar_paso";
            this.bt_modificar_paso.Size = new System.Drawing.Size(116, 41);
            this.bt_modificar_paso.TabIndex = 14;
            this.bt_modificar_paso.Text = "Modificar paso";
            this.bt_modificar_paso.UseVisualStyleBackColor = true;
            this.bt_modificar_paso.Click += new System.EventHandler(this.bt_modificar_paso_Click);
            // 
            // comb_pasos_hechos_recor3
            // 
            this.comb_pasos_hechos_recor3.FormattingEnabled = true;
            this.comb_pasos_hechos_recor3.Location = new System.Drawing.Point(520, 12);
            this.comb_pasos_hechos_recor3.Name = "comb_pasos_hechos_recor3";
            this.comb_pasos_hechos_recor3.Size = new System.Drawing.Size(191, 21);
            this.comb_pasos_hechos_recor3.TabIndex = 13;
            this.comb_pasos_hechos_recor3.SelectedIndexChanged += new System.EventHandler(this.comb_pasos_hechos_recor3_SelectedIndexChanged);
            // 
            // comb_pasos_hechos_recor2
            // 
            this.comb_pasos_hechos_recor2.FormattingEnabled = true;
            this.comb_pasos_hechos_recor2.Location = new System.Drawing.Point(520, 39);
            this.comb_pasos_hechos_recor2.Name = "comb_pasos_hechos_recor2";
            this.comb_pasos_hechos_recor2.Size = new System.Drawing.Size(191, 21);
            this.comb_pasos_hechos_recor2.TabIndex = 12;
            this.comb_pasos_hechos_recor2.SelectedIndexChanged += new System.EventHandler(this.comb_pasos_hechos_recor2_SelectedIndexChanged);
            // 
            // lbl_pasos_hechos
            // 
            this.lbl_pasos_hechos.AutoSize = true;
            this.lbl_pasos_hechos.Location = new System.Drawing.Point(818, 28);
            this.lbl_pasos_hechos.Name = "lbl_pasos_hechos";
            this.lbl_pasos_hechos.Size = new System.Drawing.Size(77, 13);
            this.lbl_pasos_hechos.TabIndex = 11;
            this.lbl_pasos_hechos.Text = "Pasos hechos:";
            // 
            // comb_pasos_hechos_recor1
            // 
            this.comb_pasos_hechos_recor1.FormattingEnabled = true;
            this.comb_pasos_hechos_recor1.Location = new System.Drawing.Point(760, 71);
            this.comb_pasos_hechos_recor1.Name = "comb_pasos_hechos_recor1";
            this.comb_pasos_hechos_recor1.Size = new System.Drawing.Size(191, 21);
            this.comb_pasos_hechos_recor1.TabIndex = 10;
            this.comb_pasos_hechos_recor1.SelectedIndexChanged += new System.EventHandler(this.comb_pasos_hechos_recor1_SelectedIndexChanged);
            // 
            // bt_enviar
            // 
            this.bt_enviar.Location = new System.Drawing.Point(414, 24);
            this.bt_enviar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(187, 98);
            this.bt_enviar.TabIndex = 8;
            this.bt_enviar.Text = "Enviar recorrido";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // lbl_pasos_hechos_recor1
            // 
            this.lbl_pasos_hechos_recor1.AutoSize = true;
            this.lbl_pasos_hechos_recor1.Location = new System.Drawing.Point(260, 120);
            this.lbl_pasos_hechos_recor1.Name = "lbl_pasos_hechos_recor1";
            this.lbl_pasos_hechos_recor1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pasos_hechos_recor1.TabIndex = 7;
            // 
            // bt_enviar_paso
            // 
            this.bt_enviar_paso.Location = new System.Drawing.Point(50, 325);
            this.bt_enviar_paso.Name = "bt_enviar_paso";
            this.bt_enviar_paso.Size = new System.Drawing.Size(168, 78);
            this.bt_enviar_paso.TabIndex = 6;
            this.bt_enviar_paso.Text = "Enviar";
            this.bt_enviar_paso.UseVisualStyleBackColor = true;
            this.bt_enviar_paso.Click += new System.EventHandler(this.bt_enviar_paso_recor1_Click);
            // 
            // txt_cant_paso
            // 
            this.txt_cant_paso.Location = new System.Drawing.Point(75, 258);
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
            this.comb_tipo_paso.Location = new System.Drawing.Point(75, 181);
            this.comb_tipo_paso.Name = "comb_tipo_paso";
            this.comb_tipo_paso.Size = new System.Drawing.Size(122, 21);
            this.comb_tipo_paso.TabIndex = 4;
            this.comb_tipo_paso.SelectionChangeCommitted += new System.EventHandler(this.cb_tipo_paso_recor1_SelectionChangeCommitted);
            // 
            // lbl_cant_paso
            // 
            this.lbl_cant_paso.AutoSize = true;
            this.lbl_cant_paso.Location = new System.Drawing.Point(72, 222);
            this.lbl_cant_paso.Name = "lbl_cant_paso";
            this.lbl_cant_paso.Size = new System.Drawing.Size(53, 13);
            this.lbl_cant_paso.TabIndex = 3;
            this.lbl_cant_paso.Text = "¿Cuánto?";
            // 
            // lbl_tipo_de_paso
            // 
            this.lbl_tipo_de_paso.AutoSize = true;
            this.lbl_tipo_de_paso.Location = new System.Drawing.Point(72, 135);
            this.lbl_tipo_de_paso.Name = "lbl_tipo_de_paso";
            this.lbl_tipo_de_paso.Size = new System.Drawing.Size(135, 13);
            this.lbl_tipo_de_paso.TabIndex = 2;
            this.lbl_tipo_de_paso.Text = "Seleccionar el tipo de paso";
            // 
            // bt_agregar_paso
            // 
            this.bt_agregar_paso.Location = new System.Drawing.Point(180, 12);
            this.bt_agregar_paso.Name = "bt_agregar_paso";
            this.bt_agregar_paso.Size = new System.Drawing.Size(146, 69);
            this.bt_agregar_paso.TabIndex = 1;
            this.bt_agregar_paso.Text = "Agregar Paso";
            this.bt_agregar_paso.UseVisualStyleBackColor = true;
            this.bt_agregar_paso.Click += new System.EventHandler(this.bt_agregar_paso_recor1_Click);
            // 
            // bt_cambiar_nombre
            // 
            this.bt_cambiar_nombre.Location = new System.Drawing.Point(19, 12);
            this.bt_cambiar_nombre.Name = "bt_cambiar_nombre";
            this.bt_cambiar_nombre.Size = new System.Drawing.Size(137, 69);
            this.bt_cambiar_nombre.TabIndex = 0;
            this.bt_cambiar_nombre.Text = "Cambiar nombre del recorrido";
            this.bt_cambiar_nombre.UseVisualStyleBackColor = true;
            this.bt_cambiar_nombre.Click += new System.EventHandler(this.bt_cambiar_nombre_recor1_Click);
            // 
            // bt_personalizacion
            // 
            this.bt_personalizacion.Location = new System.Drawing.Point(0, 461);
            this.bt_personalizacion.Name = "bt_personalizacion";
            this.bt_personalizacion.Size = new System.Drawing.Size(213, 60);
            this.bt_personalizacion.TabIndex = 10;
            this.bt_personalizacion.Text = "Ir a personalización";
            this.bt_personalizacion.UseVisualStyleBackColor = true;
            this.bt_personalizacion.Click += new System.EventHandler(this.bt_personalizacion_Click);
            // 
            // panel_recors
            // 
            this.panel_recors.Controls.Add(this.bt_cerrar);
            this.panel_recors.Controls.Add(this.lbl_crear_recor);
            this.panel_recors.Controls.Add(this.bt_personalizacion);
            this.panel_recors.Controls.Add(this.bt_recorrido1);
            this.panel_recors.Controls.Add(this.bt_recorrido2);
            this.panel_recors.Controls.Add(this.bt_recorrido3);
            this.panel_recors.Location = new System.Drawing.Point(0, 0);
            this.panel_recors.Name = "panel_recors";
            this.panel_recors.Size = new System.Drawing.Size(221, 639);
            this.panel_recors.TabIndex = 11;
            // 
            // panel_nom
            // 
            this.panel_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))));
            this.panel_nom.Controls.Add(this.bt_enviar_nom);
            this.panel_nom.Controls.Add(this.lbl_nombre);
            this.panel_nom.Controls.Add(this.txt_nom);
            this.panel_nom.Location = new System.Drawing.Point(57, 658);
            this.panel_nom.Name = "panel_nom";
            this.panel_nom.Size = new System.Drawing.Size(297, 91);
            this.panel_nom.TabIndex = 12;
            // 
            // panel_pasos
            // 
            this.panel_pasos.Controls.Add(this.panel_modificar_paso);
            this.panel_pasos.Controls.Add(this.panel_envio);
            this.panel_pasos.Controls.Add(this.comb_pasos_hechos_recor3);
            this.panel_pasos.Controls.Add(this.comb_pasos_hechos_recor2);
            this.panel_pasos.Controls.Add(this.bt_agregar_paso);
            this.panel_pasos.Controls.Add(this.bt_cambiar_nombre);
            this.panel_pasos.Controls.Add(this.lbl_tipo_de_paso);
            this.panel_pasos.Controls.Add(this.bt_eliminar_paso);
            this.panel_pasos.Controls.Add(this.lbl_cant_paso);
            this.panel_pasos.Controls.Add(this.comb_tipo_paso);
            this.panel_pasos.Controls.Add(this.bt_modificar_paso);
            this.panel_pasos.Controls.Add(this.txt_cant_paso);
            this.panel_pasos.Controls.Add(this.bt_enviar_paso);
            this.panel_pasos.Controls.Add(this.lbl_pasos_hechos_recor1);
            this.panel_pasos.Controls.Add(this.lbl_pasos_hechos);
            this.panel_pasos.Controls.Add(this.comb_pasos_hechos_recor1);
            this.panel_pasos.Location = new System.Drawing.Point(219, 0);
            this.panel_pasos.Name = "panel_pasos";
            this.panel_pasos.Size = new System.Drawing.Size(1047, 685);
            this.panel_pasos.TabIndex = 13;
            // 
            // panel_modificar_paso
            // 
            this.panel_modificar_paso.Controls.Add(this.bt_enviar_nuevo_paso);
            this.panel_modificar_paso.Controls.Add(this.txt_nuevo_cant_paso);
            this.panel_modificar_paso.Controls.Add(this.comb_nuevo_tipo_paso);
            this.panel_modificar_paso.Controls.Add(this.lbl_nuevo_tipo_paso);
            this.panel_modificar_paso.Controls.Add(this.lbl_nuevo_cant_paso);
            this.panel_modificar_paso.Location = new System.Drawing.Point(602, 204);
            this.panel_modificar_paso.Name = "panel_modificar_paso";
            this.panel_modificar_paso.Size = new System.Drawing.Size(421, 210);
            this.panel_modificar_paso.TabIndex = 20;
            // 
            // panel_envio
            // 
            this.panel_envio.Controls.Add(this.lbl_delay_carga);
            this.panel_envio.Controls.Add(this.bt_enviar);
            this.panel_envio.Controls.Add(this.txt_delay_carga);
            this.panel_envio.Location = new System.Drawing.Point(407, 507);
            this.panel_envio.Name = "panel_envio";
            this.panel_envio.Size = new System.Drawing.Size(626, 162);
            this.panel_envio.TabIndex = 19;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.bt_cerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))));
            this.bt_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_cerrar.Location = new System.Drawing.Point(0, 550);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(213, 60);
            this.bt_cerrar.TabIndex = 11;
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Manejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_pasos);
            this.Controls.Add(this.panel_nom);
            this.Controls.Add(this.panel_recors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manejo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo";
            this.Load += new System.EventHandler(this.Manejo_Load);
            this.panel_recors.ResumeLayout(false);
            this.panel_recors.PerformLayout();
            this.panel_nom.ResumeLayout(false);
            this.panel_nom.PerformLayout();
            this.panel_pasos.ResumeLayout(false);
            this.panel_pasos.PerformLayout();
            this.panel_modificar_paso.ResumeLayout(false);
            this.panel_modificar_paso.PerformLayout();
            this.panel_envio.ResumeLayout(false);
            this.panel_envio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_crear_recor;
        private System.Windows.Forms.Button bt_recorrido1;
        private System.Windows.Forms.Button bt_recorrido2;
        private System.Windows.Forms.Button bt_recorrido3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button bt_enviar_nom;
        private System.Windows.Forms.Button bt_enviar_paso;
        private System.Windows.Forms.TextBox txt_cant_paso;
        private System.Windows.Forms.ComboBox comb_tipo_paso;
        private System.Windows.Forms.Label lbl_cant_paso;
        private System.Windows.Forms.Label lbl_tipo_de_paso;
        private System.Windows.Forms.Button bt_agregar_paso;
        private System.Windows.Forms.Button bt_cambiar_nombre;
        private System.Windows.Forms.Label lbl_pasos_hechos_recor1;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.Label lbl_pasos_hechos;
        private System.Windows.Forms.ComboBox comb_pasos_hechos_recor1;
        private System.Windows.Forms.ComboBox comb_pasos_hechos_recor3;
        private System.Windows.Forms.ComboBox comb_pasos_hechos_recor2;
        private System.Windows.Forms.Button bt_modificar_paso;
        private System.Windows.Forms.ComboBox comb_nuevo_tipo_paso;
        private System.Windows.Forms.TextBox txt_nuevo_cant_paso;
        private System.Windows.Forms.Button bt_enviar_nuevo_paso;
        private System.Windows.Forms.Label lbl_nuevo_cant_paso;
        private System.Windows.Forms.Label lbl_nuevo_tipo_paso;
        private System.Windows.Forms.Button bt_personalizacion;
        private System.Windows.Forms.Button bt_eliminar_paso;
        private System.Windows.Forms.Label lbl_delay_carga;
        private System.Windows.Forms.TextBox txt_delay_carga;
        private System.Windows.Forms.Panel panel_recors;
        private System.Windows.Forms.Panel panel_nom;
        private System.Windows.Forms.Panel panel_pasos;
        private System.Windows.Forms.Panel panel_modificar_paso;
        private System.Windows.Forms.Panel panel_envio;
        private FontAwesome.Sharp.IconButton bt_cerrar;
    }
}