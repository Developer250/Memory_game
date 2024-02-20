namespace Memory_game
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
            components = new System.ComponentModel.Container();
            LBStatus = new Label();
            LBTimeLeft = new Label();
            btnRestart = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LBStatus
            // 
            LBStatus.AutoSize = true;
            LBStatus.Location = new Point(620, 173);
            LBStatus.Name = "LBStatus";
            LBStatus.Size = new Size(142, 20);
            LBStatus.TabIndex = 0;
            LBStatus.Text = "Match or Missmatch";
            // 
            // LBTimeLeft
            // 
            LBTimeLeft.AutoSize = true;
            LBTimeLeft.Location = new Point(620, 230);
            LBTimeLeft.Name = "LBTimeLeft";
            LBTimeLeft.Size = new Size(91, 20);
            LBTimeLeft.TabIndex = 1;
            LBTimeLeft.Text = "Time left: 30";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(620, 98);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(108, 45);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += RestartGameEvent;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestart);
            Controls.Add(LBTimeLeft);
            Controls.Add(LBStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBStatus;
        private Label LBTimeLeft;
        private Button btnRestart;
        private System.Windows.Forms.Timer gameTimer;
    }
}
