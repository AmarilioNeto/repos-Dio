
using System.Collections.Generic;
{
     
}namespace Dio.Series.interfaces
{
    public interface IRepositorio<T> 
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void retornaExcluido(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
        
    }
    
}