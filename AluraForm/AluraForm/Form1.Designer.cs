namespace AluraForm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.titularBox = new System.Windows.Forms.TextBox();
            this.saldoBox = new System.Windows.Forms.TextBox();
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titularBox
            // 
            this.titularBox.Location = new System.Drawing.Point(27, 27);
            this.titularBox.Name = "titularBox";
            this.titularBox.Size = new System.Drawing.Size(100, 20);
            this.titularBox.TabIndex = 0;
            this.titularBox.TextChanged += new System.EventHandler(this.titularText_TextChanged);
            // 
            // saldoBox
            // 
            this.saldoBox.Location = new System.Drawing.Point(27, 53);
            this.saldoBox.Name = "saldoBox";
            this.saldoBox.Size = new System.Drawing.Size(100, 20);
            this.saldoBox.TabIndex = 1;
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(27, 79);
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(100, 20);
            this.numeroBox.TabIndex = 2;
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(73, 176);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(100, 20);
            this.valorBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.valorBox);
            this.Controls.Add(this.numeroBox);
            this.Controls.Add(this.saldoBox);
            this.Controls.Add(this.titularBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularBox;
        private System.Windows.Forms.TextBox saldoBox;
        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

