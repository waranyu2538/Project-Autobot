using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Threading;


namespace Autobot
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        AutoItX3 Autobot1 = new AutoItX3();

        string Programe;
        public int C1 = 0;
        public int C2 = 0;
        public int C3 = 0;
        public int C4 = 0;
        public int C5 = 0;
        public int C6 = 0;
        public int C7 = 0;

        void Lc(string GameTitle, int X, int Y)
        {
            Autobot1.ControlClick(GameTitle, "", "", "LEFT", 1, X, Y);
        }


        bool EzSearch(int X, int Y, int Rect, int Color, int Shade)
        {
            Autobot1.PixelSearch(X - Rect, Y - Rect, X + Rect, Y + Rect, Color, Shade);

            if (Autobot1.error == 0)
            {
                //Console.WriteLine("X = " + X + " :Y = " + Y + " :Color = 0x" + Color.ToString("X") + " / true");
                return true;
            }

            // Console.WriteLine("X = " + X + " :Y = " + Y + " :Color = 0x" + Color.ToString("X") + " / false");
            return false;
        }

        void Quest_Start()
        {
            if (!EzSearch(170, 410, 4, 0xFBFBFB, 4) || (!EzSearch(172, 410, 4, 0xFBFBFB, 4)))
            //if (!EzSearch(75, 431, 4, 0x090909, 4) || (!EzSearch(316, 426, 4, 0x080808, 4)))
            {
                if (EzSearch(13, 202, 8, 0x6D2B81, 10) || (EzSearch(9, 206, 8, 0x9C3EB8, 10)))
                //if (EzSearch(9, 195, 4, 0x8D38A6, 4) || (EzSearch(9, 197, 4, 0x8D38A6, 4)))
                {
                    if(EzSearch(8, 201, 4, 0x311639, 4) || (EzSearch(9, 202, 4, 0x8D38A6, 4)))
                    //if (EzSearch(16, 198, 4, 0xB34CD3, 4) || (EzSearch(16, 199, 4, 0xAD48CB, 4)))
                    {
                        Console.WriteLine("step 1 QuestF");
                        Lc(Programe, 49, 202);
                        Thread.Sleep(1000);
                    }
                }
                // else if (EzSearch(9, 239, 8, 0x8D38A6, 4) && (EzSearch(9, 241, 8, 0x8D38A6, 4)))
                // {
                // if (EzSearch(9, 242, 8, 0x8D38A6, 4) || (EzSearch(10, 244, 4, 0x5D256D, 4)))
                //  {
                //   Thread.Sleep(2000);
                //   Console.WriteLine("step 1 QuestT");
                //  Lc(Programe, 53, 249);
                //  Thread.Sleep(1000);

                //   Skip_Quest();
                // }
                //}
            }
        }

        void Skip_Quest()
        {
            if (EzSearch(75, 431, 8, 0x050400, 4) || (EzSearch(316, 426, 8, 0x040301, 4) || (EzSearch(472, 419, 8, 0x040200, 4)) && (EzSearch(647, 92, 8, 0xFFFFFF, 4))))
            {
                if (EzSearch(36, 89, 8, 0xFFFFFF, 4) || (EzSearch(37, 96, 8, 0xFFFFFF, 4)))
                {
                    if (EzSearch(60, 93, 8, 0xFFFFFF, 4) || (EzSearch(75, 9, 8, 0xFFFFFF, 4)))
                    {
                        Console.WriteLine("step 2 Skips");
                        Lc(Programe, 69, 93);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        void Accept_Quest()
          {
              if (EzSearch(75, 431, 8, 0x050400, 4) || (EzSearch(316, 426, 8, 0x040301, 4) || (EzSearch(472, 419, 8, 0x040200, 4)) && (EzSearch(647, 92, 8, 0xFFFFFF, 4))))
              //if (EzSearch(75, 431, 8, 0x050400, 4) && (EzSearch(316, 426, 8, 0x040301, 4) && (EzSearch(472, 419, 8, 0x040200, 4))))
              {
                  if (EzSearch(552, 404, 8, 0xFF7B50, 4) && (EzSearch(633, 404, 8, 0xFB794F, 4)))
                  {
                      Console.WriteLine("step 3 Accept");
                      Lc(Programe, 601, 406);
                      Thread.Sleep(1000);
                  }
              }
          }

          void Claim_Quest()
          {
              if(EzSearch(198, 90, 8, 0x515F6E, 4) && (EzSearch(445, 98, 8, 0x515F6E, 4)))
              {
                  if (EzSearch(282, 401, 8, 0xFF7B50, 4) || (EzSearch(278, 413, 8, 0xFF7B50, 4)))
                  {
                      if (EzSearch(394, 393, 8, 0xFF7B50, 4) || (EzSearch(395, 415, 8, 0xFF7B50, 4)))
                      {
                          Console.WriteLine("step 4 Claim");
                          Lc(Programe, 337, 404);
                          Thread.Sleep(1000);
                      }
                  }
              }
          }

        private void BStart_Click(object sender, EventArgs e)
        {
            Autobot1.AutoItSetOption("CaretCoordMode", 2);
            Autobot1.AutoItSetOption("MouseCoordMode", 2);
            Autobot1.AutoItSetOption("PixelCoordMode", 2);

            Programe = TName.Text;

            Autobot1.WinGetHandle(Programe);
            Autobot1.WinActivate(Programe);

            Console.WriteLine(EzSearch(544, 234, 8, 0xF57E29, 4));


           // if (Autobot1.WinActive(Programe) == 1)
            //{
                LStatus1.Text = Programe + " ทำงาน !!";
                Autobot1.WinMove(Programe, "", 0, 0, 680, 480);

                Console.WriteLine("เริ่มเเล้วนะ");

                if (!BGWorker1.IsBusy)
                    BGWorker1.RunWorkerAsync();

                    LB2.Text = "เริ่มเเล้วนะ !!";
           // }
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            if (!BGWorker1.IsBusy)
                BGWorker1.CancelAsync();

            Console.WriteLine("หยุดอยู่");
            LB2.Text = "หยุดเเล้วนะ !!";
        }

        private void BGWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Programe = TName.Text;
            Autobot1.WinActive(Programe);

            while (true)
            {
                while (true)
                {
                    Quest_Start();

                    if (EzSearch(163, 348, 4, 0xFF7B50, 8) && (EzSearch(216, 354, 4, 0xFF7B50, 8)))
                    {
                        if (EzSearch(647, 92, 4, 0xFFFFFF, 8) && (EzSearch(649, 92, 4, 0xFFFFFF, 8)))
                        {
                            Console.WriteLine("Quest ซ้อน !!");
                            Lc(Programe, 186, 350);
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    Skip_Quest();

                    Accept_Quest();

                    if (EzSearch(163, 346, 4, 0x59B0A8, 8) && (EzSearch(216, 357, 4, 0x59B0A8, 8)))
                    {
                        if (EzSearch(647, 92, 4, 0xFFFFFF, 8) && (EzSearch(649, 92, 4, 0xFFFFFF, 8)))
                        {
                            Console.WriteLine("Accept Quest ซ้อน !!");
                            Lc(Programe, 189, 351);
                            Thread.Sleep(1000);
                        }
                    }

                    Claim_Quest();
                    break;
                }
            }
            if (BGWorker1.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
        
        
        }

        
    }
}
//}


