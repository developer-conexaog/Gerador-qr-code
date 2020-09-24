//Install-Package ZXing.Net 
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Gerando_QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerarQRCode_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == string.Empty || txtLargura.Text == string.Empty && txtLargura.Text == string.Empty)
            {
                MessageBox.Show("Informações inválidas. Complete as informações para gerar o QRCode...");
                txtTexto.Focus();
                return;
            }

            try
            {
                int largura = Convert.ToInt32(txtLargura.Text);
                int altura = Convert.ToInt32(txtAltura.Text);
                int inicial = Convert.ToInt32(textInicial.Text);
                int final = Convert.ToInt32(textfinal.Text);
                string path = txtPath.Text;

                for (int cont = inicial; cont <= final; cont++)
                {
                    string value = cont.ToString();
                    if (cont < 10)
                    {
                        value = "0" + cont.ToString();
                    }

                    picQRCode.Image = GerarQRCode(largura, altura, txtTexto.Text + "/" + value);

                    if (!Directory.Exists(path))
                    {

                        DirectoryInfo di = Directory.CreateDirectory(path);
                        MessageBox.Show("Diretório Criado {0}.", di.FullName);
                    }
                    picQRCode.Image.Save(path + value + ".jpg", ImageFormat.Jpeg);
                }

                MessageBox.Show("QrCodes Gerados com sucesso! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Bitmap Converte_Texto_Para_Imagem(Bitmap bmp, string txt, string fontname, int fontsize,int txtEspacamento)
        {
            try
            {
                int height = bmp.Height;
                //cria a imagem bitmap                
                //O método FromImage cria um novo Graphics a partir da imagem definida
                Graphics graphics = Graphics.FromImage(bmp);
                // Cria um objeto Font para desenhar o texto da imagem
                Font font = new Font(fontname, fontsize);
                // Instancia o objeto Bitmap imagem novamente com o tamanho correto para o texto e fonte
                SizeF stringSize = graphics.MeasureString(txt, font);
                bmp = new Bitmap(bmp, (int)stringSize.Height + bmp.Width, (int)stringSize.Height + bmp.Height);
                graphics = Graphics.FromImage(bmp);
                // Aqui temos uma outra possibilidade
                // bmp = new Bitmap(bmp, new Size((int)graphics.MeasureString(txt, font).Width, (int)graphics.MeasureString(txt, font).Height));
                //Desenha o texto com o formato definido
                graphics.DrawString(txt, font, Brushes.Black, txtEspacamento, height + 5) ;
                font.Dispose();
                graphics.Flush();
                graphics.Dispose();
                return bmp;
            }
            catch
            {
                throw;
            }
        }

        public Bitmap GerarQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 2 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(text));

                resultado = Converte_Texto_Para_Imagem(resultado, text, "Arial", Convert.ToInt32(txtFonte.Text), Convert.ToInt32(txtEspacamento.Text));

                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
