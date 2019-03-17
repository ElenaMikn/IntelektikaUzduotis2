namespace IntelektikaUzduotis2
{
    partial class Form1
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
            this.buttonSkaiciuoti = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputX1 = new System.Windows.Forms.TextBox();
            this.inputX2 = new System.Windows.Forms.TextBox();
            this.inputK = new System.Windows.Forms.TextBox();
            this.rezultatas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUzkrautiDuomenis = new System.Windows.Forms.Button();
            this.buttonIssaugotiDuomenis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSkaiciuoti
            // 
            this.buttonSkaiciuoti.Location = new System.Drawing.Point(12, 327);
            this.buttonSkaiciuoti.Name = "buttonSkaiciuoti";
            this.buttonSkaiciuoti.Size = new System.Drawing.Size(75, 23);
            this.buttonSkaiciuoti.TabIndex = 0;
            this.buttonSkaiciuoti.Text = "Skaiciuoti";
            this.buttonSkaiciuoti.UseVisualStyleBackColor = true;
            this.buttonSkaiciuoti.Click += new System.EventHandler(this.buttonSkaiciuoti_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(747, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 505);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // inputX1
            // 
            this.inputX1.Location = new System.Drawing.Point(12, 204);
            this.inputX1.Name = "inputX1";
            this.inputX1.Size = new System.Drawing.Size(100, 20);
            this.inputX1.TabIndex = 2;
            this.inputX1.Text = "1";
            // 
            // inputX2
            // 
            this.inputX2.Location = new System.Drawing.Point(11, 243);
            this.inputX2.Name = "inputX2";
            this.inputX2.Size = new System.Drawing.Size(100, 20);
            this.inputX2.TabIndex = 3;
            this.inputX2.Text = "1";
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(12, 282);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(100, 20);
            this.inputK.TabIndex = 4;
            this.inputK.Text = "1";
            // 
            // rezultatas
            // 
            this.rezultatas.AutoSize = true;
            this.rezultatas.Location = new System.Drawing.Point(32, 561);
            this.rezultatas.Name = "rezultatas";
            this.rezultatas.Size = new System.Drawing.Size(0, 13);
            this.rezultatas.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pavadinimas,
            this.x1,
            this.x2,
            this.Grupe});
            this.dataGridView1.Location = new System.Drawing.Point(187, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 500);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowLeave);
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.HeaderText = "Pavadinimas";
            this.Pavadinimas.Name = "Pavadinimas";
            // 
            // x1
            // 
            this.x1.HeaderText = "x1";
            this.x1.Name = "x1";
            // 
            // x2
            // 
            this.x2.HeaderText = "x2";
            this.x2.Name = "x2";
            // 
            // Grupe
            // 
            this.Grupe.HeaderText = "Grupe";
            this.Grupe.Name = "Grupe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "K";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mokymo imtis 1",
            "Mokymo imtis 2",
            "Mokymo imtis 3",
            "Mokymo imtis 4"});
            this.comboBox1.Location = new System.Drawing.Point(11, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // buttonUzkrautiDuomenis
            // 
            this.buttonUzkrautiDuomenis.Location = new System.Drawing.Point(12, 66);
            this.buttonUzkrautiDuomenis.Name = "buttonUzkrautiDuomenis";
            this.buttonUzkrautiDuomenis.Size = new System.Drawing.Size(120, 23);
            this.buttonUzkrautiDuomenis.TabIndex = 11;
            this.buttonUzkrautiDuomenis.Text = "Uzkrauti duomenis";
            this.buttonUzkrautiDuomenis.UseVisualStyleBackColor = true;
            this.buttonUzkrautiDuomenis.Click += new System.EventHandler(this.buttonUzkrautiDuomenis_Click);
            // 
            // buttonIssaugotiDuomenis
            // 
            this.buttonIssaugotiDuomenis.Location = new System.Drawing.Point(11, 95);
            this.buttonIssaugotiDuomenis.Name = "buttonIssaugotiDuomenis";
            this.buttonIssaugotiDuomenis.Size = new System.Drawing.Size(121, 23);
            this.buttonIssaugotiDuomenis.TabIndex = 12;
            this.buttonIssaugotiDuomenis.Text = "Išsaugoti duomenis";
            this.buttonIssaugotiDuomenis.UseVisualStyleBackColor = true;
            this.buttonIssaugotiDuomenis.Click += new System.EventHandler(this.buttonIssaugotiDuomenis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 716);
            this.Controls.Add(this.buttonIssaugotiDuomenis);
            this.Controls.Add(this.buttonUzkrautiDuomenis);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rezultatas);
            this.Controls.Add(this.inputK);
            this.Controls.Add(this.inputX2);
            this.Controls.Add(this.inputX1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSkaiciuoti);
            this.Name = "Form1";
            this.Text = "Elena Miknevičienė - Intelektika antra užduotis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSkaiciuoti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputX1;
        private System.Windows.Forms.TextBox inputX2;
        private System.Windows.Forms.TextBox inputK;
        private System.Windows.Forms.Label rezultatas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pavadinimas;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUzkrautiDuomenis;
        private System.Windows.Forms.Button buttonIssaugotiDuomenis;
    }
}

