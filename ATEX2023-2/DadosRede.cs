using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEX2023_2
{
    internal class DadosRede
    {
        ConexaoDados cdados = new ConexaoDados();
        private int idAPP;
        private string nome;
        private int idTutorial;
        private bool JogoOuRede;
        private string caminhoIMG;

        public int IdAPP { get => idAPP; set => idAPP = value; }
        public string Nome { get => nome; set => nome = value; }
        public int IdTutorial { get => idTutorial; set => idTutorial = value; }
        public bool JogoOuRede1 { get => JogoOuRede; set => JogoOuRede = value; }
        public string CaminhoIMG { get => caminhoIMG; set => caminhoIMG = value; }

        public (List<string>, List<string>, List<int>) load()
        {
            string sql = $"SELECT caminhoimagem,nome,idApp FROM app WHERE JogoOuRede = 0";
            return cdados.loadIMG(sql);
        }

        public List<string> loadPerguntas()
        {
            string sql = $"SELECT p.descricao FROM pergunta p INNER JOIN app a ON a.idApp = p.idApp WHERE a.idApp = '{idAPP}'";
            return cdados.LoadPerguntas(sql);
        }

        public List<string> loadOpcoes()
        {
            string sql = $"SELECT o.descricao FROM opcao o INNER JOIN pergunta p ON p.idPergunta = o.idPerguntaFechada INNER JOIN app a ON a.idApp = p.idApp WHERE a.idApp = '{idAPP}'";
            return cdados.LoadPerguntas(sql);
        }

        public void Conclui(List<string> dados)
        {
            cdados.RespondeRede(dados);
        }

        public void CriaRede(List<string> dados)
        {
            cdados.CriaRede(dados);
        }
    }
}
