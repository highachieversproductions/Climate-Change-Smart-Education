namespace ccse
{
    partial class links
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(342, 226);
            button1.Name = "button1";
            button1.Size = new Size(109, 68);
            button1.TabIndex = 1;
            button1.Text = "Climate Change Video";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // links
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 170, 51);
            ClientSize = new Size(824, 529);
            Controls.Add(button1);
            Name = "links";
            Text = "links";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
    }
}