﻿namespace AT12_banque
{
    partial class suppressionClient
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.textPrenomCl = new System.Windows.Forms.TextBox();
            this.textNomCl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(505, 244);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // textPrenomCl
            // 
            this.textPrenomCl.Location = new System.Drawing.Point(300, 314);
            this.textPrenomCl.Name = "textPrenomCl";
            this.textPrenomCl.Size = new System.Drawing.Size(123, 20);
            this.textPrenomCl.TabIndex = 15;
            // 
            // textNomCl
            // 
            this.textNomCl.Location = new System.Drawing.Point(300, 252);
            this.textNomCl.Name = "textNomCl";
            this.textNomCl.Size = new System.Drawing.Size(123, 20);
            this.textNomCl.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prénom Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numéro Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(314, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suppression Client";
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(300, 189);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(123, 21);
            this.comboClient.TabIndex = 19;
            this.comboClient.SelectedIndexChanged += new System.EventHandler(this.comboClient_SelectedIndexChanged);
            // 
            // suppressionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.textPrenomCl);
            this.Controls.Add(this.textNomCl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "suppressionClient";
            this.Text = "suppressionClient";
            this.Load += new System.EventHandler(this.suppressionClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox textPrenomCl;
        private System.Windows.Forms.TextBox textNomCl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboClient;
    }
}