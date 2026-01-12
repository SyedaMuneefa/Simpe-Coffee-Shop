namespace Muneefa_15148
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkEspresso = new System.Windows.Forms.CheckBox();
            this.chkLatte = new System.Windows.Forms.CheckBox();
            this.chkCappuccino = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(261, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MLT Coffee Shop";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkEspresso
            // 
            this.chkEspresso.AutoSize = true;
            this.chkEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspresso.Location = new System.Drawing.Point(286, 83);
            this.chkEspresso.Name = "chkEspresso";
            this.chkEspresso.Size = new System.Drawing.Size(121, 22);
            this.chkEspresso.TabIndex = 1;
            this.chkEspresso.Text = "Espresso ($3)";
            this.chkEspresso.UseVisualStyleBackColor = true;
            // 
            // chkLatte
            // 
            this.chkLatte.AutoSize = true;
            this.chkLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLatte.Location = new System.Drawing.Point(286, 121);
            this.chkLatte.Name = "chkLatte";
            this.chkLatte.Size = new System.Drawing.Size(89, 22);
            this.chkLatte.TabIndex = 2;
            this.chkLatte.Text = "Latte ($4)";
            this.chkLatte.UseVisualStyleBackColor = true;
            // 
            // chkCappuccino
            // 
            this.chkCappuccino.AutoSize = true;
            this.chkCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCappuccino.Location = new System.Drawing.Point(286, 160);
            this.chkCappuccino.Name = "chkCappuccino";
            this.chkCappuccino.Size = new System.Drawing.Size(136, 22);
            this.chkCappuccino.TabIndex = 3;
            this.chkCappuccino.Text = "Cappuccino ($5)";
            this.chkCappuccino.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(286, 199);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(139, 37);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(312, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: $0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chkCappuccino);
            this.Controls.Add(this.chkLatte);
            this.Controls.Add(this.chkEspresso);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkEspresso;
        private System.Windows.Forms.CheckBox chkLatte;
        private System.Windows.Forms.CheckBox chkCappuccino;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblTotal;
    }
}

