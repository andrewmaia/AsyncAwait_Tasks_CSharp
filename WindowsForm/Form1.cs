using Biblioteca;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        PreparadorCafeManha p = new PreparadorCafeManha();
        public Form1()
        {
            InitializeComponent();
            p.GerouMensagem += PreparadorCafeManha_GerouMensagem;
        }

        private void PreparadorCafeManha_GerouMensagem(string mensagem)
        {
            GerarMensagem(mensagem);
        }

        private void GerarMensagem(string mensagem)
        {
            txtResultado.Text += $"{mensagem}{Environment.NewLine}";
        }

        private void btnPrepararSync_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            p.PrepareBreakfastSync();
        }

        private async void btnPrepararAsync_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            await p.PrepareBreakfastAsync();
        }
    }
}