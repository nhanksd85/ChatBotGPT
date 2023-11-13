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
            label1 = new Label();
            txtAction = new TextBox();
            txtCustomerID = new TextBox();
            label2 = new Label();
            txtCustomerPhone = new TextBox();
            label3 = new Label();
            richGPTResponse = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            richBWACOResponse = new RichTextBox();
            txtCategory = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // richOuput
            // 
            richOuput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richOuput.Location = new Point(14, 16);
            richOuput.Margin = new Padding(3, 4, 3, 4);
            richOuput.Name = "richOuput";
            richOuput.Size = new Size(677, 236);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Hành Động";
            // 
            // txtAction
            // 
            txtAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAction.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAction.Location = new Point(703, 40);
            txtAction.Margin = new Padding(3, 4, 3, 4);
            txtAction.Multiline = true;
            txtAction.Name = "txtAction";
            txtAction.Size = new Size(123, 30);
            txtAction.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerID.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.Location = new Point(703, 202);
            txtCustomerID.Margin = new Padding(3, 4, 3, 4);
            txtCustomerID.Multiline = true;
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(123, 30);
            txtCustomerID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 178);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã Khách Hàng";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerPhone.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerPhone.Location = new Point(703, 276);
            txtCustomerPhone.Margin = new Padding(3, 4, 3, 4);
            txtCustomerPhone.Multiline = true;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(123, 30);
            txtCustomerPhone.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(703, 252);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 7;
            label3.Text = "Số Điện Thoại";
            // 
            // richGPTResponse
            // 
            richGPTResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richGPTResponse.Location = new Point(12, 290);
            richGPTResponse.Margin = new Padding(3, 4, 3, 4);
            richGPTResponse.Name = "richGPTResponse";
            richGPTResponse.Size = new Size(677, 67);
            richGPTResponse.TabIndex = 9;
            richGPTResponse.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 266);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 10;
            label4.Text = "GPT phân loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 372);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 12;
            label5.Text = "BWACO phản hồi";
            // 
            // richBWACOResponse
            // 
            richBWACOResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richBWACOResponse.Location = new Point(12, 396);
            richBWACOResponse.Margin = new Padding(3, 4, 3, 4);
            richBWACOResponse.Name = "richBWACOResponse";
            richBWACOResponse.Size = new Size(677, 67);
            richBWACOResponse.TabIndex = 11;
            richBWACOResponse.Text = "";
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCategory.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(703, 120);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(123, 30);
            txtCategory.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(703, 96);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 13;
            label6.Text = "Phân Loại";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 600);
            Controls.Add(txtCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richBWACOResponse);
            Controls.Add(label4);
            Controls.Add(richGPTResponse);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label3);
            Controls.Add(txtCustomerID);
            Controls.Add(label2);
            Controls.Add(txtAction);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtAction;
        private TextBox txtCustomerID;
        private Label label2;
        private TextBox txtCustomerPhone;
        private Label label3;
        private RichTextBox richGPTResponse;
        private Label label4;
        private Label label5;
        private RichTextBox richBWACOResponse;
        private TextBox txtCategory;
        private Label label6;
    }
}