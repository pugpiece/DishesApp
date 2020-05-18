namespace DishesApp.TablesAddForms
{
    partial class DishTypesAdd
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
            this.DTYPE_DESCRIPTION_Box = new System.Windows.Forms.TextBox();
            this.DTYPE_NAME_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(12, 70);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(154, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 29;
            this.CUSTOMER_PASSWORD.Text = "DTYPE_DESCRIPTION";
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(65, 44);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(101, 17);
            this.CUSTOMER_LOGIN.TabIndex = 28;
            this.CUSTOMER_LOGIN.Text = "DTYPE_NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "DishTypes";
            // 
            // DTYPE_DESCRIPTION_Box
            // 
            this.DTYPE_DESCRIPTION_Box.Location = new System.Drawing.Point(172, 70);
            this.DTYPE_DESCRIPTION_Box.Name = "DTYPE_DESCRIPTION_Box";
            this.DTYPE_DESCRIPTION_Box.Size = new System.Drawing.Size(100, 22);
            this.DTYPE_DESCRIPTION_Box.TabIndex = 26;
            // 
            // DTYPE_NAME_Box
            // 
            this.DTYPE_NAME_Box.Location = new System.Drawing.Point(172, 41);
            this.DTYPE_NAME_Box.Name = "DTYPE_NAME_Box";
            this.DTYPE_NAME_Box.Size = new System.Drawing.Size(100, 22);
            this.DTYPE_NAME_Box.TabIndex = 25;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(103, 101);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DishTypesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 136);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTYPE_DESCRIPTION_Box);
            this.Controls.Add(this.DTYPE_NAME_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "DishTypesAdd";
            this.Text = "DishTypesAdd";
            this.Load += new System.EventHandler(this.DishTypesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DTYPE_DESCRIPTION_Box;
        private System.Windows.Forms.TextBox DTYPE_NAME_Box;
        private System.Windows.Forms.Button AddButton;
    }
}