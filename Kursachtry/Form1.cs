using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Kursachtry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Array currArray = Enum.GetValues(typeof(Currency));
            foreach (Currency elem in currArray)
                PrimaryRole.Items.Add(elem);

            Array rateArray = Enum.GetValues(typeof(Rating));
            foreach (Rating elem in currArray)
                PrimaryRole.Items.Add(elem);
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            WinRate.MaxLength = 3;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Анкеты игрока|*.gaben" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = Serialization.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Анкеты игрока|*.gaben" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
                Serialization.WriteToFile(sfd.FileName, dto);
            }
        }

        SmthAboutPlayer GetModelFromUI()
        {
            var player = new SmthAboutPlayer();
            player.FullName = FullName.Text;
            player.NickName = NickName.Text;
            player.PlayerID = double.Parse(PlayerID.Text);
            player.SignatureHero = SignatureHero.Text;
            player.WinRate = double.Parse(WinRate.Text);
            player.PrimaryRole = new List<Currency>();
            foreach (Currency elem in PrimaryRole.CheckedItems)
                player.PrimaryRole.Add(elem);
            player.SoloRating = (Rating)RatingSolo.SelectedIndex;
            player.RateStars = RateStars.SelectedIndex;
            return player;
        }
        private void SetModelToUI(SmthAboutPlayer player)
        {
            FullName.Text = player.FullName;
            NickName.Text = player.NickName;
            PlayerID.Text = player.PlayerID.ToString();
            SignatureHero.Text = player.SignatureHero;
            WinRate.Text=player.WinRate.ToString();
            for(int i =0; i< 5; i++)
                PrimaryRole.SetItemChecked(i, false);
            foreach (int elem in player.PrimaryRole)
                PrimaryRole.SetItemChecked(elem, true);
            RatingSolo.SelectedIndex = (int)player.SoloRating;
            RateStars.SelectedIndex = player.RateStars;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

