namespace ClientSideApp
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.severityComboBox = new System.Windows.Forms.ComboBox();
            this.eventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 1;
            label1.Text = "Важность:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(56, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 3;
            label2.Text = "Тип:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 13);
            label3.TabIndex = 4;
            label3.Text = "Сообщение:";
            // 
            // severityComboBox
            // 
            this.severityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.severityComboBox.FormattingEnabled = true;
            this.severityComboBox.Location = new System.Drawing.Point(91, 16);
            this.severityComboBox.Name = "severityComboBox";
            this.severityComboBox.Size = new System.Drawing.Size(121, 21);
            this.severityComboBox.TabIndex = 0;
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Location = new System.Drawing.Point(91, 56);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.eventTypeComboBox.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(91, 96);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(121, 20);
            this.messageTextBox.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(91, 138);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Послать";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(13, 176);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(223, 199);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 384);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.eventTypeComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.severityComboBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox severityComboBox;
        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

