using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRightDesktopUI.ViewModels
{
    public class GameViewModel : Screen
    {
       
        public GameViewModel()
        {
            Player1Text = "3 tokens Assigned";
            Player2Text = "3 tokens Assigned";
            Player3Text = "3 tokens Assigned";
            Player4Text = "3 tokens Assigned";
        }

        private string _dice1;

        public string Dice1
        {
            get { return _dice1; }
            set
            {
                _dice1 = value;
                NotifyOfPropertyChange(() => Dice1);
            }
        }

        private string _dice2;

        public string Dice2
        {
            get { return _dice2; }
            set
            {
                _dice2 = value;
                NotifyOfPropertyChange(() => Dice2);
            }
        }

        private string _dice3;

        public string Dice3
        {
            get { return _dice3; }
            set
            {
                _dice3 = value;
                NotifyOfPropertyChange(() => Dice3);
            }
        }

        private Int32 _token1;

        public Int32 Token1
        {
            get { return _token1; }
            set
            {
                _token1 = value;
                NotifyOfPropertyChange(() => Token1);
            }
        }

        private Int32 _token2;

        public Int32 Token2
        {
            get { return _token2; }
            set
            {
                _token2 = value;
                NotifyOfPropertyChange(() => Token2);
            }
        }

        private Int32 _token3;

        public Int32 Token3
        {
            get { return _token3; }
            set
            {
                _token3 = value;
                NotifyOfPropertyChange(() => Token3);
            }
        }


        private string _player1Text;

        public string Player1Text
        {
            get { return _player1Text; }
            set
            {
                _player1Text = value;
                NotifyOfPropertyChange(() => Player1Text);
            }
        }

        private string _player2Text;

        public string Player2Text
        {
            get { return _player2Text; }
            set {
                _player2Text = value;
                NotifyOfPropertyChange(() => Player2Text);
            }
        }

        private string _player3Text;

        public string Player3Text
        {
            get { return _player3Text; }
            set {
                _player3Text = value;
                NotifyOfPropertyChange(() => Player3Text);
            }
        }

        private string _player4Text;

        public string Player4Text
        {
            get { return _player4Text; }
            set {
                _player4Text = value;
                NotifyOfPropertyChange(() => Player4Text);
            }
        }

        private string _centerText;

        public string CenterText
        {
            get { return _centerText; }
            set
            {
                _centerText = value;
                NotifyOfPropertyChange(() => CenterText);
            }
        }


        public bool CanPlayer1()
        {
            return true;
        }
        public void Player1()
        {
            Random random = new Random();
            int dice1= random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            Player1Text = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();
            CenterText = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();

        }

        public bool CanPlayer2()
        {
            return true;
        }
        public void Player2()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            Player2Text = "Dice1= "  + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();
            CenterText = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();
        }

        public bool CanPlayer3()
        {
            return true;
        }
        public void Player3()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            Player3Text = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();
            CenterText = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();

        }

        public bool CanPlayer4()
        {
            return true;
        }
        public void Player4()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            Player4Text = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();
            CenterText = "Dice1= " + dice1.ToString() + " Dice2= " + dice2.ToString() + " Dice3= " + dice3.ToString();

        }

    }
}
