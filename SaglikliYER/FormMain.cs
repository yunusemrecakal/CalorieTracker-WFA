using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikliYER
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        int userID;
        public FormMain(int _userID)
        {
            InitializeComponent();
            userID = _userID;
        }

        private void btnDrinkWater_Click(object sender, EventArgs e)
        {
            FormSuEkleme suEkleme = new FormSuEkleme(userID);
            suEkleme.Owner = this;
            this.Hide();
            suEkleme.Show();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FormUrunEkleme urunEkleme = new FormUrunEkleme();
            urunEkleme.Owner = this;
            this.Hide();
            urunEkleme.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormKalHesaplama kalHesaplama = new FormKalHesaplama();
            kalHesaplama.Owner = this;
            this.Hide();
            kalHesaplama.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports reports = new FormReports(userID);
            reports.Owner = this;
            this.Hide();
            reports.Show();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            FormMeal meal = new FormMeal(userID);
            meal.Owner = this;
            this.Hide();
            meal.Show();
        }

        private void btnChallange_Click(object sender, EventArgs e)
        {
            FormChallange challange = new FormChallange(userID);
            challange.Owner = this;
            this.Hide();
            challange.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            FormNotification notification = new FormNotification(userID);
            notification.Owner = this;
            this.Hide();
            notification.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings(userID);
            formSettings.Owner = this;
            this.Hide();
            formSettings.Show();
        }

        private void btnOyun_Click(object sender, EventArgs e)
        {
            FormTicTacToe formTicTacToe = new FormTicTacToe();
            formTicTacToe.Owner = this;
            this.Hide();
            formTicTacToe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFeedMonster formFeedMonster = new FormFeedMonster();
            formFeedMonster.Owner = this;
            this.Hide();
            formFeedMonster.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
