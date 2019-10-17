namespace WanderingButton
{
    partial class WanderingButtonForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wanderingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wanderingButton
            // 
            this.wanderingButton.Location = new System.Drawing.Point(12, 12);
            this.wanderingButton.Name = "wanderingButton";
            this.wanderingButton.Size = new System.Drawing.Size(75, 23);
            this.wanderingButton.TabIndex = 0;
            this.wanderingButton.Text = "Wędruj";
            this.wanderingButton.UseVisualStyleBackColor = true;
            // 
            // WanderingButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wanderingButton);
            this.Name = "WanderingButtonForm";
            this.Text = "WanderingButtonForm";
            this.Load += new System.EventHandler(this.WanderingButtonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wanderingButton;
    }
}

