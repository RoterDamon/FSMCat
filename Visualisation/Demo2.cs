﻿using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSMCat;
using WinFormAnimation_NET5;

namespace Visualisation
{
    internal partial class Demo2 : UserControl
    {
        private readonly Animator2D _animator = new();
        private Cat _cat;
        private static CancellationTokenSource _tokenSource = new();

        public Demo2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pb_image.Parent = roomPictureBox;
            pb_image.BackColor = Color.Transparent;
            pb_image.BringToFront();
            _animator.Paths = PathVault.FromCouchToStart;
            var tired = 6;
            var hungry = 10;
            var poop = 100;
            _cat = new Cat(tired, hungry, poop);
        }

        private async void PlayButton(object sender, EventArgs e)
        {
            if (btn_play.Text == @"Start")
            {
                btn_play.Text = @"Stop";
                _tokenSource.Dispose();
                _tokenSource = new CancellationTokenSource();
                await Task.Run(() => CatLifeCycle(_tokenSource.Token), _tokenSource.Token);
            }
            else
            {
                btn_play.Text = @"Start";
                _tokenSource.Cancel();
            }
        }

        private Task CatLifeCycle(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                _cat.Update();
                var currentState = _cat.GetState();
                var reversedPath = PathVault.StayStart;
                switch (currentState)
                {
                    case "Sleep":
                        _animator.Paths = PathVault.FromStartToCouch;
                        reversedPath = PathVault.FromCouchToEat;
                        break;
                    case "Poop":
                        _animator.Paths = PathVault.FromStartToPoop;
                        reversedPath = PathVault.FromPoopToStart;
                        break;
                    case "GoToKitchen":
                        _animator.Paths = PathVault.FromStartToDish;
                        reversedPath = PathVault.FromDishToStart;
                        break;
                    default:
                        _animator.Paths = PathVault.StayStart;
                        break;
                }
                
                SetText(currentState);
                _animator.Play(pb_image, Animator2D.KnownProperties.Location);
                Thread.Sleep(1500);
                _animator.Paths = reversedPath;
            }
            
            return Task.CompletedTask;
        }
        
        private delegate void SetTextCallback(string text);
        
        private void SetText(string text)
        {
            if (stateBox.InvokeRequired)
            { 
                var d = new SetTextCallback(SetText);
                Invoke(d, text);
            }
            else
            {
                stateBox.Text = text;
            }
        }

        private void roomPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"{e.Location}");
        }
    }
}