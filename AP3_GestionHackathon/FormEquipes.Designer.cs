namespace AP3_GestionHackathon
{
    partial class FormEquipes
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
            this.labelEquipes = new System.Windows.Forms.Label();
            this.dgvEquipes = new System.Windows.Forms.DataGridView();
            this.bsEquipes = new System.Windows.Forms.BindingSource(this.components);
            this.cbHackathon = new System.Windows.Forms.ComboBox();
            this.bsHackathons = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHackathons)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEquipes
            // 
            this.labelEquipes.AutoSize = true;
            this.labelEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipes.Location = new System.Drawing.Point(49, 23);
            this.labelEquipes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEquipes.Name = "labelEquipes";
            this.labelEquipes.Size = new System.Drawing.Size(222, 29);
            this.labelEquipes.TabIndex = 3;
            this.labelEquipes.Text = "Liste des Equipes";
            // 
            // dgvEquipes
            // 
            this.dgvEquipes.AllowUserToAddRows = false;
            this.dgvEquipes.AllowUserToDeleteRows = false;
            this.dgvEquipes.AllowUserToOrderColumns = true;
            this.dgvEquipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipes.Location = new System.Drawing.Point(56, 79);
            this.dgvEquipes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEquipes.MultiSelect = false;
            this.dgvEquipes.Name = "dgvEquipes";
            this.dgvEquipes.RowHeadersWidth = 51;
            this.dgvEquipes.Size = new System.Drawing.Size(941, 318);
            this.dgvEquipes.TabIndex = 4;
            // 
            // cbHackathon
            // 
            this.cbHackathon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHackathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHackathon.FormattingEnabled = true;
            this.cbHackathon.Location = new System.Drawing.Point(392, 21);
            this.cbHackathon.Margin = new System.Windows.Forms.Padding(4);
            this.cbHackathon.Name = "cbHackathon";
            this.cbHackathon.Size = new System.Drawing.Size(605, 28);
            this.cbHackathon.TabIndex = 29;
            // 
            // bsHackathons
            // 
            this.bsHackathons.CurrentChanged += new System.EventHandler(this.bsHackathons_CurrentChanged);
            // 
            // FormEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1045, 473);
            this.Controls.Add(this.cbHackathon);
            this.Controls.Add(this.dgvEquipes);
            this.Controls.Add(this.labelEquipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEquipes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEquipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHackathons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipes;
        private System.Windows.Forms.DataGridView dgvEquipes;
        private System.Windows.Forms.BindingSource bsEquipes;
        private System.Windows.Forms.ComboBox cbHackathon;
        private System.Windows.Forms.BindingSource bsHackathons;
    }
}