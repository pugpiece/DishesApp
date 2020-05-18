namespace DishesApp.TablesAddForms
{
    partial class DishesAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.ID_DISH_TYPE_Box = new System.Windows.Forms.TextBox();
            this.CUSTOMER_PASSWORD = new System.Windows.Forms.Label();
            this.CUSTOMER_LOGIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RECIPE_Box = new System.Windows.Forms.TextBox();
            this.DISH_NAME_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_COUNTRY_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID_DISH_TYPE";
            // 
            // ID_DISH_TYPE_Box
            // 
            this.ID_DISH_TYPE_Box.Location = new System.Drawing.Point(123, 95);
            this.ID_DISH_TYPE_Box.Name = "ID_DISH_TYPE_Box";
            this.ID_DISH_TYPE_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_DISH_TYPE_Box.TabIndex = 20;
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(60, 72);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(57, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 19;
            this.CUSTOMER_PASSWORD.Text = "RECIPE";
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(30, 44);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(87, 17);
            this.CUSTOMER_LOGIN.TabIndex = 18;
            this.CUSTOMER_LOGIN.Text = "DISH_NAME";
            this.CUSTOMER_LOGIN.Click += new System.EventHandler(this.CUSTOMER_LOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dishes";
            // 
            // RECIPE_Box
            // 
            this.RECIPE_Box.Location = new System.Drawing.Point(123, 67);
            this.RECIPE_Box.Name = "RECIPE_Box";
            this.RECIPE_Box.Size = new System.Drawing.Size(100, 22);
            this.RECIPE_Box.TabIndex = 16;
            // 
            // DISH_NAME_Box
            // 
            this.DISH_NAME_Box.Location = new System.Drawing.Point(123, 39);
            this.DISH_NAME_Box.Name = "DISH_NAME_Box";
            this.DISH_NAME_Box.Size = new System.Drawing.Size(100, 22);
            this.DISH_NAME_Box.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(78, 162);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID_COUNTRY";
            // 
            // ID_COUNTRY_Box
            // 
            this.ID_COUNTRY_Box.Location = new System.Drawing.Point(123, 123);
            this.ID_COUNTRY_Box.Name = "ID_COUNTRY_Box";
            this.ID_COUNTRY_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_COUNTRY_Box.TabIndex = 22;
            // 
            // DishesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_COUNTRY_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_DISH_TYPE_Box);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RECIPE_Box);
            this.Controls.Add(this.DISH_NAME_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "DishesAdd";
            this.Text = "DishesAdd";
            this.Load += new System.EventHandler(this.DishesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_DISH_TYPE_Box;
        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RECIPE_Box;
        private System.Windows.Forms.TextBox DISH_NAME_Box;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_COUNTRY_Box;
    }
}