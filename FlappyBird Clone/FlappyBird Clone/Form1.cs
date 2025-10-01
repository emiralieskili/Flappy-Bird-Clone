using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Clone
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int gap = 150;            // kuþun geçeceði boþluk
        int pipeSpeed = 8;        // borularýn hareket hýzý
        int gravity = 5;          // yerçekimi etkisi
        int score = 0;            // skor
        bool isGameOver = false;  // oyun durumu


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // klavye eventlerini yakalayabilmek için
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                bird.Top += gravity; // kuþun düþüþü

                pipeBottom.Left -= pipeSpeed; // borularýn hareketi
                pipeTop.Left -= pipeSpeed;    // borularýn hareketi

                ScoreText.Text = "Score: " + score; // skoru güncelle

                // borular ekran dýþýna çýkýnca yeniden konumlandýr
                if (pipeBottom.Left < -80)
                {
                    pipeBottom.Left = 800;  // boruyu tekrar saða al
                    pipeTop.Left = 800;     // boruyu tekrar saða al
                    score++;                // skoru artýr
                    if (score % 5 == 0 && pipeSpeed < 20)
                    {
                        pipeSpeed++; // her 5 skor artýþýnda boru hýzýný artýr
                    }
                    placePipes();           // borularý yeni konuma yerleþtir
                }

                // çarpýþma kontrolü
                if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    bird.Bounds.IntersectsWith(ground1.Bounds) ||
                    bird.Top < -15)
                {
                    endGame(); // çarpýþma varsa oyunu bitir
                }
            }
        }

        private void placePipes()
        {
            int topPipeBottom = random.Next(20, 275);       //alt borunun en üst noktasý
            pipeTop.Top = topPipeBottom - pipeTop.Height;   // üst borunun konumu
            pipeBottom.Top = topPipeBottom + gap;           // alt borunun konumu
        }

        // space tuþuna basýlýnca ve býrakýlýnca
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (isGameOver)
                {
                    restartGame(); // oyun bitti ise yeniden baþlat
                }
                else
                {
                    gravity = 5; // normal düþüþ
                }
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isGameOver)
            {
                gravity = -12; // kuþ zýplar
            }
        }
        // oyunu bitir
        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text += "  Game Over!!!";
            isGameOver = true;
        }
        private void restartGame()
        {
            // kuþu baþlangýç konumuna getir
            bird.Top = 150;

            // borularý baþlangýç konumuna getir
            pipeBottom.Left = 800;
            pipeTop.Left = 800;
            placePipes();

            // skor ve durum sýfýrla
            score = 0;
            isGameOver = false;
            ScoreText.Text = "Score: 0";
            gravity = 5;
            pipeSpeed = 8;

            // timer'ý tekrar baþlat
            gameTimer.Start();
        }
    }
}
