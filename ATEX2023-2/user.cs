using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEX2023_2
{
    internal class user
    {
        private string nome, escola;
        private int idade, anoEscolar;
        private ConexaoDados objetoConexao = new ConexaoDados();
        public string Nome { get => nome; set => nome = value; }
        public string Escola { get => escola; set => escola = value; }
        public int Idade { get => idade; set => idade = value; }
        public int AnoEscolar { get => anoEscolar; set => anoEscolar = value; }

        public int incluirDados()
        {
            return objetoConexao.executarId($"insert into usuario (Nome, Escola, Idade, Ano_Escolar) values ('{Nome}','{Escola}','{Idade}','{AnoEscolar}') SET @IDUSER = SCOPE_IDENTITY()");
        }

    }
}
