using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanderingButton
{
    public partial class WanderingButtonForm : Form
    {
        public WanderingButtonForm()
        {
            InitializeComponent();
        }

        private void WanderingButtonForm_Load(object sender, EventArgs e)
        {
            PersonalizeFormWindow();
            AddButtonEventListners();
        }

        public void PersonalizeFormWindow()
        {
            Text = "Zadanie - Wandering Button";
            MaximizeBox = false;
        }

        public void AddButtonEventListners() {
            wanderingButton.Click += new EventHandler(WanderButtonHandler);
        }

        public void WanderButtonHandler(object sender, EventArgs e) {
            int newButtonX = GenerateRandomNumber(0, Width / 2);
            int newButtonY = GenerateRandomNumber(0, Height / 2);
            SetButtonPosition(newButtonX, newButtonY);
        }

        private void SetButtonPosition(int x, int y) {
            Point buttonLocationPoint = new Point(x, y);
            wanderingButton.Location = buttonLocationPoint;
        }

        private int GenerateRandomNumber(int min, int max) {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
