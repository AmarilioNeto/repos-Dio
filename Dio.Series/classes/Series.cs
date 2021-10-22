namespace Dio.Series
{
    public  class Series : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano {get; set; }
        private bool Excluido { get; set; }

        // Metodo

        public Series( int Id, Genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }
       public override string ToString()
       {
           string retorno = "";
           retorno += "Genero: " + this.Genero;
           retorno += "Titulo: " + this.Titulo;
           retorno += "Descrição: " + this.Descricao;
           retorno += "Ano de Inico: " + this.Ano;
           return retorno;

       }
       public string retornaTitulo()
       {
           return this.Titulo;
       }
       public int retornaId()
       {
           return this.Id;
       }
       public void Excluir()
       {
           this.Excluido = true;
       }
       
    }
}