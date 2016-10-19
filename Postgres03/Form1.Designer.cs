namespace Postgres03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbISA = new System.Windows.Forms.ListBox();
            this.lbCust = new System.Windows.Forms.ListBox();
            this.btnAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Accounts";
            // 
            // lbISA
            // 
            this.lbISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISA.FormattingEnabled = true;
            this.lbISA.ItemHeight = 25;
            this.lbISA.Location = new System.Drawing.Point(349, 211);
            this.lbISA.Margin = new System.Windows.Forms.Padding(4);
            this.lbISA.Name = "lbISA";
            this.lbISA.Size = new System.Drawing.Size(362, 104);
            this.lbISA.TabIndex = 11;
            // 
            // lbCust
            // 
            this.lbCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCust.FormattingEnabled = true;
            this.lbCust.ItemHeight = 25;
            this.lbCust.Location = new System.Drawing.Point(32, 57);
            this.lbCust.Margin = new System.Windows.Forms.Padding(4);
            this.lbCust.Name = "lbCust";
            this.lbCust.Size = new System.Drawing.Size(282, 104);
            this.lbCust.TabIndex = 12;
            // 
            // btnAcc
            // 
            this.btnAcc.Enabled = false;
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(214, 169);
            this.btnAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(100, 52);
            this.btnAcc.TabIndex = 13;
            this.btnAcc.Text = "Show Accounts";
            this.btnAcc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 351);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.lbCust);
            this.Controls.Add(this.lbISA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbISA;
        private System.Windows.Forms.ListBox lbCust;
        private System.Windows.Forms.Button btnAcc;
    }
}

