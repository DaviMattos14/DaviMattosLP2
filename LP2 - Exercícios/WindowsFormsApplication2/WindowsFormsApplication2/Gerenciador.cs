using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Gerenciador
    {
        private List<Jogo> jogos;

        public Gerenciador()
        {
            jogos = new List<Jogo>();
        }

        public void AdicionarJogo(Jogo j)
        {
            jogos.Add(j);
        }
        public string GerarDadosLista()
        {
            string retorno = "";
            for (int i = 0; i < jogos.Count; i++)
            {
                retorno += String.Format("\n Código: {0} \n Nome: {1} \n Gênero: {2} \n", jogos[i].Codigo, jogos[i].Nome, jogos[i].Genero);
            }
            return retorno;
        }
    }
}
