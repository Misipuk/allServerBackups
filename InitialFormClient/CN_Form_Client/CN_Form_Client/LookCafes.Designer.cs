﻿namespace CN_Form_Client
{
    partial class LookCafes
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
            this.cafeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.minStar = new System.Windows.Forms.TextBox();
            this.maxStar = new System.Windows.Forms.TextBox();
            this.onFiltB = new System.Windows.Forms.Button();
            this.offFiltB = new System.Windows.Forms.Button();
            this.addReviewB = new System.Windows.Forms.Button();
            this.createCafeB = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cafeListBox
            // 
            this.cafeListBox.FormattingEnabled = true;
            this.cafeListBox.ItemHeight = 25;
            this.cafeListBox.Location = new System.Drawing.Point(44, 85);
            this.cafeListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cafeListBox.Name = "cafeListBox";
            this.cafeListBox.Size = new System.Drawing.Size(319, 454);
            this.cafeListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список кафе:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фильтр:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Город:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Оценка от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "до";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(613, 143);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(204, 30);
            this.nameBox.TabIndex = 7;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(613, 203);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(204, 30);
            this.CityBox.TabIndex = 8;
            // 
            // minStar
            // 
            this.minStar.Location = new System.Drawing.Point(613, 270);
            this.minStar.Name = "minStar";
            this.minStar.Size = new System.Drawing.Size(53, 30);
            this.minStar.TabIndex = 9;
            // 
            // maxStar
            // 
            this.maxStar.Location = new System.Drawing.Point(713, 270);
            this.maxStar.Name = "maxStar";
            this.maxStar.Size = new System.Drawing.Size(53, 30);
            this.maxStar.TabIndex = 10;
            // 
            // onFiltB
            // 
            this.onFiltB.Location = new System.Drawing.Point(500, 344);
            this.onFiltB.Name = "onFiltB";
            this.onFiltB.Size = new System.Drawing.Size(165, 65);
            this.onFiltB.TabIndex = 11;
            this.onFiltB.Text = "Включить фильтр";
            this.onFiltB.UseVisualStyleBackColor = true;
            // 
            // offFiltB
            // 
            this.offFiltB.Location = new System.Drawing.Point(713, 344);
            this.offFiltB.Name = "offFiltB";
            this.offFiltB.Size = new System.Drawing.Size(165, 65);
            this.offFiltB.TabIndex = 12;
            this.offFiltB.Text = "Сбросить фильтр";
            this.offFiltB.UseVisualStyleBackColor = true;
            // 
            // addReviewB
            // 
            this.addReviewB.Location = new System.Drawing.Point(268, 579);
            this.addReviewB.Name = "addReviewB";
            this.addReviewB.Size = new System.Drawing.Size(165, 65);
            this.addReviewB.TabIndex = 13;
            this.addReviewB.Text = "Добавить отзыв";
            this.addReviewB.UseVisualStyleBackColor = true;
            // 
            // createCafeB
            // 
            this.createCafeB.Location = new System.Drawing.Point(467, 578);
            this.createCafeB.Name = "createCafeB";
            this.createCafeB.Size = new System.Drawing.Size(165, 65);
            this.createCafeB.TabIndex = 14;
            this.createCafeB.Text = "Создать кафе";
            this.createCafeB.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(790, 578);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 65);
            this.button5.TabIndex = 15;
            this.button5.Text = "Выйти из аккаунта";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LookCafes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 655);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.createCafeB);
            this.Controls.Add(this.addReviewB);
            this.Controls.Add(this.offFiltB);
            this.Controls.Add(this.onFiltB);
            this.Controls.Add(this.maxStar);
            this.Controls.Add(this.minStar);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cafeListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LookCafes";
            this.Text = "CafesUA List ";
            this.Load += new System.EventHandler(this.LookCafes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cafeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox minStar;
        private System.Windows.Forms.TextBox maxStar;
        private System.Windows.Forms.Button onFiltB;
        private System.Windows.Forms.Button offFiltB;
        private System.Windows.Forms.Button addReviewB;
        private System.Windows.Forms.Button createCafeB;
        private System.Windows.Forms.Button button5;
    }
}