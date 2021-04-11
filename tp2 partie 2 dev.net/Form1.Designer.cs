namespace tp2_partie_2_dev.net
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxlieu = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonlister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lieu :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(77, 41);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(123, 20);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(77, 80);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(123, 20);
            this.textBoxPrenom.TabIndex = 4;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // textBoxlieu
            // 
            this.textBoxlieu.Location = new System.Drawing.Point(77, 115);
            this.textBoxlieu.Name = "textBoxlieu";
            this.textBoxlieu.Size = new System.Drawing.Size(123, 20);
            this.textBoxlieu.TabIndex = 5;
            this.textBoxlieu.TextChanged += new System.EventHandler(this.textBoxlieu_TextChanged);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(42, 179);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 24);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(303, 180);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 8;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(397, 179);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 9;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonlister
            // 
            this.buttonlister.Location = new System.Drawing.Point(165, 180);
            this.buttonlister.Name = "buttonlister";
            this.buttonlister.Size = new System.Drawing.Size(75, 23);
            this.buttonlister.TabIndex = 11;
            this.buttonlister.Text = "Lister";
            this.buttonlister.UseVisualStyleBackColor = true;
            this.buttonlister.Click += new System.EventHandler(this.buttonlister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.buttonlister);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxlieu);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Entrer ce que vous voulez !!! ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxlieu;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonlister;
    }
}

