﻿namespace AT12_banque
{
    partial class ajoutCompte
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.textNumCmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.comboTypeC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(408, 190);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(203, 233);
            this.textSolde.Name = "textSolde";
            this.textSolde.Size = new System.Drawing.Size(123, 20);
            this.textSolde.TabIndex = 14;
            // 
            // textNumCmp
            // 
            this.textNumCmp.Location = new System.Drawing.Point(203, 138);
            this.textNumCmp.Name = "textNumCmp";
            this.textNumCmp.Size = new System.Drawing.Size(123, 20);
            this.textNumCmp.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TypeC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numéro Compte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(225, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajout Compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Numéro Client";
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(203, 190);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(123, 21);
            this.comboClient.TabIndex = 18;
            // 
            // comboTypeC
            // 
            this.comboTypeC.FormattingEnabled = true;
            this.comboTypeC.Items.AddRange(new object[] {
            "Chéque",
            "Education",
            "Entreprise",
            "Age d\'or"});
            this.comboTypeC.Location = new System.Drawing.Point(203, 281);
            this.comboTypeC.Name = "comboTypeC";
            this.comboTypeC.Size = new System.Drawing.Size(123, 21);
            this.comboTypeC.TabIndex = 19;
            // 
            // ajoutCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 353);
            this.Controls.Add(this.comboTypeC);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.textNumCmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ajoutCompte";
            this.Text = "ajoutCompte";
            this.Load += new System.EventHandler(this.ajoutCompte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.TextBox textNumCmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.ComboBox comboTypeC;
    }
}