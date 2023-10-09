namespace Proyecto_Final___Wingo
{
    partial class ProgressBar
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
            this.progressBar_subiendo = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_subiendo
            // 
            this.progressBar_subiendo.Location = new System.Drawing.Point(200, 24);
            this.progressBar_subiendo.Name = "progressBar_subiendo";
            this.progressBar_subiendo.Size = new System.Drawing.Size(400, 100);
            this.progressBar_subiendo.TabIndex = 0;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_progress.Location = new System.Drawing.Point(270, 144);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(171, 16);
            this.lbl_progress.TabIndex = 1;
            this.lbl_progress.Text = "Cargando configuraciones: ";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.progressBar_subiendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar";
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar progressBar_subiendo;
        public System.Windows.Forms.Label lbl_progress;
    }
}