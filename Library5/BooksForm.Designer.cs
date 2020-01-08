namespace Library5
{
    partial class BooksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgbooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbaut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpd = new System.Windows.Forms.DateTimePicker();
            this.btnaddb = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgbooks
            // 
            this.dtgbooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgbooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgbooks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgbooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgbooks.Location = new System.Drawing.Point(661, 0);
            this.dtgbooks.Name = "dtgbooks";
            this.dtgbooks.Size = new System.Drawing.Size(723, 796);
            this.dtgbooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // txtbn
            // 
            this.txtbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbn.Location = new System.Drawing.Point(240, 18);
            this.txtbn.Name = "txtbn";
            this.txtbn.Size = new System.Drawing.Size(196, 26);
            this.txtbn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Counts";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcn.Location = new System.Drawing.Point(240, 76);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(196, 26);
            this.txtcn.TabIndex = 2;
            this.txtcn.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.txtcn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Authors";
            this.label3.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cmbaut
            // 
            this.cmbaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaut.FormattingEnabled = true;
            this.cmbaut.Location = new System.Drawing.Point(240, 138);
            this.cmbaut.Name = "cmbaut";
            this.cmbaut.Size = new System.Drawing.Size(196, 28);
            this.cmbaut.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publish date";
            this.label4.Click += new System.EventHandler(this.Label2_Click);
            // 
            // dtpd
            // 
            this.dtpd.Location = new System.Drawing.Point(240, 225);
            this.dtpd.Name = "dtpd";
            this.dtpd.Size = new System.Drawing.Size(196, 20);
            this.dtpd.TabIndex = 4;
            // 
            // btnaddb
            // 
            this.btnaddb.BackColor = System.Drawing.Color.Chartreuse;
            this.btnaddb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddb.Location = new System.Drawing.Point(240, 266);
            this.btnaddb.Name = "btnaddb";
            this.btnaddb.Size = new System.Drawing.Size(136, 60);
            this.btnaddb.TabIndex = 5;
            this.btnaddb.Text = "Add Book";
            this.btnaddb.UseVisualStyleBackColor = false;
            this.btnaddb.Click += new System.EventHandler(this.Btnaddb_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(140, 344);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(296, 79);
            this.lblerror.TabIndex = 1;
            this.lblerror.Text = "Publish date";
            this.lblerror.Visible = false;
            this.lblerror.Click += new System.EventHandler(this.Label2_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 796);
            this.Controls.Add(this.btnaddb);
            this.Controls.Add(this.dtpd);
            this.Controls.Add(this.cmbaut);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txtbn);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgbooks);
            this.Name = "BooksForm";
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgbooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgbooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbaut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpd;
        private System.Windows.Forms.Button btnaddb;
        private System.Windows.Forms.Label lblerror;
    }
}