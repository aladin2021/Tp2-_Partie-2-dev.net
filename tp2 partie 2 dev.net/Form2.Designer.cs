namespace tp2_partie_2_dev.net
{
    partial class Form2
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
            this.Namelistclients = new System.Windows.Forms.ListBox();
            this.buttonRevenir = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelistclients
            // 
            this.Namelistclients.BackColor = System.Drawing.Color.Cyan;
            this.Namelistclients.FormattingEnabled = true;
            this.Namelistclients.Location = new System.Drawing.Point(12, 15);
            this.Namelistclients.Name = "Namelistclients";
            this.Namelistclients.Size = new System.Drawing.Size(309, 121);
            this.Namelistclients.TabIndex = 0;
            this.Namelistclients.SelectedIndexChanged += new System.EventHandler(this.Namelistclients_SelectedIndexChanged);
            // 
            // buttonRevenir
            // 
            this.buttonRevenir.Location = new System.Drawing.Point(31, 172);
            this.buttonRevenir.Name = "buttonRevenir";
            this.buttonRevenir.Size = new System.Drawing.Size(75, 23);
            this.buttonRevenir.TabIndex = 2;
            this.buttonRevenir.Text = "Revenir";
            this.buttonRevenir.UseVisualStyleBackColor = true;
            this.buttonRevenir.Click += new System.EventHandler(this.buttonRevenir_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(291, 172);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 3;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonRevenir);
            this.Controls.Add(this.Namelistclients);
            this.Name = "Form2";
            this.Text = "listes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Namelistclients;
        private System.Windows.Forms.Button buttonRevenir;
        private System.Windows.Forms.Button buttonFermer;
    }
}