namespace Library5
{
    partial class AddReaders
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
            this.Firsname = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tno = new System.Windows.Forms.TextBox();
            this.fklt = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Firsname
            // 
            this.Firsname.AutoSize = true;
            this.Firsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firsname.Location = new System.Drawing.Point(23, 100);
            this.Firsname.Name = "Firsname";
            this.Firsname.Size = new System.Drawing.Size(80, 20);
            this.Firsname.TabIndex = 0;
            this.Firsname.Text = "Firstname";
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(140, 94);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(121, 26);
            this.first.TabIndex = 1;
            this.first.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lastname";
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last.Location = new System.Drawing.Point(140, 126);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(121, 26);
            this.last.TabIndex = 1;
            this.last.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // phon
            // 
            this.phon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phon.Location = new System.Drawing.Point(140, 158);
            this.phon.Name = "phon";
            this.phon.Size = new System.Drawing.Size(121, 26);
            this.phon.TabIndex = 1;
            this.phon.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fakulte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telebe Bilet №";
            // 
            // tno
            // 
            this.tno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tno.Location = new System.Drawing.Point(140, 222);
            this.tno.Name = "tno";
            this.tno.Size = new System.Drawing.Size(121, 26);
            this.tno.TabIndex = 1;
            this.tno.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // fklt
            // 
            this.fklt.FormattingEnabled = true;
            this.fklt.Location = new System.Drawing.Point(140, 190);
            this.fklt.Name = "fklt";
            this.fklt.Size = new System.Drawing.Size(121, 21);
            this.fklt.TabIndex = 2;
            this.fklt.SelectedIndexChanged += new System.EventHandler(this.Fklt_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Chartreuse;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add.Location = new System.Drawing.Point(315, 208);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 40);
            this.Add.TabIndex = 3;
            this.Add.Text = "Elave Et";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.fklt);
            this.Controls.Add(this.tno);
            this.Controls.Add(this.phon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Firsname);
            this.Name = "AddReaders";
            this.Text = "AddReaders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Btnreader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Firsname;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tno;
        private System.Windows.Forms.ComboBox fklt;
        private System.Windows.Forms.Button Add;
    }
}