using System.IO;

namespace EGames.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            // Nome da pasta / nomedoarquivo.csv
            string pasta = caminho.Split('/')[0];

            // Se o diretório não existir, criar pasta
           if (!Directory.Exists(pasta))
           {
                Directory.CreateDirectory(pasta);
           }

           if (!File.Exists(caminho))
            {
                File.Create(caminho);
           }

        }
    }
}
