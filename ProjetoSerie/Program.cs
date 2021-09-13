using System;
using ProjetoSerie.Classes;


namespace ProjetoSerie
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();



        static void Main(string[] args)
        {
            string opcao = Program.OpcaoUsuario();

            while(opcao != "X") {

                switch(opcao) {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;



                }
            
                opcao = Program.OpcaoUsuario();

            }


            
        }

        private static void ListarSeries()
		{
			Console.WriteLine("Segue abaixo as series cadastradas");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Não possui series cadastradas!");
				return;
			}

			foreach (var serie in lista)
			{
                  
				Console.WriteLine("#ID {0}: - {1} - Excluido: {2}", serie.retornaId(), serie.retornaTitulo(),serie.retornaBoolean()? "Sim": "Nao");
			}
		}

        private static string OpcaoUsuario() {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao meu programa!"); 
            Console.WriteLine("Digite abaixo a opção desejada"); 
            Console.WriteLine("1- Listar Series"); 
            Console.WriteLine("2- Inserir nova serie"); 
            Console.WriteLine("3- Atualizar serie"); 
            Console.WriteLine("4- Excluir Serie"); 
            Console.WriteLine("5- Visualizar Serie"); 
            Console.WriteLine("C- Limpar a tela"); 
            Console.WriteLine("X- Finalizar Programa"); 
            Console.WriteLine();

            //Le a opçaod o usuario e garante que as letras vao estar em maiusculo
            string aux = Console.ReadLine().ToUpper();
            return aux;



        }
        public static void InserirSerie() {
            Console.WriteLine("Inserir nova série");
        

            repositorio.Insere(novaSerie(repositorio.ProximoId()));

    
        }

        private static void AtualizarSerie() {
            Console.Write("Qual id da serie desejada:");
            int id = int.Parse(Console.ReadLine());
            
            repositorio.Atualiza(id,novaSerie(id));
        }

        private static void ExcluirSerie(){
            Console.Write("Qual id deseja excluir:");
            int aux = int.Parse(Console.ReadLine());

            repositorio.Exclui(aux);
        }

        private static void VisualizarSerie() {
            Console.WriteLine("Qual serie deseja ver:");
            int aux = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(aux);
            Console.WriteLine(serie);
       
        }
    
        private static Serie novaSerie(int id) {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));
            }

            Console.Write("Dentre as opções acima digite o genero da serie:");
            int genero = int.Parse( Console.ReadLine());

            Console.Write("Digite o titulo da serie: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a descrição da serie: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o ano da serie: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota geral da serie(0.0-10.0): ");
            double nota = double.Parse(Console.ReadLine());
            
            Serie novaSerie = new Serie(id,(Genero)genero,titulo,descricao,ano,nota );
            return novaSerie;
        }
    
    }

 
   

}


