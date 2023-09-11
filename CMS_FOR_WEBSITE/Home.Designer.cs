namespace CMS_FOR_WEBSITE
{
    partial class Home
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Login = new TextBox();
            Paswword = new TextBox();
            Host = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(14, 14);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 81);
            button1.TabIndex = 0;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(196, 14);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(329, 81);
            button2.TabIndex = 1;
            button2.Text = "Видалити + Редагувати";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Paswword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Host";
            // 
            // Login
            // 
            Login.Location = new Point(118, 108);
            Login.Margin = new Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.Size = new Size(245, 23);
            Login.TabIndex = 5;
            // 
            // Paswword
            // 
            Paswword.Location = new Point(118, 138);
            Paswword.Margin = new Padding(4, 3, 4, 3);
            Paswword.Name = "Paswword";
            Paswword.Size = new Size(245, 23);
            Paswword.TabIndex = 6;
            // 
            // Host
            // 
            Host.Location = new Point(118, 167);
            Host.Margin = new Padding(4, 3, 4, 3);
            Host.Name = "Host";
            Host.Size = new Size(245, 23);
            Host.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(405, 108);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(120, 53);
            button3.TabIndex = 8;
            button3.Text = "Connect";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(405, 165);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(120, 27);
            button4.TabIndex = 9;
            button4.Text = "Upload DB";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(540, 205);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Host);
            Controls.Add(Paswword);
            Controls.Add(Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += Home_FormClosing;
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Login;
        private TextBox Paswword;
        private TextBox Host;
        private Button button3;
        private Button button4;
    }
}