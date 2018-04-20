using System.Linq;
using System.Web.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assinatura.Models;

namespace Assinatura.Controllers
{
    public class HomeController : Controller
    {
        UploadFileResult oModelArquivos = new UploadFileResult();
        Empresa emp = new Empresa();

        public ActionResult Index()
        {
            Deletar();

            //Carrega o DropDownlist para ser selecionada na proxima pagina chamada
            ViewBag.CodEmpresa = new SelectList
               (
                   new Empresa().ListaEmpresas(),
                   "CodEmpresa",
                   "NomeEmpresa"
               );

            return View();
        }

        [HttpPost]
        public FileResult GerarAssinatura(FormCollection form)
        {
            //Carrega o DropDownlist para ser selecionada na proxima pagina chamada
            ViewBag.CodEmpresa = new SelectList
               (
                   new Empresa().ListaEmpresas(),
                   "CodEmpresa",
                   "NomeEmpresa"
               );

            //List<Empresa> lista = emp.ListaEmpresas();
            string endereco = string.Empty;
            string endereco2 = string.Empty;
            string site = string.Empty;
            string nomeEmpresa = string.Empty;

            string nome = form.Get("txtNome");
            string email = form.Get("txtEmail");
            string telefone = form.Get("txtTelefone");
            string celular = form.Get("txtCelular");
            string cargo = form.Get("txtDep");
            string empresa = form.Get("CodEmpresa");

            //Valores: Largura e Altura
            Bitmap imagem = new Bitmap(500, 286);

            Graphics g = Graphics.FromImage(imagem);

            //g.FillRectangle(Brushes.Black, 0, 0, 300, 200);
            //g.DrawRectangle(Pens.White, 5, 5, 290, 190);

            //float tamanho = (float)9.5;


            Font font = new Font("CorpoS", 11, FontStyle.Bold);
            Font font2 = new Font("CorpoS", 10, FontStyle.Regular);

            System.Drawing.Image icone;

            if (empresa == "3140")
            {
                icone = System.Drawing.Image.FromFile(Server.MapPath("~/Imagens/Logos/logo_moc.jpg"));
            }
            else
            {
                icone = System.Drawing.Image.FromFile(Server.MapPath("~/Imagens/Logos/logo.jpg"));
            }       

            g.DrawImageUnscaled(icone, 0, 0);

            g.DrawString(nome, font, Brushes.Black, 117, 1);

            if (cargo != string.Empty)
            {
                g.DrawString(cargo, font, Brushes.Black, 117, 20);
            }

            g.DrawString(email, font2, Brushes.Black, 117, 60);

            switch (empresa)
            {
                case "1200":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "262":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "930":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "2630":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "2630F":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "3140":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "2890":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "130":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "2620":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "2620F":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "260":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "3610":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                case "666":

                    endereco = (from end in emp.ListaEmpresas()
                                where end.CodEmpresa == empresa
                                select end.Endereco).First();

                    endereco2 = (from end in emp.ListaEmpresas()
                                 where end.CodEmpresa == empresa
                                 select end.Endereco2).First();

                    nomeEmpresa = (from nomeCom in emp.ListaEmpresas()
                                   where nomeCom.CodEmpresa == empresa
                                   select nomeCom.NomeCompleto).First();

                    site = (from end in emp.ListaEmpresas()
                            where end.CodEmpresa == empresa
                            select end.Site).First();

                    g.DrawString(nomeEmpresa, font, Brushes.Black, 117, 40);

                    g.DrawString(endereco, font2, Brushes.Black, 117, 75);
                    g.DrawString(endereco2, font2, Brushes.Black, 117, 90);

                    break;

                default:
                    endereco = " ";
                    endereco2 = " ";
                    site = " ";
                    nomeEmpresa = " ";
                    break;
            }

            g.DrawString("Tel: " + telefone, font2, Brushes.Black, 117, 105);

            if (celular != string.Empty)
            {
                g.DrawString("Cel: " + celular, font2, Brushes.Black, 220, 105);
            }

            g.DrawString(site, font2, Brushes.Black, 117, 120);

            
            string[] pNome = nome.Split(' ');

            nome = nome.Replace(" ", "");

            imagem.Save(Server.MapPath("~/Imagens/Assinaturas/" + nome + ".jpeg"), ImageFormat.Jpeg);

            /*Caso Precise diminuir a Resolução da imagem e consequentemente o tamanho do arquivo.

            using (Bitmap img = new Bitmap(Server.MapPath("~/Imagens/Assinaturas/" + nome + ".jpeg2")))
            {
                //CodecInfo para imagens Jpeg
                ImageCodecInfo codec = ImageCodecInfo.GetImageEncoders().First(enc => enc.FormatID == ImageFormat.Jpeg.Guid);
                //EncoderParameters que vai setar o nível de qualidade (compressão)
                EncoderParameters imgParams = new EncoderParameters(1);
                //Qualidade em 100L = 100% de qualidade - sem compressão
                imgParams.Param = new[] { new EncoderParameter(Encoder.Quality, 50L) };

                //Salvar a imagem a imagem
                img.Save(Server.MapPath("~/Imagens/Assinaturas/" + nome + ".jpeg"), codec, imgParams);
            }
            */

            g.Dispose();
            imagem.Dispose();

            var arquivos = oModelArquivos.ListaArquivos();

            string nomeArquivo = (from arquivo in arquivos
                                  where arquivo.Nome.Contains(nome)
                                  select arquivo.Caminho).First();

            string contentType = "image/jpeg";

            return File(nomeArquivo, contentType, pNome[0]+".jpeg");
        }

        public void Deletar()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(System.Web.Hosting.HostingEnvironment.MapPath("~/Imagens/Assinaturas/"));
            var arquivosDelecao = dirInfo.GetFiles();

            //var arq = arquivosDelecao.Where(x => x.Name != "logo.jpeg");

            foreach (var item in arquivosDelecao)
            {
                item.Delete();
            }
        }

        public string PesquisaLista (string filtro, string empresa)
        {
            string retorno = (from end in emp.ListaEmpresas()
                              where end.CodEmpresa == empresa
                              select end.Endereco).First();

            return retorno;
        }
    }
}