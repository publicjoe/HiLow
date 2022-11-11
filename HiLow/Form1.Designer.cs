namespace HiLow
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonLower = new System.Windows.Forms.Button();
      this.buttonHigher = new System.Windows.Forms.Button();
      this.labelScore = new System.Windows.Forms.Label();
      this.buttonPlay = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(407, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // highScoresToolStripMenuItem
      // 
      this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
      this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
      this.highScoresToolStripMenuItem.Text = "&High Scores";
      this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
      // 
      // rulesToolStripMenuItem
      // 
      this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
      this.rulesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
      this.rulesToolStripMenuItem.Text = "&Rules";
      this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // buttonLower
      // 
      this.buttonLower.Location = new System.Drawing.Point(12, 181);
      this.buttonLower.Name = "buttonLower";
      this.buttonLower.Size = new System.Drawing.Size(75, 23);
      this.buttonLower.TabIndex = 2;
      this.buttonLower.Text = "Lower";
      this.buttonLower.UseVisualStyleBackColor = true;
      this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
      // 
      // buttonHigher
      // 
      this.buttonHigher.Location = new System.Drawing.Point(12, 152);
      this.buttonHigher.Name = "buttonHigher";
      this.buttonHigher.Size = new System.Drawing.Size(75, 23);
      this.buttonHigher.TabIndex = 3;
      this.buttonHigher.Text = "Higher";
      this.buttonHigher.UseVisualStyleBackColor = true;
      this.buttonHigher.Click += new System.EventHandler(this.buttonHigher_Click);
      // 
      // labelScore
      // 
      this.labelScore.BackColor = System.Drawing.SystemColors.Window;
      this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.labelScore.Location = new System.Drawing.Point(320, 182);
      this.labelScore.Name = "labelScore";
      this.labelScore.Size = new System.Drawing.Size(75, 20);
      this.labelScore.TabIndex = 4;
      this.labelScore.Text = "90";
      this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // buttonPlay
      // 
      this.buttonPlay.Location = new System.Drawing.Point(320, 152);
      this.buttonPlay.Name = "buttonPlay";
      this.buttonPlay.Size = new System.Drawing.Size(75, 23);
      this.buttonPlay.TabIndex = 5;
      this.buttonPlay.Text = "Play Again";
      this.buttonPlay.UseVisualStyleBackColor = true;
      this.buttonPlay.Visible = false;
      this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.Window;
      this.label1.Location = new System.Drawing.Point(12, 131);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 18);
      this.label1.TabIndex = 6;
      this.label1.Text = "Next Card";
      this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.Window;
      this.label2.Location = new System.Drawing.Point(256, 182);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = "Credits :";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Green;
      this.ClientSize = new System.Drawing.Size(407, 216);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonPlay);
      this.Controls.Add(this.labelScore);
      this.Controls.Add(this.buttonHigher);
      this.Controls.Add(this.buttonLower);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HiLow";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Button buttonLower;
    private System.Windows.Forms.Button buttonHigher;
    private System.Windows.Forms.Label labelScore;
    private System.Windows.Forms.Button buttonPlay;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

