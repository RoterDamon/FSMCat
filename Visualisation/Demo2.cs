using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSMCat;
using Visualisation.Properties;
using WinFormAnimation_NET5;

namespace Visualisation
{
    internal partial class Demo2 : UserControl
    {
        private readonly Animator2D _animator = new();
        private readonly SoundPlayer _meowSound = new(Resources.CatMeow);
        private static CancellationTokenSource _tokenSource = new();
        private static string _previousState = "";
        private Cat _cat;

        public Demo2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            yaePictureBox.Parent = roomPictureBox;
            yaePictureBox.BackColor = Color.Transparent;
            yaePictureBox.BringToFront();
            pb_image.Parent = roomPictureBox;
            pb_image.BackColor = Color.Transparent;
            pb_image.BringToFront();
            _animator.Paths = PathVault.FromCouchToStart;
            var tired = 6;
            var hungry = 10;
            var poop = 100;
            _cat = new Cat(tired, hungry, poop);
            roomPictureBox.Image = _cat.GetFood() ? Resources.RoomWithFood : Resources.RoomWithoutFood;
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

                if (_previousState == "Meow" && currentState == "GoToKitchen")
                {
                    AnimateYae();
                }
                SetText(currentState);
                AnimateCat(currentState);
                _previousState = currentState;
            }
            
            return Task.CompletedTask;
        }

        private void AnimateYae()
        {
            _animator.Paths = PathVault.FromYaeToDish;
            var reversedPath = PathVault.FromDishToYae;
            _animator.Play(yaePictureBox, Animator2D.KnownProperties.Location);
            Thread.Sleep(1500);
            roomPictureBox.Image = Resources.RoomWithFood;
            _animator.Paths = reversedPath;
            _animator.Play(yaePictureBox, Animator2D.KnownProperties.Location);
            Thread.Sleep(1500);
        }

        private void AnimateCat(string currentState)
        {
            Image image = Resources.Cat;
            var reversedPath = PathVault.StayStart;

            switch (currentState)
            {
                case "Sleep":
                    _animator.Paths = PathVault.FromStartToCouch;
                    reversedPath = PathVault.FromCouchToStart;
                    image = Resources.CatSleep;
                    break;
                case "Poop":
                    _animator.Paths = PathVault.FromStartToPoop;
                    reversedPath = PathVault.FromPoopToStart;
                    break;
                case "Eat":
                    _animator.Paths = PathVault.StayDish;
                    reversedPath = PathVault.FromDishToStart;
                    roomPictureBox.Image = Resources.RoomWithoutFood;
                    break;
                case "GoToKitchen":
                    _animator.Paths = PathVault.FromStartToDish;
                    reversedPath = _cat.GetFood() ? PathVault.StayDish : PathVault.FromDishToStart;
                    break;
                case "Play":
                    image = Resources.CatPlay;
                    break;
                case "Search":
                    _animator.Paths = PathVault.FromStartToYae;
                    reversedPath = PathVault.StayYae;
                    break;
                case "Meow":
                    _meowSound.Play();
                    _animator.Paths = PathVault.StayYae;
                    reversedPath = PathVault.FromYaeToStart;
                    break;
                default:
                    _animator.Paths = PathVault.StayStart;
                    break;
            }
            
            _animator.Play(pb_image, Animator2D.KnownProperties.Location);
            Thread.Sleep(1500);
            pb_image.Image = image;
            Thread.Sleep(1500);
            pb_image.Image = Resources.Cat;
            _animator.Paths = reversedPath;
            _animator.Play(pb_image, Animator2D.KnownProperties.Location);
            Thread.Sleep(1500);
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
            MessageBox.Show($@"{e.Location}");
        }
    }
}