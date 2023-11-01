namespace ChatBotGPT
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
            richOuput = new RichTextBox();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // richOuput
            // 
            richOuput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richOuput.Location = new Point(14, 16);
            richOuput.Margin = new Padding(3, 4, 3, 4);
            richOuput.Name = "richOuput";
            richOuput.Size = new Size(819, 469);
            richOuput.TabIndex = 0;
            richOuput.Text = "";
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(14, 495);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(677, 88);
            txtInput.TabIndex = 1;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Location = new Point(703, 495);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(130, 89);
            btnSend.TabIndex = 2;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 600);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(richOuput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "ChatBotGPT";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richOuput;
        private TextBox txtInput;
        private Button btnSend;
    }
}