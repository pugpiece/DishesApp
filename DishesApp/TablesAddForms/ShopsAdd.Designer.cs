namespace DishesApp.TablesAddForms
{
    partial class ShopsAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.RATING_Box = new System.Windows.Forms.TextBox();
            this.CUSTOMER_PASSWORD = new System.Windows.Forms.Label();
            this.CUSTOMER_LOGIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SHOP_DESCRIPTION_Box = new System.Windows.Forms.TextBox();
            this.SHOP_NAME_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "RATING";
            // 
            // RATING_Box
            // 
            this.RATING_Box.Location = new System.Drawing.Point(159, 95);
            this.RATING_Box.Name = "RATING_Box";
            this.RATING_Box.Size = new System.Drawing.Size(100, 22);
            this.RATING_Box.TabIndex = 84;
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(6, 70);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(147, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 83;
            this.CUSTOMER_PASSWORD.Text = "SHOP_DESCRIPTION";
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(59, 42);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(94, 17);
            this.CUSTOMER_LOGIN.TabIndex = 82;
            this.CUSTOMER_LOGIN.Text = "SHOP_NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Reviews";
            // 
            // SHOP_DESCRIPTION_Box
            // 
            this.SHOP_DESCRIPTION_Box.Location = new System.Drawing.Point(159, 67);
            this.SHOP_DESCRIPTION_Box.Name = "SHOP_DESCRIPTION_Box";
            this.SHOP_DESCRIPTION_Box.Size = new System.Drawing.Size(100, 22);
            this.SHOP_DESCRIPTION_Box.TabIndex = 80;
            // 
            // SHOP_NAME_Box
            // 
            this.SHOP_NAME_Box.Location = new System.Drawing.Point(159, 39);
            this.SHOP_NAME_Box.Name = "SHOP_NAME_Box";
            this.SHOP_NAME_Box.Size = new System.Drawing.Size(100, 22);
            this.SHOP_NAME_Box.TabIndex = 79;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(107, 126);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 78;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShopsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RATING_Box);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHOP_DESCRIPTION_Box);
            this.Controls.Add(this.SHOP_NAME_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "ShopsAdd";
            this.Text = "ShopsAdd";
            this.Load += new System.EventHandler(this.ShopsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RATING_Box;
        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SHOP_DESCRIPTION_Box;
        private System.Windows.Forms.TextBox SHOP_NAME_Box;
        private System.Windows.Forms.Button AddButton;
    }
}