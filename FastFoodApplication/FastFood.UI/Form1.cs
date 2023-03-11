using FastFood.Models;
using FastFood.Service;

namespace FastFood.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var resultBalance = await GlobalConfig.DataConnection.GetBalance();
            balanceLabel.Text = resultBalance.Balance.ToString();
        }
    }
}