﻿
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
            this.components = new System.ComponentModel.Container();
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
            this.panel_derecha = new System.Windows.Forms.Panel();
            this.lbl_len_der = new System.Windows.Forms.Label();
            this.trackBar_der = new System.Windows.Forms.TrackBar();
            this.lbl_med_der = new System.Windows.Forms.Label();
            this.lbl_selec_velocidad_der = new System.Windows.Forms.Label();
            this.lbl_rap_der = new System.Windows.Forms.Label();
            this.panel_izquierda = new System.Windows.Forms.Panel();
            this.lbl_len_izq = new System.Windows.Forms.Label();
            this.trackBar_izq = new System.Windows.Forms.TrackBar();
            this.lbl_med_izq = new System.Windows.Forms.Label();
            this.lbl_selec_velocidad_izq = new System.Windows.Forms.Label();
            this.lbl_rap_izq = new System.Windows.Forms.Label();
            this.comb_angulo = new System.Windows.Forms.ComboBox();
            this.Comb_tipos_personalizados = new System.Windows.Forms.ComboBox();
            this.panel_arriba = new System.Windows.Forms.Panel();
            this.lbl_len_arr = new System.Windows.Forms.Label();
            this.trackBar_arr = new System.Windows.Forms.TrackBar();
            this.lbl_med_arr = new System.Windows.Forms.Label();
            this.lbl_selec_velocidad_arr = new System.Windows.Forms.Label();
            this.lbl_rap_arr = new System.Windows.Forms.Label();
            this.bt_cambiar_nombre = new System.Windows.Forms.Button();
            this.bt_enviar_configuraciones = new System.Windows.Forms.Button();
            this.serialPort_arduino = new System.IO.Ports.SerialPort(this.components);
            this.bt_manejo = new System.Windows.Forms.Button();
            this.panel_nom.SuspendLayout();
            this.panel_perfil.SuspendLayout();
            this.panel_derecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_der)).BeginInit();
            this.panel_izquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_izq)).BeginInit();
            this.panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_arr)).BeginInit();
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
            this.panel_nom.Location = new System.Drawing.Point(12, 675);
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
            this.panel_perfil.Controls.Add(this.panel_derecha);
            this.panel_perfil.Controls.Add(this.panel_izquierda);
            this.panel_perfil.Controls.Add(this.comb_angulo);
            this.panel_perfil.Controls.Add(this.Comb_tipos_personalizados);
            this.panel_perfil.Controls.Add(this.panel_arriba);
            this.panel_perfil.Controls.Add(this.bt_cambiar_nombre);
            this.panel_perfil.Location = new System.Drawing.Point(66, 0);
            this.panel_perfil.Name = "panel_perfil";
            this.panel_perfil.Size = new System.Drawing.Size(911, 666);
            this.panel_perfil.TabIndex = 3;
            // 
            // panel_derecha
            // 
            this.panel_derecha.BackColor = System.Drawing.SystemColors.Control;
            this.panel_derecha.Controls.Add(this.lbl_len_der);
            this.panel_derecha.Controls.Add(this.trackBar_der);
            this.panel_derecha.Controls.Add(this.lbl_med_der);
            this.panel_derecha.Controls.Add(this.lbl_selec_velocidad_der);
            this.panel_derecha.Controls.Add(this.lbl_rap_der);
            this.panel_derecha.Location = new System.Drawing.Point(16, 214);
            this.panel_derecha.Name = "panel_derecha";
            this.panel_derecha.Size = new System.Drawing.Size(836, 574);
            this.panel_derecha.TabIndex = 3;
            this.panel_derecha.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_derecha_Paint);
            this.panel_derecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_derecha_MouseDown);
            this.panel_derecha.MouseLeave += new System.EventHandler(this.panel_derecha_MouseLeave);
            this.panel_derecha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_derecha_MouseMove);
            this.panel_derecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_derecha_MouseUp);
            // 
            // lbl_len_der
            // 
            this.lbl_len_der.AutoSize = true;
            this.lbl_len_der.Location = new System.Drawing.Point(116, 414);
            this.lbl_len_der.Name = "lbl_len_der";
            this.lbl_len_der.Size = new System.Drawing.Size(34, 13);
            this.lbl_len_der.TabIndex = 6;
            this.lbl_len_der.Text = "Lenta";
            // 
            // trackBar_der
            // 
            this.trackBar_der.Location = new System.Drawing.Point(60, 55);
            this.trackBar_der.Maximum = 1000;
            this.trackBar_der.Minimum = 1;
            this.trackBar_der.Name = "trackBar_der";
            this.trackBar_der.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_der.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_der.Size = new System.Drawing.Size(45, 400);
            this.trackBar_der.TabIndex = 1;
            this.trackBar_der.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_der.Value = 1;
            this.trackBar_der.Visible = false;
            this.trackBar_der.Scroll += new System.EventHandler(this.trackBar_der_Scroll);
            // 
            // lbl_med_der
            // 
            this.lbl_med_der.AutoSize = true;
            this.lbl_med_der.Location = new System.Drawing.Point(121, 217);
            this.lbl_med_der.Name = "lbl_med_der";
            this.lbl_med_der.Size = new System.Drawing.Size(36, 13);
            this.lbl_med_der.TabIndex = 5;
            this.lbl_med_der.Text = "Media";
            // 
            // lbl_selec_velocidad_der
            // 
            this.lbl_selec_velocidad_der.AutoSize = true;
            this.lbl_selec_velocidad_der.Location = new System.Drawing.Point(57, 24);
            this.lbl_selec_velocidad_der.Name = "lbl_selec_velocidad_der";
            this.lbl_selec_velocidad_der.Size = new System.Drawing.Size(176, 13);
            this.lbl_selec_velocidad_der.TabIndex = 0;
            this.lbl_selec_velocidad_der.Text = "Seleccionar la velocidad del efecto:";
            // 
            // lbl_rap_der
            // 
            this.lbl_rap_der.AutoSize = true;
            this.lbl_rap_der.Location = new System.Drawing.Point(116, 55);
            this.lbl_rap_der.Name = "lbl_rap_der";
            this.lbl_rap_der.Size = new System.Drawing.Size(41, 13);
            this.lbl_rap_der.TabIndex = 4;
            this.lbl_rap_der.Text = "Rápida";
            // 
            // panel_izquierda
            // 
            this.panel_izquierda.BackColor = System.Drawing.SystemColors.Control;
            this.panel_izquierda.Controls.Add(this.lbl_len_izq);
            this.panel_izquierda.Controls.Add(this.trackBar_izq);
            this.panel_izquierda.Controls.Add(this.lbl_med_izq);
            this.panel_izquierda.Controls.Add(this.lbl_selec_velocidad_izq);
            this.panel_izquierda.Controls.Add(this.lbl_rap_izq);
            this.panel_izquierda.Location = new System.Drawing.Point(19, 138);
            this.panel_izquierda.Name = "panel_izquierda";
            this.panel_izquierda.Size = new System.Drawing.Size(836, 574);
            this.panel_izquierda.TabIndex = 2;
            this.panel_izquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_izquierda_Paint);
            this.panel_izquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_izquierda_MouseDown);
            this.panel_izquierda.MouseLeave += new System.EventHandler(this.panel_izquierda_MouseLeave);
            this.panel_izquierda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_izquierda_MouseMove);
            this.panel_izquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_izquierda_MouseUp);
            // 
            // lbl_len_izq
            // 
            this.lbl_len_izq.AutoSize = true;
            this.lbl_len_izq.Location = new System.Drawing.Point(542, 35);
            this.lbl_len_izq.Name = "lbl_len_izq";
            this.lbl_len_izq.Size = new System.Drawing.Size(34, 13);
            this.lbl_len_izq.TabIndex = 9;
            this.lbl_len_izq.Text = "Lenta";
            // 
            // trackBar_izq
            // 
            this.trackBar_izq.Location = new System.Drawing.Point(60, 55);
            this.trackBar_izq.Maximum = 1000;
            this.trackBar_izq.Minimum = 1;
            this.trackBar_izq.Name = "trackBar_izq";
            this.trackBar_izq.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_izq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_izq.Size = new System.Drawing.Size(45, 400);
            this.trackBar_izq.TabIndex = 2;
            this.trackBar_izq.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_izq.Value = 1;
            this.trackBar_izq.Visible = false;
            this.trackBar_izq.Scroll += new System.EventHandler(this.trackBar_izq_Scroll);
            // 
            // lbl_med_izq
            // 
            this.lbl_med_izq.AutoSize = true;
            this.lbl_med_izq.Location = new System.Drawing.Point(434, 35);
            this.lbl_med_izq.Name = "lbl_med_izq";
            this.lbl_med_izq.Size = new System.Drawing.Size(36, 13);
            this.lbl_med_izq.TabIndex = 8;
            this.lbl_med_izq.Text = "Media";
            // 
            // lbl_selec_velocidad_izq
            // 
            this.lbl_selec_velocidad_izq.AutoSize = true;
            this.lbl_selec_velocidad_izq.Location = new System.Drawing.Point(70, 23);
            this.lbl_selec_velocidad_izq.Name = "lbl_selec_velocidad_izq";
            this.lbl_selec_velocidad_izq.Size = new System.Drawing.Size(176, 13);
            this.lbl_selec_velocidad_izq.TabIndex = 1;
            this.lbl_selec_velocidad_izq.Text = "Seleccionar la velocidad del efecto:";
            // 
            // lbl_rap_izq
            // 
            this.lbl_rap_izq.AutoSize = true;
            this.lbl_rap_izq.Location = new System.Drawing.Point(289, 35);
            this.lbl_rap_izq.Name = "lbl_rap_izq";
            this.lbl_rap_izq.Size = new System.Drawing.Size(41, 13);
            this.lbl_rap_izq.TabIndex = 7;
            this.lbl_rap_izq.Text = "Rápida";
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
            "Independiente",
            "A",
            "B",
            "C",
            "D",
            "Apagado"});
            this.Comb_tipos_personalizados.Location = new System.Drawing.Point(86, 40);
            this.Comb_tipos_personalizados.Name = "Comb_tipos_personalizados";
            this.Comb_tipos_personalizados.Size = new System.Drawing.Size(173, 21);
            this.Comb_tipos_personalizados.TabIndex = 4;
            this.Comb_tipos_personalizados.SelectedIndexChanged += new System.EventHandler(this.Comb_tipos__personalizados_SelectedIndexChanged);
            // 
            // panel_arriba
            // 
            this.panel_arriba.BackColor = System.Drawing.SystemColors.Control;
            this.panel_arriba.Controls.Add(this.lbl_len_arr);
            this.panel_arriba.Controls.Add(this.trackBar_arr);
            this.panel_arriba.Controls.Add(this.lbl_med_arr);
            this.panel_arriba.Controls.Add(this.lbl_selec_velocidad_arr);
            this.panel_arriba.Controls.Add(this.lbl_rap_arr);
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
            // lbl_len_arr
            // 
            this.lbl_len_arr.AutoSize = true;
            this.lbl_len_arr.Location = new System.Drawing.Point(541, 35);
            this.lbl_len_arr.Name = "lbl_len_arr";
            this.lbl_len_arr.Size = new System.Drawing.Size(34, 13);
            this.lbl_len_arr.TabIndex = 9;
            this.lbl_len_arr.Text = "Lenta";
            // 
            // trackBar_arr
            // 
            this.trackBar_arr.Location = new System.Drawing.Point(60, 55);
            this.trackBar_arr.Maximum = 1000;
            this.trackBar_arr.Minimum = 1;
            this.trackBar_arr.Name = "trackBar_arr";
            this.trackBar_arr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_arr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_arr.Size = new System.Drawing.Size(45, 400);
            this.trackBar_arr.TabIndex = 3;
            this.trackBar_arr.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_arr.Value = 1;
            this.trackBar_arr.Visible = false;
            this.trackBar_arr.Scroll += new System.EventHandler(this.trackBar_arr_Scroll);
            // 
            // lbl_med_arr
            // 
            this.lbl_med_arr.AutoSize = true;
            this.lbl_med_arr.Location = new System.Drawing.Point(415, 35);
            this.lbl_med_arr.Name = "lbl_med_arr";
            this.lbl_med_arr.Size = new System.Drawing.Size(36, 13);
            this.lbl_med_arr.TabIndex = 8;
            this.lbl_med_arr.Text = "Media";
            // 
            // lbl_selec_velocidad_arr
            // 
            this.lbl_selec_velocidad_arr.AutoSize = true;
            this.lbl_selec_velocidad_arr.Location = new System.Drawing.Point(51, 12);
            this.lbl_selec_velocidad_arr.Name = "lbl_selec_velocidad_arr";
            this.lbl_selec_velocidad_arr.Size = new System.Drawing.Size(176, 13);
            this.lbl_selec_velocidad_arr.TabIndex = 2;
            this.lbl_selec_velocidad_arr.Text = "Seleccionar la velocidad del efecto:";
            // 
            // lbl_rap_arr
            // 
            this.lbl_rap_arr.AutoSize = true;
            this.lbl_rap_arr.Location = new System.Drawing.Point(299, 35);
            this.lbl_rap_arr.Name = "lbl_rap_arr";
            this.lbl_rap_arr.Size = new System.Drawing.Size(41, 13);
            this.lbl_rap_arr.TabIndex = 7;
            this.lbl_rap_arr.Text = "Rápida";
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
            // bt_enviar_configuraciones
            // 
            this.bt_enviar_configuraciones.Location = new System.Drawing.Point(1063, 639);
            this.bt_enviar_configuraciones.Name = "bt_enviar_configuraciones";
            this.bt_enviar_configuraciones.Size = new System.Drawing.Size(205, 89);
            this.bt_enviar_configuraciones.TabIndex = 8;
            this.bt_enviar_configuraciones.Text = "Enviar configuraciones";
            this.bt_enviar_configuraciones.UseVisualStyleBackColor = true;
            this.bt_enviar_configuraciones.Click += new System.EventHandler(this.bt_enviar_configuraciones_Click);
            // 
            // bt_manejo
            // 
            this.bt_manejo.Location = new System.Drawing.Point(0, 450);
            this.bt_manejo.Name = "bt_manejo";
            this.bt_manejo.Size = new System.Drawing.Size(61, 47);
            this.bt_manejo.TabIndex = 9;
            this.bt_manejo.Text = "Ir a manejo";
            this.bt_manejo.UseVisualStyleBackColor = true;
            this.bt_manejo.Click += new System.EventHandler(this.bt_manejo_Click);
            // 
            // Personalización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bt_manejo);
            this.Controls.Add(this.bt_enviar_configuraciones);
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
            this.panel_derecha.ResumeLayout(false);
            this.panel_derecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_der)).EndInit();
            this.panel_izquierda.ResumeLayout(false);
            this.panel_izquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_izq)).EndInit();
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_arr)).EndInit();
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
        private System.Windows.Forms.Panel panel_derecha;
        private System.Windows.Forms.Panel panel_izquierda;
        private System.Windows.Forms.Label lbl_selec_velocidad_der;
        private System.Windows.Forms.Label lbl_selec_velocidad_izq;
        private System.Windows.Forms.Label lbl_selec_velocidad_arr;
        private System.Windows.Forms.TrackBar trackBar_der;
        private System.Windows.Forms.TrackBar trackBar_izq;
        private System.Windows.Forms.TrackBar trackBar_arr;
        private System.Windows.Forms.Button bt_enviar_configuraciones;
        private System.IO.Ports.SerialPort serialPort_arduino;
        private System.Windows.Forms.Label lbl_len_der;
        private System.Windows.Forms.Label lbl_med_der;
        private System.Windows.Forms.Label lbl_rap_der;
        private System.Windows.Forms.Label lbl_len_izq;
        private System.Windows.Forms.Label lbl_med_izq;
        private System.Windows.Forms.Label lbl_rap_izq;
        private System.Windows.Forms.Label lbl_len_arr;
        private System.Windows.Forms.Label lbl_med_arr;
        private System.Windows.Forms.Label lbl_rap_arr;
        private System.Windows.Forms.Button bt_manejo;
    }
}