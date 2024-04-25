namespace C__Spiel_Janjao
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
            Title = new TextBox();
            button2 = new Button();
            Close = new Button();
            Start = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(75, 50);
            Title.Name = "Title";
            Title.Size = new Size(415, 57);
            Title.TabIndex = 0;
            Title.Text = "Place holder Title";
            // 
            // button2
            // 
            button2.Location = new Point(75, 300);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            Close.Location = new Point(75, 400);
            Close.Name = "Close";
            Close.Size = new Size(150, 50);
            Close.TabIndex = 3;
            Close.Text = "QUIT";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Start
            // 
            Start.Location = new Point(75, 200);
            Start.Name = "Start";
            Start.Size = new Size(150, 50);
            Start.TabIndex = 5;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(Start);
            Controls.Add(Close);
            Controls.Add(button2);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private Button button2;
        private Button Close;
        private Button Start;
    }
}
