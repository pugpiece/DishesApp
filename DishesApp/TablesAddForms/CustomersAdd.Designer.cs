namespace DishesApp.TablesAddForms
{
    partial class CustomersAdd
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
            this.CUSTOMER_PASSWORD_Box = new System.Windows.Forms.TextBox();
            this.CUSTOMER_LOGIN_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RATING_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(7, 72);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(174, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 11;
            this.CUSTOMER_PASSWORD.Text = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Click += new System.EventHandler(this.label3_Click);
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(44, 42);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(137, 17);
            this.CUSTOMER_LOGIN.TabIndex = 10;
            this.CUSTOMER_LOGIN.Text = "CUSTOMER_LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CUSTOMER_PASSWORD_Box
            // 
            this.CUSTOMER_PASSWORD_Box.Location = new System.Drawing.Point(187, 67);
            this.CUSTOMER_PASSWORD_Box.Name = "CUSTOMER_PASSWORD_Box";
            this.CUSTOMER_PASSWORD_Box.Size = new System.Drawing.Size(100, 22);
            this.CUSTOMER_PASSWORD_Box.TabIndex = 8;
            this.CUSTOMER_PASSWORD_Box.UseSystemPasswordChar = true;
            // 
            // CUSTOMER_LOGIN_Box
            // 
            this.CUSTOMER_LOGIN_Box.Location = new System.Drawing.Point(187, 39);
            this.CUSTOMER_LOGIN_Box.Name = "CUSTOMER_LOGIN_Box";
            this.CUSTOMER_LOGIN_Box.Size = new System.Drawing.Size(100, 22);
            this.CUSTOMER_LOGIN_Box.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(124, 123);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "RATING";
            // 
            // RATING_Box
            // 
            this.RATING_Box.Location = new System.Drawing.Point(187, 95);
            this.RATING_Box.Name = "RATING_Box";
            this.RATING_Box.Size = new System.Drawing.Size(100, 22);
            this.RATING_Box.TabIndex = 12;
            // 
            // CustomersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 166);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RATING_Box);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CUSTOMER_PASSWORD_Box);
            this.Controls.Add(this.CUSTOMER_LOGIN_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "CustomersAdd";
            this.Text = "CustomersAdd";
            this.Load += new System.EventHandler(this.CustomersAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CUSTOMER_PASSWORD_Box;
        private System.Windows.Forms.TextBox CUSTOMER_LOGIN_Box;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RATING_Box;
    }
}