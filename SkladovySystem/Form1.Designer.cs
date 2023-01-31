namespace SkladovySystem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.workerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doneProductsList = new System.Windows.Forms.ListBox();
            this.remainingProductsList = new System.Windows.Forms.ListBox();
            this.startedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(691, 423);
            this.textBox1.MaxLength = 0;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pracovník:";
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(818, 9);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(41, 13);
            this.workerLabel.TabIndex = 2;
            this.workerLabel.Text = "NIKDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Objednávka (ID):";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(106, 9);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(44, 13);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "ŽÁDNÁ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produkt (ID):";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(445, 9);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 6;
            this.productLabel.Text = "ŽÁDNÝ";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(445, 25);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(44, 13);
            this.productNameLabel.TabIndex = 8;
            this.productNameLabel.Text = "ŽÁDNÝ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Produkt:";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(445, 40);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(44, 13);
            this.productQuantityLabel.TabIndex = 10;
            this.productQuantityLabel.Text = "ŽÁDNÝ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Skladem:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(106, 25);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(44, 13);
            this.customerLabel.TabIndex = 12;
            this.customerLabel.Text = "ŽÁDNÝ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zákazník:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(106, 40);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(44, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "ŽÁDNÁ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hotové produkty:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zbývající produkty:";
            // 
            // doneProductsList
            // 
            this.doneProductsList.FormattingEnabled = true;
            this.doneProductsList.Location = new System.Drawing.Point(15, 130);
            this.doneProductsList.Name = "doneProductsList";
            this.doneProductsList.Size = new System.Drawing.Size(160, 316);
            this.doneProductsList.TabIndex = 17;
            // 
            // remainingProductsList
            // 
            this.remainingProductsList.FormattingEnabled = true;
            this.remainingProductsList.Location = new System.Drawing.Point(242, 130);
            this.remainingProductsList.Name = "remainingProductsList";
            this.remainingProductsList.Size = new System.Drawing.Size(160, 316);
            this.remainingProductsList.TabIndex = 18;
            // 
            // startedLabel
            // 
            this.startedLabel.AutoSize = true;
            this.startedLabel.Location = new System.Drawing.Point(818, 25);
            this.startedLabel.Name = "startedLabel";
            this.startedLabel.Size = new System.Drawing.Size(44, 13);
            this.startedLabel.TabIndex = 20;
            this.startedLabel.Text = "ŽÁDNÝ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(752, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Začátek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 455);
            this.Controls.Add(this.startedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.remainingProductsList);
            this.Controls.Add(this.doneProductsList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox doneProductsList;
        private System.Windows.Forms.ListBox remainingProductsList;
        private System.Windows.Forms.Label startedLabel;
        private System.Windows.Forms.Label label11;
    }
}

