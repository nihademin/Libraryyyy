namespace Library5
{
    partial class ShowReaders
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
            this.dtgReaders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReaders
            // 
            this.dtgReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReaders.Location = new System.Drawing.Point(1, 0);
            this.dtgReaders.Name = "dtgReaders";
            this.dtgReaders.Size = new System.Drawing.Size(799, 452);
            this.dtgReaders.TabIndex = 0;
            this.dtgReaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgReaders_CellContentClick);
            // 
            // ShowReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 815);
            this.Controls.Add(this.dtgReaders);
            this.Name = "ShowReaders";
            this.Text = "ShowReaders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowReaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgReaders;
    }
}