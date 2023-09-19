namespace music_player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            folder = new Button();
            button1 = new Button();
            panel3 = new Panel();
            prev_15 = new Button();
            loop = new Button();
            prev = new Button();
            next = new Button();
            pass = new Button();
            panel4 = new Panel();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(864, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 76);
            panel1.TabIndex = 1;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(683, 3);
            button12.Name = "button12";
            button12.Size = new Size(57, 70);
            button12.TabIndex = 9;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(736, 3);
            button11.Name = "button11";
            button11.Size = new Size(61, 70);
            button11.TabIndex = 8;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(803, 3);
            button10.Name = "button10";
            button10.Size = new Size(57, 70);
            button10.TabIndex = 7;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(folder);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 102);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // folder
            // 
            folder.BackgroundImageLayout = ImageLayout.Zoom;
            folder.FlatAppearance.BorderSize = 0;
            folder.FlatStyle = FlatStyle.Flat;
            folder.Image = (Image)resources.GetObject("folder.Image");
            folder.Location = new Point(96, 13);
            folder.Name = "folder";
            folder.Size = new Size(90, 76);
            folder.TabIndex = 1;
            folder.UseVisualStyleBackColor = true;
            folder.Click += folder_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 14);
            button1.Name = "button1";
            button1.Size = new Size(90, 76);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(prev_15);
            panel3.Controls.Add(loop);
            panel3.Controls.Add(prev);
            panel3.Controls.Add(next);
            panel3.Controls.Add(pass);
            panel3.Location = new Point(195, 487);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 102);
            panel3.TabIndex = 1;
            // 
            // prev_15
            // 
            prev_15.BackgroundImageLayout = ImageLayout.Zoom;
            prev_15.Enabled = false;
            prev_15.FlatAppearance.BorderSize = 0;
            prev_15.FlatStyle = FlatStyle.Flat;
            prev_15.Image = (Image)resources.GetObject("prev_15.Image");
            prev_15.Location = new Point(12, 9);
            prev_15.Name = "prev_15";
            prev_15.Size = new Size(90, 81);
            prev_15.TabIndex = 2;
            prev_15.UseVisualStyleBackColor = true;
            prev_15.Click += prev_15_Click;
            // 
            // loop
            // 
            loop.BackgroundImageLayout = ImageLayout.Zoom;
            loop.Enabled = false;
            loop.FlatAppearance.BorderSize = 0;
            loop.FlatStyle = FlatStyle.Flat;
            loop.Image = (Image)resources.GetObject("loop.Image");
            loop.Location = new Point(389, 13);
            loop.Name = "loop";
            loop.Size = new Size(87, 74);
            loop.TabIndex = 6;
            loop.UseVisualStyleBackColor = true;
            loop.Click += loop_Click;
            // 
            // prev
            // 
            prev.BackgroundImageLayout = ImageLayout.Zoom;
            prev.Enabled = false;
            prev.FlatAppearance.BorderSize = 0;
            prev.FlatStyle = FlatStyle.Flat;
            prev.Image = (Image)resources.GetObject("prev.Image");
            prev.Location = new Point(108, 12);
            prev.Name = "prev";
            prev.Size = new Size(90, 76);
            prev.TabIndex = 3;
            prev.UseVisualStyleBackColor = true;
            prev.Click += prev_Click;
            // 
            // next
            // 
            next.BackgroundImageLayout = ImageLayout.Zoom;
            next.Enabled = false;
            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            next.Image = (Image)resources.GetObject("next.Image");
            next.Location = new Point(293, 14);
            next.Name = "next";
            next.Size = new Size(90, 76);
            next.TabIndex = 4;
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // pass
            // 
            pass.BackgroundImageLayout = ImageLayout.Zoom;
            pass.Enabled = false;
            pass.FlatAppearance.BorderSize = 0;
            pass.FlatStyle = FlatStyle.Flat;
            pass.Image = (Image)resources.GetObject("pass.Image");
            pass.Location = new Point(204, 9);
            pass.Name = "pass";
            pass.Size = new Size(90, 84);
            pass.TabIndex = 5;
            pass.UseVisualStyleBackColor = true;
            pass.Click += pass_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button8);
            panel4.Location = new Point(683, 487);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 102);
            panel4.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(3, 14);
            button7.Name = "button7";
            button7.Size = new Size(90, 76);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(88, 14);
            button8.Name = "button8";
            button8.Size = new Size(90, 76);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(864, 589);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button folder;
        private Button prev_15;
        private Button loop;
        private Button prev;
        private Button next;
        private Button pass;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}