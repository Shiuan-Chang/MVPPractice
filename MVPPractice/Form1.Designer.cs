namespace MVPPractice
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
            BrandName = new Label();
            Size = new Label();
            Price = new Label();

            SuspendLayout();
            // 
            // BrandName
            // 
            BrandName.AutoSize = true;
            BrandName.BackColor = SystemColors.ActiveCaption;
            BrandName.Location = new Point(123, 82);
            BrandName.Margin = new Padding(4, 0, 4, 0);
            BrandName.Name = "BrandName";
            BrandName.Size = new Size(52, 21);
            BrandName.TabIndex = 0;
            BrandName.Text = "label1";
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.BackColor = SystemColors.ActiveCaption;
            Size.Location = new Point(123, 132);
            Size.Name = "Size";
            Size.Size = new Size(52, 21);
            Size.TabIndex = 1;
            Size.Text = "label1";
            Size.Click += Content_Click;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = SystemColors.ActiveCaption;
            Price.Location = new Point(123, 186);
            Price.Name = "Price";
            Price.Size = new Size(52, 21);
            Price.TabIndex = 2;
            Price.Text = "label1";
            Price.Click += label1_Click;
            // 
            // Quantity
            // 

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);

            Controls.Add(Price);
            Controls.Add(Size);
            Controls.Add(BrandName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BrandName;
        private Label Size;
        private Label Price;

    }
}
