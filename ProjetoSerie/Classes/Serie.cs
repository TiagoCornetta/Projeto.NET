using System;

namespace ProjetoSerie
{
    public class Serie : EntidadeBase
    {
        // Atributos de cada Serie

        private Genero Genero {get; set;}
        
        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano{get; set;}

        private double nota{get; set;}

        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano, double nota) {
            this.ID = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
            if(nota < 0 || nota > 10){
                throw new IndexOutOfRangeException("Number must be in range (0.0 - 10.0)");
            }
            this.nota = nota;

        }


        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + "\n";
            retorno += "Titulo: " + this.Titulo + "\n";
            retorno += "Descrição: " + this.Descricao + "\n";
            retorno += "Ano de Inicio: " + this.Ano + "\n";
            retorno += "Nota: " + this.nota + "\n";
            retorno += "Excluido: " + this.Excluido + "\n";

            return retorno;
        }

        public string retornaTitulo() {
            return this.Titulo;
        }

        public int retornaId () {
            return this.ID;
        }

        public void Excluir() {
            this.Excluido = true;
        }

        public bool retornaBoolean(){
            return this.Excluido;
        }
        
    }
}