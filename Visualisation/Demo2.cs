using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAnimation_NET5;

namespace Visualisation
{
    internal partial class Demo2 : UserControl
    {
        private readonly Animator2D _animator = new();

        public Demo2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pb_image.Parent = roomPictureBox;
            pb_image.BackColor = Color.Transparent;
            pb_image.BringToFront();
            _animator.Paths = PathVault.FromCouchToStart;
        }

        private void PlayButton(object sender, EventArgs e)
        {
            _animator.Play(pb_image, Animator2D.KnownProperties.Location);
        }

        private Task CatLifeCycle(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                
            }
            
            return Task.CompletedTask;
        }

        private void roomPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"{e.Location}");
        }
    }
}