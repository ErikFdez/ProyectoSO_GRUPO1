﻿namespace Cliente
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.ConsultarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(262, 71);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(277, 38);
            this.username.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Lime;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(22, 246);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(219, 55);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(541, 358);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(222, 63);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(262, 137);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(277, 38);
            this.password.TabIndex = 5;
            // 
            // ConsultarBD
            // 
            this.ConsultarBD.BackColor = System.Drawing.Color.Cyan;
            this.ConsultarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBD.Location = new System.Drawing.Point(541, 246);
            this.ConsultarBD.Name = "ConsultarBD";
            this.ConsultarBD.Size = new System.Drawing.Size(222, 64);
            this.ConsultarBD.TabIndex = 6;
            this.ConsultarBD.Text = "CONSULTAR";
            this.ConsultarBD.UseVisualStyleBackColor = false;
            this.ConsultarBD.Click += new System.EventHandler(this.ConsultarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.ConsultarBD);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button ConsultarBD;
    }
}

