using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdWinForms
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; 
        int gravity = 1;
        int score = 0;
        int highScore = 0;
        
        int animatieTracker = 0;
        int birdVelocity = 0;
        int jumpStrength = -12;

        bool spacePressed = false;
        bool jocInceput = false;
        int directiePlutire = 2;
        int limitaPlutire = 0;

        bool punctAdaugat = false;

        System.Media.SoundPlayer sunetSari;
        System.Media.SoundPlayer sunetPunct;
        System.Media.SoundPlayer sunetLovitura;

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            highScore = Properties.Settings.Default.HighScore;


            sunetSari = new System.Media.SoundPlayer(Properties.Resources.sari);
            sunetPunct = new System.Media.SoundPlayer(Properties.Resources.punct);
            sunetLovitura = new System.Media.SoundPlayer(Properties.Resources.lovitura);

            PozitioneazaTeviRandom();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //ALEGEM CADRUL PENTRU ANIMAȚIE
            Image frameCurent = Properties.Resources.aripasus; // Default
            animatieTracker++;

            if (animatieTracker <= 3)
            {
                frameCurent = Properties.Resources.aripasus;
            }
            else
            {
                frameCurent = Properties.Resources.aripajos;
            }

            if (animatieTracker > 6)
            {
                animatieTracker = 0;
            }

            float unghiRotire = 0; // Unghiul la care vom înclina pasărea

            //VERIFICARE STAREA JOCULUI
            if (jocInceput == false)
            {
                //PLUTIREA (HOVER)
                unghiRotire = 0;
                limitaPlutire++;
                pictureBoxBird.Top += directiePlutire;

                if (limitaPlutire > 10)
                {
                    directiePlutire = -directiePlutire;
                    limitaPlutire = 0;
                }
            }
            else
            {
                //FIZICĂ ȘI ROTIRE

                // Calculăm cât de mult se înclină în funcție de viteză
                if (birdVelocity < 0)
                {
                    unghiRotire = -25; 
                }
                else
                {
                    unghiRotire = birdVelocity * 4;
                    if (unghiRotire > 90)
                    {
                        unghiRotire = 90;
                    }
                }

                // Aplicăm gravitația
                if (birdVelocity < 15)
                {
                    birdVelocity += gravity;
                }
                pictureBoxBird.Top += birdVelocity;

                // Mișcăm țevile
                pictureBoxPipeBottom.Left -= pipeSpeed;
                pictureBoxPipeTop.Left -= pipeSpeed;

                labelScore.Text = "Scor: " + score + " | Max: " + highScore;

                
                if (pictureBoxPipeBottom.Right < pictureBoxBird.Left && punctAdaugat == false)
                {
                    score++;
                    sunetPunct.Play(); 
                    punctAdaugat = true;

                    
                    if (score % 5 == 0 && pipeSpeed < 20)
                    {
                        pipeSpeed += 2;
                    }
                }

                // Regenerare tevi
                if (pictureBoxPipeBottom.Left < -80)
                {
                    PozitioneazaTeviRandom();
                }

                // Coliziunile
                if (pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeBottom.Bounds) ||
                    pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeTop.Bounds) ||
                    pictureBoxBird.Bounds.IntersectsWith(pictureBoxGround.Bounds) ||
                    pictureBoxBird.Top < -25)
                {
                    sunetLovitura.Play();
                    EndGame();
                }
            }

            //4. APLICĂM ROTIREA
            Image pozaVeche = pictureBoxBird.Image;

            pictureBoxBird.Image = RotesteImagine(frameCurent, unghiRotire);

            // Șterge poza veche
            if (pozaVeche != null)
            {
                pozaVeche.Dispose();
            }
        }
        private void EndGame()
        {
            gameTimer.Stop();

            if (score > highScore)
            {
                highScore = score;
                Properties.Settings.Default.HighScore = highScore;
                Properties.Settings.Default.Save();
            }

            labelScore.Text = "Scor final: " + score + " | Max: " + highScore;
            buttonRestart.Visible = true;
        }
        private void ResetGame()
        {
            // Resetăm poziția păsării
            pictureBoxBird.Top = 200;

            // Generăm un nou set de țevi
            PozitioneazaTeviRandom();

            // Resetăm fizica și blocajul tastei
            birdVelocity = 0;
            spacePressed = false;

            // Trecem jocul înapoi în modul de așteptare/plutire
            jocInceput = false;

            // Resetăm scorul și dificultatea
            score = 0;
            pipeSpeed = 8;
            labelScore.Text = "Scor: " + score + " | Max: " + highScore;

            // Ascundem butonul de restart și dăm focus ferestrei
            buttonRestart.Visible = false;
            this.Focus();

            // Repornim timerul
            gameTimer.Start();
        }
        private void PozitioneazaTeviRandom()
        { 
            pictureBoxPipeTop.Left = 400;
            pictureBoxPipeBottom.Left = 400;

            // Setăm o înălțime random pentru țeava de sus
            pictureBoxPipeTop.Height = rand.Next(50, 250);

            int spatiuLiber = 140;

            // Țeava de jos
            pictureBoxPipeBottom.Top = pictureBoxPipeTop.Height + spatiuLiber;

            // Ajustare teava de jos pana la podea
            pictureBoxPipeBottom.Height = 600 - pictureBoxPipeBottom.Top;
            punctAdaugat = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Săritura
            if (e.KeyCode == Keys.Space && spacePressed == false)
            {
                spacePressed = true;

                if (jocInceput == false)
                {
                    jocInceput = true;
                }

                birdVelocity = jumpStrength;    
                sunetSari.Play();

            }

            // Pauză și Reluare la apăsarea tastei P
            if (e.KeyCode == Keys.P)
            {
                if (buttonRestart.Visible == false)
                {
                    if (gameTimer.Enabled)
                    {
                        gameTimer.Stop();
                        labelScore.Text += " [PAUZĂ]";
                    }
                    else
                    {
                        gameTimer.Start();
                        labelScore.Text = "Scor: " + score + " | Max: " + highScore;
                    }
                }
            }
            if (e.KeyCode == Keys.L)
            {
                highScore = 0;
                Properties.Settings.Default.HighScore = 0;
                Properties.Settings.Default.Save();

                labelScore.Text = "Scor: " + score + " | Max: " + highScore;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                spacePressed = false;
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private Image RotesteImagine(Image img, float angle)
        {
            
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2); 
                g.RotateTransform(angle);                                          
                g.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2); 
                g.DrawImage(img, new Point(0, 0));                                 
            }
            return bmp;
        }
    }
}
