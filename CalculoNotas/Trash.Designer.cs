﻿namespace CalculoNotas
{
    partial class Trash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trash));
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAlumnosBorrados = new System.Windows.Forms.DataGridView();
            this.menuiconos = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosBorrados)).BeginInit();
            this.menuiconos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.label9.Location = new System.Drawing.Point(43, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estudiantes borrados";
            // 
            // dgvAlumnosBorrados
            // 
            this.dgvAlumnosBorrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnosBorrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlumnosBorrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosBorrados.Location = new System.Drawing.Point(48, 195);
            this.dgvAlumnosBorrados.Name = "dgvAlumnosBorrados";
            this.dgvAlumnosBorrados.RowHeadersVisible = false;
            this.dgvAlumnosBorrados.Size = new System.Drawing.Size(712, 197);
            this.dgvAlumnosBorrados.TabIndex = 19;
            // 
            // menuiconos
            // 
            this.menuiconos.BackColor = System.Drawing.Color.White;
            this.menuiconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.menuiconos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuiconos.Location = new System.Drawing.Point(0, 0);
            this.menuiconos.Name = "menuiconos";
            this.menuiconos.Padding = new System.Windows.Forms.Padding(0, 10, 1, 10);
            this.menuiconos.Size = new System.Drawing.Size(800, 106);
            this.menuiconos.Stretch = true;
            this.menuiconos.TabIndex = 21;
            this.menuiconos.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 84);
            this.toolStripButton1.Text = "<";
            this.toolStripButton1.ToolTipText = "Recuperar alumno";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(658, 142);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(99, 20);
            this.txtCode.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código";
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuiconos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvAlumnosBorrados);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Name = "Trash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.Trash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosBorrados)).EndInit();
            this.menuiconos.ResumeLayout(false);
            this.menuiconos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAlumnosBorrados;
        private System.Windows.Forms.ToolStrip menuiconos;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
    }
}