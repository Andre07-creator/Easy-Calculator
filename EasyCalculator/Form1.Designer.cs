
namespace EasyCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSum = new System.Windows.Forms.Button();
            this.lblSimpleCalculator = new System.Windows.Forms.Label();
            this.lblvalue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.txbValue1 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txbValue2 = new System.Windows.Forms.TextBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSum.Location = new System.Drawing.Point(242, 138);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(102, 36);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSimpleCalculator
            // 
            this.lblSimpleCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpleCalculator.Location = new System.Drawing.Point(157, 21);
            this.lblSimpleCalculator.Name = "lblSimpleCalculator";
            this.lblSimpleCalculator.Size = new System.Drawing.Size(220, 35);
            this.lblSimpleCalculator.TabIndex = 1;
            this.lblSimpleCalculator.Text = "Simple Calculator";
            this.lblSimpleCalculator.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lblvalue1
            // 
            this.lblvalue1.AutoSize = true;
            this.lblvalue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalue1.Location = new System.Drawing.Point(20, 75);
            this.lblvalue1.Name = "lblvalue1";
            this.lblvalue1.Size = new System.Drawing.Size(70, 20);
            this.lblvalue1.TabIndex = 2;
            this.lblvalue1.Text = "Value 1";
            this.lblvalue1.Click += new System.EventHandler(this.lblvalue1_Click);
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblValue2.Location = new System.Drawing.Point(20, 114);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(70, 20);
            this.lblValue2.TabIndex = 3;
            this.lblValue2.Text = "Value 2";
            // 
            // txbValue1
            // 
            this.txbValue1.Location = new System.Drawing.Point(96, 75);
            this.txbValue1.Name = "txbValue1";
            this.txbValue1.Size = new System.Drawing.Size(100, 20);
            this.txbValue1.TabIndex = 4;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbltotal.Location = new System.Drawing.Point(20, 154);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(49, 20);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // txbValue2
            // 
            this.txbValue2.Location = new System.Drawing.Point(96, 114);
            this.txbValue2.Name = "txbValue2";
            this.txbValue2.Size = new System.Drawing.Size(100, 20);
            this.txbValue2.TabIndex = 6;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(96, 154);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 7;
            this.txbTotal.Visible = false;
            this.txbTotal.TextChanged += new System.EventHandler(this.txbTotal_TextChanged);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSub.Location = new System.Drawing.Point(242, 75);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(102, 36);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMult.Location = new System.Drawing.Point(379, 138);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(102, 36);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDivi.Location = new System.Drawing.Point(379, 75);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(102, 36);
            this.btnDivi.TabIndex = 10;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(301, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(409, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 36);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 291);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbValue2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txbValue1);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblvalue1);
            this.Controls.Add(this.lblSimpleCalculator);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblSimpleCalculator;
        private System.Windows.Forms.Label lblvalue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.TextBox txbValue1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txbValue2;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

