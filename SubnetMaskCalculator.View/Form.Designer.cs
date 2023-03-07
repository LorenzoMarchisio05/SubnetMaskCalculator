namespace SubnetMaskCalculator
{
    partial class Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNetworkClasses = new System.Windows.Forms.GroupBox();
            this.rdbNetworkClassA = new System.Windows.Forms.RadioButton();
            this.rdbNetworkClassB = new System.Windows.Forms.RadioButton();
            this.rdbNetworkClassC = new System.Windows.Forms.RadioButton();
            this.grpNetworkClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNetworkClasses
            // 
            this.grpNetworkClasses.Controls.Add(this.rdbNetworkClassC);
            this.grpNetworkClasses.Controls.Add(this.rdbNetworkClassB);
            this.grpNetworkClasses.Controls.Add(this.rdbNetworkClassA);
            this.grpNetworkClasses.Location = new System.Drawing.Point(12, 12);
            this.grpNetworkClasses.Name = "grpNetworkClasses";
            this.grpNetworkClasses.Size = new System.Drawing.Size(152, 46);
            this.grpNetworkClasses.TabIndex = 0;
            this.grpNetworkClasses.TabStop = false;
            this.grpNetworkClasses.Text = "Network class";
            // 
            // rdbNetworkClassA
            // 
            this.rdbNetworkClassA.AutoSize = true;
            this.rdbNetworkClassA.Location = new System.Drawing.Point(6, 19);
            this.rdbNetworkClassA.Name = "rdbNetworkClassA";
            this.rdbNetworkClassA.Size = new System.Drawing.Size(32, 17);
            this.rdbNetworkClassA.TabIndex = 0;
            this.rdbNetworkClassA.TabStop = true;
            this.rdbNetworkClassA.Text = "A";
            this.rdbNetworkClassA.UseVisualStyleBackColor = true;
            // 
            // rdbNetworkClassB
            // 
            this.rdbNetworkClassB.AutoSize = true;
            this.rdbNetworkClassB.Location = new System.Drawing.Point(55, 19);
            this.rdbNetworkClassB.Name = "rdbNetworkClassB";
            this.rdbNetworkClassB.Size = new System.Drawing.Size(32, 17);
            this.rdbNetworkClassB.TabIndex = 1;
            this.rdbNetworkClassB.TabStop = true;
            this.rdbNetworkClassB.Text = "B";
            this.rdbNetworkClassB.UseVisualStyleBackColor = true;
            // 
            // rdbNetworkClassC
            // 
            this.rdbNetworkClassC.AutoSize = true;
            this.rdbNetworkClassC.Location = new System.Drawing.Point(104, 19);
            this.rdbNetworkClassC.Name = "rdbNetworkClassC";
            this.rdbNetworkClassC.Size = new System.Drawing.Size(32, 17);
            this.rdbNetworkClassC.TabIndex = 2;
            this.rdbNetworkClassC.TabStop = true;
            this.rdbNetworkClassC.Text = "C";
            this.rdbNetworkClassC.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 579);
            this.Controls.Add(this.grpNetworkClasses);
            this.Name = "Form";
            this.Text = "SubnetMask Calculator";
            this.grpNetworkClasses.ResumeLayout(false);
            this.grpNetworkClasses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNetworkClasses;
        private System.Windows.Forms.RadioButton rdbNetworkClassA;
        private System.Windows.Forms.RadioButton rdbNetworkClassC;
        private System.Windows.Forms.RadioButton rdbNetworkClassB;
    }
}

