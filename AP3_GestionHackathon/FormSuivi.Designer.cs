
namespace AP3_GestionHackathon
{
    partial class FormSuivi
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgvSuivi = new System.Windows.Forms.DataGridView();
            this.BtnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuivi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitre.Location = new System.Drawing.Point(50, 25);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(447, 29);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Suivi des manipulations des données";
            // 
            // dgvSuivi
            // 
            this.dgvSuivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuivi.Location = new System.Drawing.Point(55, 57);
            this.dgvSuivi.Name = "dgvSuivi";
            this.dgvSuivi.RowHeadersWidth = 51;
            this.dgvSuivi.RowTemplate.Height = 24;
            this.dgvSuivi.Size = new System.Drawing.Size(941, 318);
            this.dgvSuivi.TabIndex = 6;
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(869, 393);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(127, 63);
            this.BtnFermer.TabIndex = 7;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            // 
            // FormSuivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1035, 482);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dgvSuivi);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuivi";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvSuivi;
        private System.Windows.Forms.Button BtnFermer;
    }
}