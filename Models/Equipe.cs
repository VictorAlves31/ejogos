using System.Collections.Generic;
using System.IO;
using EGames.Interface;

namespace EGames.Models
{

    //Herança
    //", Interface"(Contrato da Equipe)
    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }

        // Variável de dados.

        private const string caminhobd = "Database/equipe.csv";

        public Equipe()
        {

            // método da classe de herança EquipeBase
            CriarPastaOuArquivo(caminhobd);
        }

        //Criar uma função que vai receber o objeto EQUIPE e vai retornar no formato de csv.

        private string Preparar(Equipe e)
        {
            return $"{e.idEquipe};{e.Nome};{e.Imagem}";
        }

        public void Criar(Equipe novaEquipe)
        {
            //array de strings = na posição 0 o retorno do "Preparar".
            string[] equipe_texto = {Preparar(novaEquipe)};

            //Arquivo vamos adicioinar uma nova linha.
            //caminho do arquivo, string em formato array.
            File.AppendAllLines(caminhobd,equipe_texto);

        }

        public void Editar(Equipe novaEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipe = new List<Equipe>();

            File.ReadAllLines(caminhobd);

            // Ler todas as linhas do arquivo csv, armazenar em um array;
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1; nome da equipe; caminho da imagem
                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipe.Add(equipeAtual);
            }

            return listaEquipe;
        }
    }
}
