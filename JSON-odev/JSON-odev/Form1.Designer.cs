namespace JSON_odev
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
            btnurungoster = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnurungoster
            // 
            btnurungoster.Location = new Point(113, 212);
            btnurungoster.Margin = new Padding(5, 4, 5, 4);
            btnurungoster.Name = "btnurungoster";
            btnurungoster.Size = new Size(204, 31);
            btnurungoster.TabIndex = 2;
            btnurungoster.Text = "ÜRÜN GÖSTER";
            btnurungoster.UseVisualStyleBackColor = true;
            btnurungoster.Click += btnurungoster_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(90, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 124);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 44);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 4;
            label1.Text = "ÜRÜNLER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 278);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnurungoster);
            Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnurungoster;
        private ListBox listBox1;
        private Label label1;
    }
}
