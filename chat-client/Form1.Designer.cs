namespace chat_client
{
    partial class Chat_Room
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
            title = new Label();
            textBox_message = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button_chat = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F);
            title.Location = new Point(393, 24);
            title.Name = "title";
            title.Size = new Size(305, 51);
            title.TabIndex = 1;
            title.Text = "Generic chat app";
            title.Click += label1_Click;
            // 
            // textBox_message
            // 
            textBox_message.Font = new Font("Segoe UI", 14F);
            textBox_message.Location = new Point(42, 600);
            textBox_message.Name = "textBox_message";
            textBox_message.Size = new Size(488, 51);
            textBox_message.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 431);
            textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(722, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 542);
            panel1.TabIndex = 4;
            // 
            // button_chat
            // 
            button_chat.Location = new Point(536, 600);
            button_chat.Name = "button_chat";
            button_chat.Size = new Size(134, 51);
            button_chat.TabIndex = 5;
            button_chat.Text = "Chat";
            button_chat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(78, 64);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 1;
            label1.Text = "User Name here";
            // 
            // Chat_Room
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 693);
            Controls.Add(button_chat);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(textBox_message);
            Controls.Add(title);
            Name = "Chat_Room";
            Text = "Chat Room";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private TextBox textBox_message;
        private TextBox textBox1;
        private Panel panel1;
        private Button button_chat;
        private Label label1;
    }
}
