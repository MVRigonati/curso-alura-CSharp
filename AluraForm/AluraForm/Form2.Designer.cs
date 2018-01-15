namespace AluraForm {
    partial class Form2 {
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
            this.contasCombo = new System.Windows.Forms.ComboBox();
            this.titularBox = new System.Windows.Forms.TextBox();
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.saldoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.tranferenciaCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.valorTransfereBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contasCombo
            // 
            this.contasCombo.FormattingEnabled = true;
            this.contasCombo.Location = new System.Drawing.Point(36, 48);
            this.contasCombo.Name = "contasCombo";
            this.contasCombo.Size = new System.Drawing.Size(152, 21);
            this.contasCombo.TabIndex = 0;
            this.contasCombo.SelectedIndexChanged += new System.EventHandler(this.contasCombo_SelectedIndexChanged);
            // 
            // titularBox
            // 
            this.titularBox.Location = new System.Drawing.Point(67, 75);
            this.titularBox.Name = "titularBox";
            this.titularBox.Size = new System.Drawing.Size(100, 20);
            this.titularBox.TabIndex = 1;
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(67, 101);
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(100, 20);
            this.numeroBox.TabIndex = 2;
            // 
            // saldoBox
            // 
            this.saldoBox.Location = new System.Drawing.Point(67, 127);
            this.saldoBox.Name = "saldoBox";
            this.saldoBox.Size = new System.Drawing.Size(100, 20);
            this.saldoBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(67, 183);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(100, 20);
            this.valorBox.TabIndex = 7;
            // 
            // tranferenciaCombo
            // 
            this.tranferenciaCombo.FormattingEnabled = true;
            this.tranferenciaCombo.Location = new System.Drawing.Point(204, 48);
            this.tranferenciaCombo.Name = "tranferenciaCombo";
            this.tranferenciaCombo.Size = new System.Drawing.Size(121, 21);
            this.tranferenciaCombo.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Transfere";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // valorTransfereBox
            // 
            this.valorTransfereBox.Location = new System.Drawing.Point(204, 156);
            this.valorTransfereBox.Name = "valorTransfereBox";
            this.valorTransfereBox.Size = new System.Drawing.Size(100, 20);
            this.valorTransfereBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 302);
            this.Controls.Add(this.valorTransfereBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tranferenciaCombo);
            this.Controls.Add(this.valorBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saldoBox);
            this.Controls.Add(this.numeroBox);
            this.Controls.Add(this.titularBox);
            this.Controls.Add(this.contasCombo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contasCombo;
        private System.Windows.Forms.TextBox titularBox;
        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.TextBox saldoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.ComboBox tranferenciaCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox valorTransfereBox;
    }
}