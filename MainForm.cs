using Microsoft.Win32;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab8Var1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            originalDesktopBackgroundColorTextBox.Text = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors").GetValue("Background").ToString();
            var colors = originalDesktopBackgroundColorTextBox.Text.Split(" ").Select(int.Parse).ToList();
            originalColorPictureBox.BackColor = Color.FromArgb(colors[0], colors[1], colors[2]);
        }

        private void changeDesktopColorButton_Click(object sender, System.EventArgs e)
        {
            var newColorString = newDesktopBackgroundColorTextBox.Text;
            if (!IsColorStringValid(newColorString))
            {
                MessageBox.Show("Цвет должен быть введен в формате RGB");
                return;
            }
            SetDesktopBackgroundColor(newColorString);
            var colors = newColorString.Split(" ").Select(int.Parse).ToList();
            newColorPictureBox.BackColor = Color.FromArgb(colors[0], colors[1], colors[2]);
        }

        private bool IsColorStringValid(string colorString)
        {
            var words = colorString.Split(" ").ToList();
            return words.Count == 3 && words.All(word => int.TryParse(word, out var colorByte) && colorByte >= 0 && colorByte < 256);
        }

        private void SetDesktopBackgroundColor(string newColorString) =>
            Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true).SetValue("Background", newColorString);

        protected override void OnClosed(System.EventArgs e)
        {
            base.OnClosed(e);
            if (restoreOriginalColorCheckBox.Checked)
            {
                RestoreOriginalDesktopBackgroundColor();
            }
        }

        private void restoreOriginalDesktopBackgroundColorButton_Click(object sender, System.EventArgs e) => RestoreOriginalDesktopBackgroundColor();

        private void RestoreOriginalDesktopBackgroundColor() => SetDesktopBackgroundColor(originalDesktopBackgroundColorTextBox.Text);
    }
}

