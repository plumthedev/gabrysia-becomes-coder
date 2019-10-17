namespace Batony
{
    partial class ButonsForm
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
            this.authorButton = new System.Windows.Forms.Button();
            this.departmentButton = new System.Windows.Forms.Button();
            this.subjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorButton
            // 
            this.authorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.authorButton.Location = new System.Drawing.Point(12, 12);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(684, 23);
            this.authorButton.TabIndex = 0;
            this.authorButton.Text = "Autor";
            this.authorButton.UseVisualStyleBackColor = true;
            // 
            // departmentButton
            // 
            this.departmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentButton.Location = new System.Drawing.Point(12, 41);
            this.departmentButton.Name = "departmentButton";
            this.departmentButton.Size = new System.Drawing.Size(684, 23);
            this.departmentButton.TabIndex = 1;
            this.departmentButton.Text = "Wydział";
            this.departmentButton.UseVisualStyleBackColor = true;
            // 
            // subjectButton
            // 
            this.subjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectButton.Location = new System.Drawing.Point(12, 70);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(684, 23);
            this.subjectButton.TabIndex = 2;
            this.subjectButton.Text = "Przedmiot";
            this.subjectButton.UseVisualStyleBackColor = true;
            // 
            // ButonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 106);
            this.Controls.Add(this.subjectButton);
            this.Controls.Add(this.departmentButton);
            this.Controls.Add(this.authorButton);
            this.Name = "ButonsForm";
            this.Text = "ButonsForm";
            this.Load += new System.EventHandler(this.ButonsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Button departmentButton;
        private System.Windows.Forms.Button subjectButton;
    }
}

