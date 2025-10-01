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
        int gap = 150;            // ku�un ge�ece�i bo�luk
        int pipeSpeed = 8;        // borular�n hareket h�z�
        int gravity = 5;          // yer�ekimi etkisi
        int score = 0;            // skor
        bool isGameOver = false;  // oyun durumu


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // klavye eventlerini yakalayabilmek i�in
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                bird.Top += gravity; // ku�un d�����

                pipeBottom.Left -= pipeSpeed; // borular�n hareketi
                pipeTop.Left -= pipeSpeed;    // borular�n hareketi

                ScoreText.Text = "Score: " + score; // skoru g�ncelle

                // borular ekran d���na ��k�nca yeniden konumland�r
                if (pipeBottom.Left < -80)
                {
                    pipeBottom.Left = 800;  // boruyu tekrar sa�a al
                    pipeTop.Left = 800;     // boruyu tekrar sa�a al
                    score++;                // skoru art�r
                    if (score % 5 == 0 && pipeSpeed < 20)
                    {
                        pipeSpeed++; // her 5 skor art���nda boru h�z�n� art�r
                    }
                    placePipes();           // borular� yeni konuma yerle�tir
                }

                // �arp��ma kontrol�
                if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    bird.Bounds.IntersectsWith(ground1.Bounds) ||
                    bird.Top < -15)
                {
                    endGame(); // �arp��ma varsa oyunu bitir
                }
            }
        }

        private void placePipes()
        {
            int topPipeBottom = random.Next(20, 275);       //alt borunun en �st noktas�
            pipeTop.Top = topPipeBottom - pipeTop.Height;   // �st borunun konumu
            pipeBottom.Top = topPipeBottom + gap;           // alt borunun konumu
        }

        // space tu�una bas�l�nca ve b�rak�l�nca
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (isGameOver)
                {
                    restartGame(); // oyun bitti ise yeniden ba�lat
                }
                else
                {
                    gravity = 5; // normal d����
                }
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isGameOver)
            {
                gravity = -12; // ku� z�plar
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
            // ku�u ba�lang�� konumuna getir
            bird.Top = 150;

            // borular� ba�lang�� konumuna getir
            pipeBottom.Left = 800;
            pipeTop.Left = 800;
            placePipes();

            // skor ve durum s�f�rla
            score = 0;
            isGameOver = false;
            ScoreText.Text = "Score: 0";
            gravity = 5;
            pipeSpeed = 8;

            // timer'� tekrar ba�lat
            gameTimer.Start();
        }
    }
}
