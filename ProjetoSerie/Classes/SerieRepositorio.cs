//para linkar a interface a essa pasta
using ProjetoSerie.Interface; 
//para poder utilizar a lista dinamica
using System.Collections.Generic;

namespace ProjetoSerie.Classes
{
    public class SerieRepositorio : Repositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();


        // o metodo atualiza ira receber um id e colocar a serie na posição correspondente dessa lista
        public void Atualiza(int id, Serie serie)
        {
            ListaSerie[id] = serie;
        }

        //metodo para remover a serie(item) da lista
        public void Exclui(int id)
        {
           ListaSerie[id].Excluir(); 
        }

        //insere o objeto na lista
        public void Insere(Serie serie)
        {
            ListaSerie.Add(serie);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}