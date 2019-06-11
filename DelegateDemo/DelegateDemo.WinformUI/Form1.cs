using DelegateDemo.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateDemo.WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _zealot = new Zealot();
            _zealot.NoShield += Zealot_NoShield;
        }

        private Zealot _zealot;

        private void Zealot_NoShield(object sender, Zealot.NoShieldEventArgs e)
        {
            Text = $"damage : {e.Damage}, hp = {e.HP}";

            txtHP.BackColor = Color.Yellow;
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            _zealot.GetAttacked();

            txtHP.Text = _zealot.HP.ToString();

            if (_zealot.HP <= 0)
                txtHP.BackColor = Color.Red;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = DateTime.Now.ToString();
        }
    }
}
