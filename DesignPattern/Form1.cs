using System;
using System.Windows.Forms;

namespace DesignPattern
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        #region FactoryMethodPattern
        private void b_FactoryMethodPattern_Click(object sender, EventArgs e)
        {
            tb_Pattern.Text += $"<< FactoryMethodPattern >>\r\n";
            var product = Pattern_FactoryMethod_工廠方法模式.Complex.FromPolarFactory(1, Math.PI/2);
            tb_Pattern.Text += $"Real : {product.Real}, Imaginary : {product.Imaginary}\r\n";
        }
        #endregion

        #region StrategyPattern
        private void b_StrategyPattern_Click(object sender, EventArgs e)
        {
            tb_Pattern.Text += $"<< StrategyPattern >>\r\n";
            MovieTicket movieTicket = new MovieTicket(100);
            SetDesign(movieTicket, ChildDiscount.Name);
            SetDesign(movieTicket, StudentDiscount.Name);
            SetDesign(movieTicket, VIPDiscount.Name);
        }

        private void SetDesign(MovieTicket movieTicket,string name)
        {
            movieTicket.SetDiscount(name);
            tb_Pattern.Text += $"{name} : {movieTicket.Calculate()}\r\n";
        }
        #endregion
    }
}
