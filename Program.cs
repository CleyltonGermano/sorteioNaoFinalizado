using System;
using System.Collections.Generic;


namespace sorteio
{
    class Program
    {
        private static readonly object r;
        static Random random = new Random();
        static List<string> listaNomes = new List<string>()
            {
                  "Yuri",
                 "Julio Cesar",
                 "Leone",
                 "Daniel Souza",
                 "Gisa",
                 "Germano",
                 "Thiago",
                 "Cid",
                 "Hanna",
                 "Yvens",
                 "Diego",
                 "Flavio",
                 "Davi",
                 "João Pedro",
                 "Erick",
                 "Lucas",
                 "Hellen",
                 "Leonardo",
                 "Matheus",
                 "Patrick",
                 "Ana Paula",
                 "Hadson",
                 "Alan",
                 "Arthur",
                 "Cleylton",
                 "Daniel Santos",
                 "Edvaldo",
                 "Isadora",
                 "Ismael",
                 "Romario"
            };

        static List<Pessoa> listaPessoas = new List<Pessoa>();
        static List<List<Pessoa>> listaGrupos = new List<List<Pessoa>>();

        // 
        static int _grupos;

        //
        static int _pessoasPorGrupo;

        static void Main(string[] args)
        {
            EntradaUsuario();


            // inicializando a Lista de Pessoas com a Lista de Nomes...
            foreach (var nome in listaNomes)
            {
                listaPessoas.Add(new Pessoa(nome));
            }

            

            // passar por cada grupo * A SER CRIADO *
            for (int i = 0; i < _grupos; i++)
            {

                List<Pessoa> listaTempPessoa = new List<Pessoa>();
                // pegar x pessoas
                // coloca-las em uma List<Pessoa>
                for (int j = 0; j < _pessoasPorGrupo; j++)
                {
                    
                    Pessoa aleat = retiraPessoaAleatoriaDaLista(listaPessoas);
                    listaTempPessoa.Add(aleat);
                }

                // e add essa List<Pessoa> no listaGrupo
                listaGrupos.Add(listaTempPessoa);
            }

            for (int i = 0; i < _grupos; i++)
            {
                Console.WriteLine("Grupo: ");

                foreach (var item in listaGrupos)
                {
                    Console.WriteLine(listaGrupos[i]);                    
                }
                
            }
            
        }

        private static void EntradaUsuario()
        {
            // Pega informações do usuário...

            Console.Write("Quantos grupos? ");
            _grupos = int.Parse(Console.ReadLine());

            Console.Write("Quantas pessoas você quer por grupo? ");
            _pessoasPorGrupo = int.Parse(Console.ReadLine());
        }

        static Pessoa retiraPessoaAleatoriaDaLista(List<Pessoa> listaPess)
        {
            // retorna numero aleatorio entre 0 e listaPess.Count ( não inclusivo )
            int indiceAleat = random.Next(listaPess.Count);
            // transforma a lista em array pára usarmos indice
            var vetorPess = listaPess.ToArray();
            // guarda a pessoa aleatoria em 1 variável para remover da list
            Pessoa pAleatoria = vetorPess[indiceAleat];

            // remove p aleat
            listaPess.Remove(pAleatoria);

            return pAleatoria;
        }
    }
}

