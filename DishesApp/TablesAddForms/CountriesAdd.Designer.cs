namespace DishesApp.TablesAddForms
{
    partial class CountriesAdd
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
            this.AddButton = new System.Windows.Forms.Button();
            this.COUNTRY_NAME_Box = new System.Windows.Forms.TextBox();
            this.COUNTRY_DESCRIPTION_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(141, 106);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // COUNTRY_NAME_Box
            // 
            this.COUNTRY_NAME_Box.Location = new System.Drawing.Point(189, 39);
            this.COUNTRY_NAME_Box.Name = "COUNTRY_NAME_Box";
            this.COUNTRY_NAME_Box.Size = new System.Drawing.Size(100, 22);
            this.COUNTRY_NAME_Box.TabIndex = 1;
            // 
            // COUNTRY_DESCRIPTION_Box
            // 
            this.COUNTRY_DESCRIPTION_Box.Location = new System.Drawing.Point(189, 67);
            this.COUNTRY_DESCRIPTION_Box.Name = "COUNTRY_DESCRIPTION_Box";
            this.COUNTRY_DESCRIPTION_Box.Size = new System.Drawing.Size(100, 22);
            this.COUNTRY_DESCRIPTION_Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Countries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "COUNTRY_NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "COUNTRY_DESCRIPTION";
            // 
            // CountriesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COUNTRY_DESCRIPTION_Box);
            this.Controls.Add(this.COUNTRY_NAME_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "CountriesAdd";
            this.Text = "CountriesAdd";
            this.Load += new System.EventHandler(this.CountriesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox COUNTRY_NAME_Box;
        private System.Windows.Forms.TextBox COUNTRY_DESCRIPTION_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}