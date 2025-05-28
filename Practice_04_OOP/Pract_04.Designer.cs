namespace Practice_04_OOP
{
    partial class CountryMedal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_CountBronzeMedal = new TextBox();
            tb_CountSilverMedal = new TextBox();
            tb_CountGoldMedals = new TextBox();
            tb_CountSportsmans = new TextBox();
            tb_Country = new TextBox();
            label1 = new Label();
            button_Add = new Button();
            tb_Result = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_CountBronzeMedal);
            groupBox1.Controls.Add(tb_CountSilverMedal);
            groupBox1.Controls.Add(tb_CountGoldMedals);
            groupBox1.Controls.Add(tb_CountSportsmans);
            groupBox1.Controls.Add(tb_Country);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 141);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 9;
            label5.Text = "Кількість бронзових медалей";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 112);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 8;
            label4.Text = "Кількість срібних медалей";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 83);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 7;
            label3.Text = "Кількість золотих медалей";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 54);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 6;
            label2.Text = "Кількість спортсменів";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_CountBronzeMedal
            // 
            tb_CountBronzeMedal.Location = new Point(185, 138);
            tb_CountBronzeMedal.Name = "tb_CountBronzeMedal";
            tb_CountBronzeMedal.Size = new Size(100, 23);
            tb_CountBronzeMedal.TabIndex = 5;
            // 
            // tb_CountSilverMedal
            // 
            tb_CountSilverMedal.Location = new Point(185, 109);
            tb_CountSilverMedal.Name = "tb_CountSilverMedal";
            tb_CountSilverMedal.Size = new Size(100, 23);
            tb_CountSilverMedal.TabIndex = 4;
            // 
            // tb_CountGoldMedals
            // 
            tb_CountGoldMedals.Location = new Point(185, 80);
            tb_CountGoldMedals.Name = "tb_CountGoldMedals";
            tb_CountGoldMedals.Size = new Size(100, 23);
            tb_CountGoldMedals.TabIndex = 3;
            // 
            // tb_CountSportsmans
            // 
            tb_CountSportsmans.Location = new Point(185, 51);
            tb_CountSportsmans.Name = "tb_CountSportsmans";
            tb_CountSportsmans.Size = new Size(100, 23);
            tb_CountSportsmans.TabIndex = 2;
            // 
            // tb_Country
            // 
            tb_Country.Location = new Point(185, 22);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new Size(100, 23);
            tb_Country.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Країна";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(12, 204);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(291, 23);
            button_Add.TabIndex = 1;
            button_Add.Text = "Додати";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // tb_Result
            // 
            tb_Result.Location = new Point(309, 22);
            tb_Result.Multiline = true;
            tb_Result.Name = "tb_Result";
            tb_Result.ReadOnly = true;
            tb_Result.ScrollBars = ScrollBars.Vertical;
            tb_Result.Size = new Size(346, 205);
            tb_Result.TabIndex = 2;
            tb_Result.TextChanged += tb_Result_TextChanged;
            // 
            // CountryMedal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 236);
            Controls.Add(tb_Result);
            Controls.Add(button_Add);
            Controls.Add(groupBox1);
            Name = "CountryMedal";
            Text = "Список";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_CountBronzeMedal;
        private TextBox tb_CountSilverMedal;
        private TextBox tb_CountGoldMedals;
        private TextBox tb_CountSportsmans;
        private TextBox tb_Country;
        private Label label1;
        private Button button_Add;
        private TextBox tb_Result;
    }
}
