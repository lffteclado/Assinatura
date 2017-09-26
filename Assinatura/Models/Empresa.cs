using System.Collections.Generic;

namespace Assinatura.Models
{
    public class Empresa
    {
        public string CodEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeCompleto { get; set; }
        public string Endereco { get; set; }
        public string Endereco2 { get; set; }
        public string Site { get; set; }

        public List<Empresa> ListaEmpresas()
        {
            return new List<Empresa>
            {
                new Empresa {CodEmpresa = "1200", NomeEmpresa = "Auto Sete", NomeCompleto = "Autosete Veículos e Peças - Grupo VDL", Endereco = "R. Olavo Bilac, 480 - Piedade", Endereco2 = "Sete Lagoas - MG - CEP 35700-214", Site = "www.autosete.com.br" },
                new Empresa {CodEmpresa = "262", NomeEmpresa = "Calisto",  NomeCompleto = "Calisto Diesel de Veículos - Grupo VDL", Endereco = "Av. Alfredo Sá, 6145 - Vila Ramos", Endereco2 = "Teófilo Otoni - MG - CEP 39804-000", Site = "www.teofilootonidiesel.com.br" },
                new Empresa {CodEmpresa = "930", NomeEmpresa = "Cardiesel",  NomeCompleto = "Cardiesel - Grupo VDL", Endereco = "Av. Amazonas, 8787 - Cabana", Endereco2 = "Belo Horizonte - MG - CEP 30510-000", Site = "www.cardiesel.com.br" },
                new Empresa {CodEmpresa = "2630", NomeEmpresa = "Goias", NomeCompleto = "Goiás Caminhões & Ônibus - Grupo VDL",Endereco = "Av. Pedro Ludovico, 3597 - Pq. Oeste Industrial", Endereco2 = "Goiânia - GO - CEP 74375-400", Site = "www.goiascaminhoes.com.br" },
                new Empresa {CodEmpresa = "2630F", NomeEmpresa = "Mato Grosso", NomeCompleto = "Mato Grosso Caminhões - Grupo VDL", Endereco = "Av. Senador Valdon Varjão, 3353-Serra Dourada", Endereco2 = "Barra do Garças - MT - CEP 78600-000", Site = "www.matogrossocaminhoes.com.br" },
                new Empresa {CodEmpresa = "3140", NomeEmpresa = "Montes Claros", NomeCompleto = "Montes Claros Diesel", Endereco = "Av. Deputado Plinio Ribeiro, 1057 - Esplanada", Endereco2 = "Montes Claros - MG - CEP 39401-474", Site = "www.montesclarosdiesel.com.br" },
                new Empresa {CodEmpresa = "2890", NomeEmpresa = "Posto Imperial", NomeCompleto = "Posto Imperial - Grupo VDL", Endereco = "Rod.BR-116-Rio Bahia, Km 774, 600 - Caiçaras", Endereco2 = "Leopoldina - MG - CEP 36700-000", Site = "www.postoimperial.com.br" },
                new Empresa {CodEmpresa = "130", NomeEmpresa = "Vadiesel", NomeCompleto = "Vadiesel Vale do Aço Diesel - Grupo VDL", Endereco = "Rod. BR-381, Km. 196 - Núcleo Industrial", Endereco2 = "Timóteo - MG - CEP 35180-001", Site = "www.vadiesel.com.br" },
                new Empresa {CodEmpresa = "2620", NomeEmpresa = "Uberlandia", NomeCompleto = "Uberlândia Caminhões & Ônibus - Grupo VDL", Endereco = "Av. Paulo Roberto da Cunha Santos, 2.181/A - Marta Helena", Endereco2 = "Uberlândia - MG - CEP 38402-266", Site = "www.uberlandiacaminhoes.com.br" },
                new Empresa {CodEmpresa = "2620F", NomeEmpresa = "Itumbiara", NomeCompleto = "Itumbiara Caminhões e Ônibus - Grupo VDL", Endereco = "V. Expressa Júlio Borges de Souza, 6.800 - Nossa Senhora da Saúde", Endereco2 = "Itumbiara-GO - CEP:75520-375", Site = "www.itumbiaracaminhoes.com.br" },
                new Empresa {CodEmpresa = "260", NomeEmpresa = "Valadares", NomeCompleto = "Valadares Diesel - Grupo VDL", Endereco = "Rod. Rio-Bahia, Km 545 - Jardim Ipê", Endereco2 = "G. Valadares - MG - CEP 35043-000", Site = "www.valadaresdiesel.com.br" },
                //new Empresa {CodEmpresa = "3610", NomeEmpresa = "Rede Mineira", NomeCompleto = "Rede Mineira de Pneus - Grupo VDL", Endereco = "", Endereco2 = "", Site = "" },
                new Empresa {CodEmpresa = "666", NomeEmpresa = "Grupo VDL", NomeCompleto = "Grupo VDL", Endereco = "Av. Amazonas, 8787 - Cabana", Endereco2 = "Belo Horizonte - MG - CEP 30510-000", Site = "www.grupovdl.com.br" }

            };
        }
    }
}