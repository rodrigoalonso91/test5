
namespace test5
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Score = new System.Windows.Forms.Label();
            this.Lbl_Timer = new System.Windows.Forms.Label();
            this.BtnClickGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStartGame.Location = new System.Drawing.Point(201, 226);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(208, 62);
            this.BtnStartGame.TabIndex = 0;
            this.BtnStartGame.Text = "Start";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Lbl_Score);
            this.panel1.Controls.Add(this.Lbl_Timer);
            this.panel1.Controls.Add(this.BtnClickGame);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 192);
            this.panel1.TabIndex = 1;
            // 
            // Lbl_Score
            // 
            this.Lbl_Score.AutoSize = true;
            this.Lbl_Score.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Score.Location = new System.Drawing.Point(189, 117);
            this.Lbl_Score.Name = "Lbl_Score";
            this.Lbl_Score.Size = new System.Drawing.Size(24, 27);
            this.Lbl_Score.TabIndex = 4;
            this.Lbl_Score.Text = "0";
            // 
            // Lbl_Timer
            // 
            this.Lbl_Timer.AutoSize = true;
            this.Lbl_Timer.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Timer.Location = new System.Drawing.Point(189, 38);
            this.Lbl_Timer.Name = "Lbl_Timer";
            this.Lbl_Timer.Size = new System.Drawing.Size(33, 27);
            this.Lbl_Timer.TabIndex = 3;
            this.Lbl_Timer.Text = "10";
            // 
            // BtnClickGame
            // 
            this.BtnClickGame.BackColor = System.Drawing.Color.Gold;
            this.BtnClickGame.Enabled = false;
            this.BtnClickGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClickGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClickGame.Location = new System.Drawing.Point(407, 51);
            this.BtnClickGame.Name = "BtnClickGame";
            this.BtnClickGame.Size = new System.Drawing.Size(144, 96);
            this.BtnClickGame.TabIndex = 2;
            this.BtnClickGame.Text = "Click me!";
            this.BtnClickGame.UseVisualStyleBackColor = false;
            this.BtnClickGame.Click += new System.EventHandler(this.BtnClickGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(611, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnStartGame);
            this.Name = "MainForm";
            this.Text = "Test5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClickGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Score;
        private System.Windows.Forms.Label Lbl_Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

