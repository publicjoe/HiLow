using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Publicjoe.Windows;
using Publicjoe.Windows.Cards;

namespace HiLow
{
  public partial class Form1 : Form
  {
    private Card cardDrawing;
    private Deck TheDeck;
    private int currentCard = 0;
    private bool winLose = true;
    private int credit = 90;
    private bool AddCredit = true;

    private HighScoreTable highScoreTable = new HighScoreTable();

    public Form1()
    {
      InitializeComponent();

      cardDrawing = new Card();
      cardDrawing.Begin(this.CreateGraphics());

      TheDeck = new Deck();
      TheDeck.Shuffle();

      // Load high score table...
      highScoreTable.Load(Application.StartupPath + @"\score.txt");
    }

    private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HighScoreForm HighScoreForm = new HighScoreForm(highScoreTable);
      HighScoreForm.StartPosition = FormStartPosition.CenterScreen;
      HighScoreForm.Show();
    }

    private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      (new RulesForm()).ShowDialog();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void CheckHighScore()
    {
      highScoreTable.Load(Application.StartupPath + @"\score.txt");

      int scoreIndex = highScoreTable.GetIndexOfScore(credit);

      if (scoreIndex > -1)
      {
        string name = "";
        using (EntryForm aForm = new EntryForm())
        {
          aForm.StartPosition = FormStartPosition.CenterScreen;

          if (aForm.ShowDialog() == DialogResult.OK)
          {
            name = aForm.textBox1.Text;

            highScoreTable.Update(name, credit);
          }
        }
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    { 
      for (int i = 0; i <= currentCard; i++)
      {
        cardDrawing.DrawCard(new Point((10 + (i * 80)), 34), TheDeck.GetCard(i));
      }

      for (int i = currentCard + 1; i < 5; i++)
      {
        cardDrawing.DrawCardBack(new Point((10 + (i * 80)), 34));
      }

      if (winLose == false)
      {
        buttonPlay.Visible = true;
      }
      else if (currentCard == 4)
      {
        buttonPlay.Visible = true;
        
        if (AddCredit == true)
        {
          credit += 20;
          AddCredit = false;
        }
        
        labelScore.Text = credit.ToString();
      }

      base.OnPaint(e);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonHigher_Click(object sender, EventArgs e)
    {
      if (winLose == true)
      {
        int prev = TheDeck.GetCard(currentCard);

        currentCard++;
        int cur = TheDeck.GetCard(currentCard);

        int curRank = (int)cardDrawing.RankFromCardIndex(cur);
        int prevRank = (int)cardDrawing.RankFromCardIndex(prev);

        if (curRank < prevRank)
        {
          winLose = false;
          MessageBox.Show("You Lost!");
        }

        if (currentCard == 4)
        {
          MessageBox.Show("You Won!");
        }

        Invalidate();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonLower_Click(object sender, EventArgs e)
    {
      if (winLose == true)
      {
        int prev = TheDeck.GetCard(currentCard);
        currentCard++;
        int cur = TheDeck.GetCard(currentCard);

        int curRank = (int)cardDrawing.RankFromCardIndex(cur);
        int prevRank = (int)cardDrawing.RankFromCardIndex(prev);

        if (curRank > prevRank)
        {
          winLose = false;
          MessageBox.Show("You Lost!");
        }

        if (currentCard == 4)
        {
          MessageBox.Show("You Won!");
        }

        Invalidate();
      }
    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
      credit -= 10;
      labelScore.Text = credit.ToString();
      currentCard = 0;
      winLose = true;

      TheDeck.Shuffle();
      buttonPlay.Visible = false;

      AddCredit = true;

      Invalidate();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      CheckHighScore();
      base.OnClosing(e);
    }
  }
}