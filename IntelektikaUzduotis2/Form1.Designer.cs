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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputX1 = new System.Windows.Forms.TextBox();
            this.inputX2 = new System.Windows.Forms.TextBox();
            this.inputK = new System.Windows.Forms.TextBox();
            this.rezultatas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(202, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // inputX1
            // 
            this.inputX1.Location = new System.Drawing.Point(13, 64);
            this.inputX1.Name = "inputX1";
            this.inputX1.Size = new System.Drawing.Size(100, 20);
            this.inputX1.TabIndex = 2;
            // 
            // inputX2
            // 
            this.inputX2.Location = new System.Drawing.Point(13, 91);
            this.inputX2.Name = "inputX2";
            this.inputX2.Size = new System.Drawing.Size(100, 20);
            this.inputX2.TabIndex = 3;
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(13, 127);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(100, 20);
            this.inputK.TabIndex = 4;
            // 
            // rezultatas
            // 
            this.rezultatas.AutoSize = true;
            this.rezultatas.Location = new System.Drawing.Point(32, 561);
            this.rezultatas.Name = "rezultatas";
            this.rezultatas.Size = new System.Drawing.Size(0, 13);
            this.rezultatas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 620);
            this.Controls.Add(this.rezultatas);
            this.Controls.Add(this.inputK);
            this.Controls.Add(this.inputX2);
            this.Controls.Add(this.inputX1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputX1;
        private System.Windows.Forms.TextBox inputX2;
        private System.Windows.Forms.TextBox inputK;
        private System.Windows.Forms.Label rezultatas;
    }
}

