﻿namespace DishesApp.TablesAddForms
{
    partial class Inst_To_DishAdd
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
            this.ID_DISH_Box = new System.Windows.Forms.TextBox();
            this.ID_INSTRUMENT_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(63, 72);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(61, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 35;
            this.CUSTOMER_PASSWORD.Text = "ID_DISH";
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(5, 41);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(119, 17);
            this.CUSTOMER_LOGIN.TabIndex = 34;
            this.CUSTOMER_LOGIN.Text = "ID_INSTRUMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Inst_To_Dish";
            // 
            // ID_DISH_Box
            // 
            this.ID_DISH_Box.Location = new System.Drawing.Point(130, 67);
            this.ID_DISH_Box.Name = "ID_DISH_Box";
            this.ID_DISH_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_DISH_Box.TabIndex = 32;
            // 
            // ID_INSTRUMENT_Box
            // 
            this.ID_INSTRUMENT_Box.Location = new System.Drawing.Point(130, 38);
            this.ID_INSTRUMENT_Box.Name = "ID_INSTRUMENT_Box";
            this.ID_INSTRUMENT_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_INSTRUMENT_Box.TabIndex = 31;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(89, 105);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 30;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Inst_To_DishAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 155);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_DISH_Box);
            this.Controls.Add(this.ID_INSTRUMENT_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "Inst_To_DishAdd";
            this.Text = "Inst_To_Dish";
            this.Load += new System.EventHandler(this.Inst_To_Dish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_DISH_Box;
        private System.Windows.Forms.TextBox ID_INSTRUMENT_Box;
        private System.Windows.Forms.Button AddButton;
    }
}