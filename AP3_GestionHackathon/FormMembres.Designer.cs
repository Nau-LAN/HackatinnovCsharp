
namespace AP3_GestionHackathon
{
    partial class FormMembres
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
            this.components = new System.ComponentModel.Container();
            this.lblMembres = new System.Windows.Forms.Label();
            this.dgvMembres = new System.Windows.Forms.DataGridView();
            this.bsMembres = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembres
            // 
            this.lblMembres.AutoSize = true;
            this.lblMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembres.Location = new System.Drawing.Point(49, 23);
            this.lblMembres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembres.Name = "lblMembres";
            this.lblMembres.Size = new System.Drawing.Size(235, 29);
            this.lblMembres.TabIndex = 4;
            this.lblMembres.Text = "Liste des Membres";
            // 
            // dgvMembres
            // 
            this.dgvMembres.AllowUserToAddRows = false;
            this.dgvMembres.AllowUserToDeleteRows = false;
            this.dgvMembres.AllowUserToOrderColumns = true;
            this.dgvMembres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembres.Location = new System.Drawing.Point(47, 82);
            this.dgvMembres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMembres.MultiSelect = false;
            this.dgvMembres.Name = "dgvMembres";
            this.dgvMembres.RowHeadersWidth = 51;
            this.dgvMembres.Size = new System.Drawing.Size(941, 318);
            this.dgvMembres.TabIndex = 5;
            // 
            // FormMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1035, 482);
            this.Controls.Add(this.dgvMembres);
            this.Controls.Add(this.lblMembres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMembres";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMembres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMembres;
        private System.Windows.Forms.DataGridView dgvMembres;
        private System.Windows.Forms.BindingSource bsMembres;
    }
}