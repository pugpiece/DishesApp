namespace DishesApp.TablesAddForms
{
    partial class InstrumentsAdd
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
            this.INSTRUMENT_DESCRIPTION_Box = new System.Windows.Forms.TextBox();
            this.INSTRUMENT_NAME_Box = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PRICE_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CUSTOMER_PASSWORD
            // 
            this.CUSTOMER_PASSWORD.AutoSize = true;
            this.CUSTOMER_PASSWORD.Location = new System.Drawing.Point(9, 69);
            this.CUSTOMER_PASSWORD.Name = "CUSTOMER_PASSWORD";
            this.CUSTOMER_PASSWORD.Size = new System.Drawing.Size(198, 17);
            this.CUSTOMER_PASSWORD.TabIndex = 47;
            this.CUSTOMER_PASSWORD.Text = "INSTRUMENT_DESCRIPTION";
            // 
            // CUSTOMER_LOGIN
            // 
            this.CUSTOMER_LOGIN.AutoSize = true;
            this.CUSTOMER_LOGIN.Location = new System.Drawing.Point(62, 39);
            this.CUSTOMER_LOGIN.Name = "CUSTOMER_LOGIN";
            this.CUSTOMER_LOGIN.Size = new System.Drawing.Size(145, 17);
            this.CUSTOMER_LOGIN.TabIndex = 46;
            this.CUSTOMER_LOGIN.Text = "INSTRUMENT_NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Instruments";
            // 
            // INSTRUMENT_DESCRIPTION_Box
            // 
            this.INSTRUMENT_DESCRIPTION_Box.Location = new System.Drawing.Point(213, 66);
            this.INSTRUMENT_DESCRIPTION_Box.Name = "INSTRUMENT_DESCRIPTION_Box";
            this.INSTRUMENT_DESCRIPTION_Box.Size = new System.Drawing.Size(100, 22);
            this.INSTRUMENT_DESCRIPTION_Box.TabIndex = 44;
            // 
            // INSTRUMENT_NAME_Box
            // 
            this.INSTRUMENT_NAME_Box.Location = new System.Drawing.Point(213, 36);
            this.INSTRUMENT_NAME_Box.Name = "INSTRUMENT_NAME_Box";
            this.INSTRUMENT_NAME_Box.Size = new System.Drawing.Size(100, 22);
            this.INSTRUMENT_NAME_Box.TabIndex = 43;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(132, 132);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 42;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "PRICE";
            // 
            // PRICE_Box
            // 
            this.PRICE_Box.Location = new System.Drawing.Point(213, 93);
            this.PRICE_Box.Name = "PRICE_Box";
            this.PRICE_Box.Size = new System.Drawing.Size(100, 22);
            this.PRICE_Box.TabIndex = 48;
            // 
            // InstrumentsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PRICE_Box);
            this.Controls.Add(this.CUSTOMER_PASSWORD);
            this.Controls.Add(this.CUSTOMER_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INSTRUMENT_DESCRIPTION_Box);
            this.Controls.Add(this.INSTRUMENT_NAME_Box);
            this.Controls.Add(this.AddButton);
            this.Name = "InstrumentsAdd";
            this.Text = "InstrumentsAdd";
            this.Load += new System.EventHandler(this.InstrumentsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CUSTOMER_PASSWORD;
        private System.Windows.Forms.Label CUSTOMER_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INSTRUMENT_DESCRIPTION_Box;
        private System.Windows.Forms.TextBox INSTRUMENT_NAME_Box;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PRICE_Box;
    }
}