using System;
using System.Collections.Generic;
using Dio.Series.interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }

        public void retornaExcluido(int id)
        {
            listaSerie[id].retornaExcluido(); 
        }

        public void Insere(Series objeto)
        {
           listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
           return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
           return listaSerie[id];
    }
}
} 