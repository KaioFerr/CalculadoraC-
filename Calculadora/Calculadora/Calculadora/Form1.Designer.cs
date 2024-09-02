
namespace Calculadora
{
    partial class Form1
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
            bt_1 = new Button();
            bt_0 = new Button();
            bt_point = new Button();
            bt_result = new Button();
            bt_sum = new Button();
            bt_sub = new Button();
            bt_mult = new Button();
            bt_div = new Button();
            bt_delete = new Button();
            txt_result = new TextBox();
            label1 = new Label();
            lb_op = new Label();
            bt_8 = new Button();
            bt_7 = new Button();
            bt_2 = new Button();
            bt_3 = new Button();
            bt_4 = new Button();
            bt_9 = new Button();
            bt_6 = new Button();
            bt_5 = new Button();
            bt_clear = new Button();
            SuspendLayout();
            // 
            // bt_1
            // 
            bt_1.BackColor = Color.White;
            bt_1.Font = new Font("Segoe UI", 12F);
            bt_1.ImageAlign = ContentAlignment.MiddleLeft;
            bt_1.Location = new Point(12, 205);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(44, 42);
            bt_1.TabIndex = 2;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = false;
            bt_1.Click += bt_1_Click;
            // 
            // bt_0
            // 
            bt_0.BackColor = Color.White;
            bt_0.Font = new Font("Segoe UI", 12F);
            bt_0.Location = new Point(12, 253);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(94, 35);
            bt_0.TabIndex = 3;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = false;
            bt_0.Click += bt_0_Click;
            // 
            // bt_point
            // 
            bt_point.BackColor = Color.White;
            bt_point.Font = new Font("Segoe UI", 12F);
            bt_point.Location = new Point(112, 253);
            bt_point.Name = "bt_point";
            bt_point.Size = new Size(44, 35);
            bt_point.TabIndex = 10;
            bt_point.Text = ",";
            bt_point.UseVisualStyleBackColor = false;
            bt_point.Click += bt_point_Click_1;
            // 
            // bt_result
            // 
            bt_result.BackColor = Color.White;
            bt_result.Font = new Font("Segoe UI", 12F);
            bt_result.Location = new Point(162, 205);
            bt_result.Name = "bt_result";
            bt_result.Size = new Size(62, 83);
            bt_result.TabIndex = 11;
            bt_result.Text = "=";
            bt_result.UseVisualStyleBackColor = false;
            bt_result.Click += bt_result_Click_1;
            // 
            // bt_sum
            // 
            bt_sum.BackColor = Color.White;
            bt_sum.Font = new Font("Segoe UI", 12F);
            bt_sum.Location = new Point(162, 157);
            bt_sum.Name = "bt_sum";
            bt_sum.Size = new Size(62, 42);
            bt_sum.TabIndex = 12;
            bt_sum.Text = "+";
            bt_sum.UseVisualStyleBackColor = false;
            bt_sum.Click += bt_sum_Click_1;
            // 
            // bt_sub
            // 
            bt_sub.BackColor = Color.White;
            bt_sub.Font = new Font("Segoe UI", 12F);
            bt_sub.Location = new Point(162, 109);
            bt_sub.Name = "bt_sub";
            bt_sub.Size = new Size(62, 42);
            bt_sub.TabIndex = 13;
            bt_sub.Text = "-";
            bt_sub.UseVisualStyleBackColor = false;
            bt_sub.Click += bt_sub_Click_1;
            // 
            // bt_mult
            // 
            bt_mult.BackColor = Color.White;
            bt_mult.Font = new Font("Segoe UI", 12F);
            bt_mult.Location = new Point(162, 63);
            bt_mult.Name = "bt_mult";
            bt_mult.Size = new Size(62, 42);
            bt_mult.TabIndex = 14;
            bt_mult.Text = "*";
            bt_mult.UseVisualStyleBackColor = false;
            bt_mult.Click += bt_mult_Click_1;
            // 
            // bt_div
            // 
            bt_div.BackColor = Color.White;
            bt_div.Font = new Font("Segoe UI", 12F);
            bt_div.Location = new Point(112, 63);
            bt_div.Name = "bt_div";
            bt_div.Size = new Size(44, 42);
            bt_div.TabIndex = 15;
            bt_div.Text = "/";
            bt_div.UseVisualStyleBackColor = false;
            bt_div.Click += bt_div_Click_1;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.White;
            bt_delete.Font = new Font("Segoe UI", 12F);
            bt_delete.Location = new Point(62, 63);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(44, 42);
            bt_delete.TabIndex = 16;
            bt_delete.Text = "D";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // txt_result
            // 
            txt_result.Font = new Font("Segoe UI", 14F);
            txt_result.Location = new Point(13, 15);
            txt_result.Name = "txt_result";
            txt_result.ReadOnly = true;
            txt_result.Size = new Size(212, 32);
            txt_result.TabIndex = 18;
            txt_result.TextChanged += txt_result_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 19;
            // 
            // lb_op
            // 
            lb_op.AutoSize = true;
            lb_op.Location = new Point(26, 15);
            lb_op.Name = "lb_op";
            lb_op.Size = new Size(0, 15);
            lb_op.TabIndex = 20;
            // 
            // bt_8
            // 
            bt_8.BackColor = Color.White;
            bt_8.Font = new Font("Segoe UI", 12F);
            bt_8.Location = new Point(62, 109);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(44, 42);
            bt_8.TabIndex = 25;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = false;
            bt_8.Click += bt_8_Click;
            // 
            // bt_7
            // 
            bt_7.BackColor = Color.White;
            bt_7.Font = new Font("Segoe UI", 12F);
            bt_7.ImageAlign = ContentAlignment.MiddleLeft;
            bt_7.Location = new Point(12, 111);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(44, 42);
            bt_7.TabIndex = 28;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = false;
            bt_7.Click += bt_7_Click_1;
            // 
            // bt_2
            // 
            bt_2.BackColor = Color.White;
            bt_2.Font = new Font("Segoe UI", 12F);
            bt_2.Location = new Point(62, 205);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(44, 42);
            bt_2.TabIndex = 29;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = false;
            bt_2.Click += bt_2_Click_1;
            // 
            // bt_3
            // 
            bt_3.BackColor = Color.White;
            bt_3.Font = new Font("Segoe UI", 12F);
            bt_3.Location = new Point(112, 205);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(44, 42);
            bt_3.TabIndex = 30;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = false;
            bt_3.Click += bt_3_Click;
            // 
            // bt_4
            // 
            bt_4.BackColor = Color.White;
            bt_4.Font = new Font("Segoe UI", 12F);
            bt_4.ImageAlign = ContentAlignment.MiddleLeft;
            bt_4.Location = new Point(12, 157);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(44, 42);
            bt_4.TabIndex = 31;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = false;
            bt_4.Click += bt_4_Click_1;
            // 
            // bt_9
            // 
            bt_9.BackColor = Color.White;
            bt_9.Font = new Font("Segoe UI", 12F);
            bt_9.Location = new Point(112, 111);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(44, 42);
            bt_9.TabIndex = 32;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = false;
            bt_9.Click += bt_9_Click_1;
            // 
            // bt_6
            // 
            bt_6.BackColor = Color.White;
            bt_6.Font = new Font("Segoe UI", 12F);
            bt_6.Location = new Point(112, 159);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(44, 42);
            bt_6.TabIndex = 33;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = false;
            bt_6.Click += bt_6_Click_1;
            // 
            // bt_5
            // 
            bt_5.BackColor = Color.White;
            bt_5.Font = new Font("Segoe UI", 12F);
            bt_5.Location = new Point(62, 157);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(44, 42);
            bt_5.TabIndex = 34;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = false;
            bt_5.Click += bt_5_Click_1;
            // 
            // bt_clear
            // 
            bt_clear.BackColor = Color.White;
            bt_clear.Font = new Font("Segoe UI", 12F);
            bt_clear.ImageAlign = ContentAlignment.MiddleLeft;
            bt_clear.Location = new Point(12, 63);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(44, 42);
            bt_clear.TabIndex = 35;
            bt_clear.Text = "C";
            bt_clear.UseVisualStyleBackColor = false;
            bt_clear.Click += bt_clear_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(238, 301);
            Controls.Add(bt_clear);
            Controls.Add(bt_5);
            Controls.Add(bt_6);
            Controls.Add(bt_9);
            Controls.Add(bt_4);
            Controls.Add(bt_3);
            Controls.Add(bt_2);
            Controls.Add(bt_7);
            Controls.Add(bt_8);
            Controls.Add(lb_op);
            Controls.Add(label1);
            Controls.Add(txt_result);
            Controls.Add(bt_delete);
            Controls.Add(bt_div);
            Controls.Add(bt_mult);
            Controls.Add(bt_sub);
            Controls.Add(bt_sum);
            Controls.Add(bt_result);
            Controls.Add(bt_point);
            Controls.Add(bt_0);
            Controls.Add(bt_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_sum_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_point_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button bt_1;
        private Button bt_0;
        private Button bt_point;
        private Button bt_result;
        private Button bt_sum;
        private Button bt_sub;
        private Button bt_mult;
        private Button bt_div;
        private Button bt_delete;
        private TextBox txt_result;
        private Label label1;
        private Label lb_op;
        private Button bt_8;
        private Button bt_7;
        private Button bt_2;
        private Button bt_3;
        private Button bt_4;
        private Button bt_9;
        private Button bt_6;
        private Button bt_5;
        private Button bt_clear;
    }
}
