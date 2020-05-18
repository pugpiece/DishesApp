namespace DishesApp.TablesAddForms
{
    partial class Prod_To_ShopAdd
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
            this.CUSTOMER_PASSWORD = new System.Windows.Forms.Label();
            this.CUSTOMER_LOGIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_SHOP_Box = new System.Windows.Forms.TextBox();
            this.ID_PRODUCT_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(34, 70);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(68, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 47;
            this.CUSTOMER_PASSWORD.Text = "ID_SHOP";
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(5, 42);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(97, 17);
            this.CUSTOMER_LOGIN.TabIndex = 46;
            this.CUSTOMER_LOGIN.Text = "ID_PRODUCT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Prod_To_Shop";
            // 
            // ID_SHOP_Box
            // 
            this.ID_SHOP_Box.Location = new System.Drawing.Point(108, 67);
            this.ID_SHOP_Box.Name = "ID_SHOP_Box";
            this.ID_SHOP_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_SHOP_Box.TabIndex = 44;
            // 
            // ID_PRODUCT_Box
            // 
            this.ID_PRODUCT_Box.Location = new System.Drawing.Point(108, 39);
            this.ID_PRODUCT_Box.Name = "ID_PRODUCT_Box";
            this.ID_PRODUCT_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_PRODUCT_Box.TabIndex = 43;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(75, 95);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 42;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Prod_To_ShopAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 134);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_SHOP_Box);
            this.Controls.Add(this.ID_PRODUCT_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "Prod_To_ShopAdd";
            this.Text = "Prod_To_ShopAdd";
            this.Load += new System.EventHandler(this.Prod_To_ShopAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_SHOP_Box;
        private System.Windows.Forms.TextBox ID_PRODUCT_Box;
        private System.Windows.Forms.Button AddButton;
    }
}