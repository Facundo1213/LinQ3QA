﻿namespace EjemplosWin
{
    partial class frmQueries2
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
            this.txtMayores = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.txtConsonantes = new System.Windows.Forms.TextBox();
            this.rbtEnteros = new System.Windows.Forms.RadioButton();
            this.rbtStrings = new System.Windows.Forms.RadioButton();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnProcesar1 = new System.Windows.Forms.Button();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.btnProcesar3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMayores
            // 
            this.txtMayores.Location = new System.Drawing.Point(124, 13);
            this.txtMayores.Name = "txtMayores";
            this.txtMayores.Size = new System.Drawing.Size(35, 20);
            this.txtMayores.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(124, 41);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(189, 20);
            this.txtResultado.TabIndex = 0;
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(91, 222);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(222, 20);
            this.txtFrase.TabIndex = 0;
            // 
            // txtConsonantes
            // 
            this.txtConsonantes.Location = new System.Drawing.Point(91, 254);
            this.txtConsonantes.Name = "txtConsonantes";
            this.txtConsonantes.Size = new System.Drawing.Size(130, 20);
            this.txtConsonantes.TabIndex = 0;
            // 
            // rbtEnteros
            // 
            this.rbtEnteros.AutoSize = true;
            this.rbtEnteros.Location = new System.Drawing.Point(16, 84);
            this.rbtEnteros.Name = "rbtEnteros";
            this.rbtEnteros.Size = new System.Drawing.Size(61, 17);
            this.rbtEnteros.TabIndex = 1;
            this.rbtEnteros.TabStop = true;
            this.rbtEnteros.Text = "Enteros";
            this.rbtEnteros.UseVisualStyleBackColor = true;
            // 
            // rbtStrings
            // 
            this.rbtStrings.AutoSize = true;
            this.rbtStrings.Location = new System.Drawing.Point(124, 84);
            this.rbtStrings.Name = "rbtStrings";
            this.rbtStrings.Size = new System.Drawing.Size(57, 17);
            this.rbtStrings.TabIndex = 2;
            this.rbtStrings.TabStop = true;
            this.rbtStrings.Text = "Strings";
            this.rbtStrings.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(12, 110);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(169, 82);
            this.lstResultados.TabIndex = 3;
            // 
            // btnProcesar1
            // 
            this.btnProcesar1.Location = new System.Drawing.Point(238, 8);
            this.btnProcesar1.Name = "btnProcesar1";
            this.btnProcesar1.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar1.TabIndex = 4;
            this.btnProcesar1.Text = "Procesar";
            this.btnProcesar1.UseVisualStyleBackColor = true;
            this.btnProcesar1.Click += new System.EventHandler(this.btnProcesar1_Click);
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Location = new System.Drawing.Point(238, 81);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar2.TabIndex = 5;
            this.btnProcesar2.Text = "Procesar";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            this.btnProcesar2.Click += new System.EventHandler(this.btnProcesar2_Click);
            // 
            // btnProcesar3
            // 
            this.btnProcesar3.Location = new System.Drawing.Point(238, 252);
            this.btnProcesar3.Name = "btnProcesar3";
            this.btnProcesar3.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar3.TabIndex = 6;
            this.btnProcesar3.Text = "Procesar";
            this.btnProcesar3.UseVisualStyleBackColor = true;
            this.btnProcesar3.Click += new System.EventHandler(this.btnProcesar3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Números Mayores A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Frase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Consonantes:";
            // 
            // frmQueries2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcesar3);
            this.Controls.Add(this.btnProcesar2);
            this.Controls.Add(this.btnProcesar1);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.rbtStrings);
            this.Controls.Add(this.rbtEnteros);
            this.Controls.Add(this.txtConsonantes);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtMayores);
            this.Name = "frmQueries2";
            this.Text = "frmQueries2";
            this.Load += new System.EventHandler(this.frmQueries2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMayores;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.TextBox txtConsonantes;
        private System.Windows.Forms.RadioButton rbtEnteros;
        private System.Windows.Forms.RadioButton rbtStrings;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnProcesar1;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.Button btnProcesar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}