using System.Collections.Generic;


namespace ProjetoSerie.Interface
{
    //Colocando esse <T>, tornamos uma classe generica, sendo assim podemos substituir seus metodos pelo tipo valor 
    // que desejamos posteriormente, em tempo de execução ou reescrevendo o codigo em cima(Polimorfismo).
    public interface Repositorio <T>
    {
        List<T> Lista();

        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);

        int ProximoId();
    }
}