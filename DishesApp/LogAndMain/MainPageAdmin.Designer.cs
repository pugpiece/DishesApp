namespace DishesApp
{
    partial class MainPageAdmin
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
            this.TablesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoChangeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdShowButton = new System.Windows.Forms.Button();
            this.carbs_min = new System.Windows.Forms.TextBox();
            this.call_min = new System.Windows.Forms.TextBox();
            this.prot_min = new System.Windows.Forms.TextBox();
            this.fats_min = new System.Windows.Forms.TextBox();
            this.cost_min = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cost_max = new System.Windows.Forms.TextBox();
            this.fats_max = new System.Windows.Forms.TextBox();
            this.prot_max = new System.Windows.Forms.TextBox();
            this.call_max = new System.Windows.Forms.TextBox();
            this.carbs_max = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductShow = new System.Windows.Forms.DataGridView();
            this.ShowRecipe = new System.Windows.Forms.DataGridView();
            this.dishNumber = new System.Windows.Forms.TextBox();
            this.ShowRecipeButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // TablesList
            // 
            this.TablesList.FormattingEnabled = true;
            this.TablesList.ItemHeight = 16;
            this.TablesList.Location = new System.Drawing.Point(13, 41);
            this.TablesList.Name = "TablesList";
            this.TablesList.Size = new System.Drawing.Size(120, 388);
            this.TablesList.TabIndex = 0;
            this.TablesList.SelectedIndexChanged += new System.EventHandler(this.TablesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите таблицу";
            // 
            // GoChangeButton
            // 
            this.GoChangeButton.Location = new System.Drawing.Point(140, 41);
            this.GoChangeButton.Name = "GoChangeButton";
            this.GoChangeButton.Size = new System.Drawing.Size(187, 23);
            this.GoChangeButton.TabIndex = 2;
            this.GoChangeButton.Text = "Выбрать";
            this.GoChangeButton.UseVisualStyleBackColor = true;
            this.GoChangeButton.Click += new System.EventHandler(this.GoChangeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Просмотреть таблицы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdShowButton
            // 
            this.ProdShowButton.Location = new System.Drawing.Point(457, 415);
            this.ProdShowButton.Name = "ProdShowButton";
            this.ProdShowButton.Size = new System.Drawing.Size(172, 23);
            this.ProdShowButton.TabIndex = 4;
            this.ProdShowButton.Text = "Показать продукт!";
            this.ProdShowButton.UseVisualStyleBackColor = true;
            this.ProdShowButton.Click += new System.EventHandler(this.ProdShowButton_Click);
            // 
            // carbs_min
            // 
            this.carbs_min.Location = new System.Drawing.Point(469, 320);
            this.carbs_min.Name = "carbs_min";
            this.carbs_min.Size = new System.Drawing.Size(100, 22);
            this.carbs_min.TabIndex = 5;
            // 
            // call_min
            // 
            this.call_min.Location = new System.Drawing.Point(469, 349);
            this.call_min.Name = "call_min";
            this.call_min.Size = new System.Drawing.Size(100, 22);
            this.call_min.TabIndex = 6;
            // 
            // prot_min
            // 
            this.prot_min.Location = new System.Drawing.Point(469, 292);
            this.prot_min.Name = "prot_min";
            this.prot_min.Size = new System.Drawing.Size(100, 22);
            this.prot_min.TabIndex = 7;
            // 
            // fats_min
            // 
            this.fats_min.Location = new System.Drawing.Point(469, 261);
            this.fats_min.Name = "fats_min";
            this.fats_min.Size = new System.Drawing.Size(100, 22);
            this.fats_min.TabIndex = 8;
            // 
            // cost_min
            // 
            this.cost_min.Location = new System.Drawing.Point(469, 378);
            this.cost_min.Name = "cost_min";
            this.cost_min.Size = new System.Drawing.Size(100, 22);
            this.cost_min.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Жиры от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Белки от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Углеводы от";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Каллории от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Цена от";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(575, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "до";
            // 
            // cost_max
            // 
            this.cost_max.Location = new System.Drawing.Point(605, 375);
            this.cost_max.Name = "cost_max";
            this.cost_max.Size = new System.Drawing.Size(100, 22);
            this.cost_max.TabIndex = 19;
            // 
            // fats_max
            // 
            this.fats_max.Location = new System.Drawing.Point(605, 261);
            this.fats_max.Name = "fats_max";
            this.fats_max.Size = new System.Drawing.Size(100, 22);
            this.fats_max.TabIndex = 18;
            // 
            // prot_max
            // 
            this.prot_max.Location = new System.Drawing.Point(605, 289);
            this.prot_max.Name = "prot_max";
            this.prot_max.Size = new System.Drawing.Size(100, 22);
            this.prot_max.TabIndex = 17;
            // 
            // call_max
            // 
            this.call_max.Location = new System.Drawing.Point(605, 346);
            this.call_max.Name = "call_max";
            this.call_max.Size = new System.Drawing.Size(100, 22);
            this.call_max.TabIndex = 16;
            // 
            // carbs_max
            // 
            this.carbs_max.Location = new System.Drawing.Point(605, 317);
            this.carbs_max.Name = "carbs_max";
            this.carbs_max.Size = new System.Drawing.Size(100, 22);
            this.carbs_max.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "до";
            // 
            // ProductShow
            // 
            this.ProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductShow.Location = new System.Drawing.Point(374, 12);
            this.ProductShow.Name = "ProductShow";
            this.ProductShow.RowTemplate.Height = 24;
            this.ProductShow.Size = new System.Drawing.Size(331, 243);
            this.ProductShow.TabIndex = 25;
            // 
            // ShowRecipe
            // 
            this.ShowRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowRecipe.Location = new System.Drawing.Point(741, 12);
            this.ShowRecipe.Name = "ShowRecipe";
            this.ShowRecipe.RowTemplate.Height = 24;
            this.ShowRecipe.Size = new System.Drawing.Size(263, 150);
            this.ShowRecipe.TabIndex = 26;
            // 
            // dishNumber
            // 
            this.dishNumber.Location = new System.Drawing.Point(841, 172);
            this.dishNumber.Name = "dishNumber";
            this.dishNumber.Size = new System.Drawing.Size(72, 22);
            this.dishNumber.TabIndex = 27;
            // 
            // ShowRecipeButton
            // 
            this.ShowRecipeButton.Location = new System.Drawing.Point(919, 171);
            this.ShowRecipeButton.Name = "ShowRecipeButton";
            this.ShowRecipeButton.Size = new System.Drawing.Size(85, 23);
            this.ShowRecipeButton.TabIndex = 28;
            this.ShowRecipeButton.Text = "Показать";
            this.ShowRecipeButton.UseVisualStyleBackColor = true;
            this.ShowRecipeButton.Click += new System.EventHandler(this.ShowRecipeButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(738, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Номер блюда";
            // 
            // MainPageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ShowRecipeButton);
            this.Controls.Add(this.dishNumber);
            this.Controls.Add(this.ShowRecipe);
            this.Controls.Add(this.ProductShow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cost_max);
            this.Controls.Add(this.fats_max);
            this.Controls.Add(this.prot_max);
            this.Controls.Add(this.call_max);
            this.Controls.Add(this.carbs_max);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cost_min);
            this.Controls.Add(this.fats_min);
            this.Controls.Add(this.prot_min);
            this.Controls.Add(this.call_min);
            this.Controls.Add(this.carbs_min);
            this.Controls.Add(this.ProdShowButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoChangeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablesList);
            this.Name = "MainPageAdmin";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPageAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TablesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoChangeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProdShowButton;
        private System.Windows.Forms.TextBox carbs_min;
        private System.Windows.Forms.TextBox call_min;
        private System.Windows.Forms.TextBox prot_min;
        private System.Windows.Forms.TextBox fats_min;
        private System.Windows.Forms.TextBox cost_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cost_max;
        private System.Windows.Forms.TextBox fats_max;
        private System.Windows.Forms.TextBox prot_max;
        private System.Windows.Forms.TextBox call_max;
        private System.Windows.Forms.TextBox carbs_max;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ProductShow;
        private System.Windows.Forms.DataGridView ShowRecipe;
        private System.Windows.Forms.TextBox dishNumber;
        private System.Windows.Forms.Button ShowRecipeButton;
        private System.Windows.Forms.Label label12;
    }
}