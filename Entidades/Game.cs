using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Game
    {
        private static readonly string localHost = "http://localhost/website_dinamico_sistema_jogo_ranqueado/transmitir.php";

        private static readonly string idGame = "2";

        public static string Host
        {
            get { return localHost; }
        }
        public static string IdGame
        {
            get { return idGame; }
        }
    }
    public class SituacaoAsync
    {
        public string Loginapp { get; set; }
        public string Vinculo { get; set; }
        public string Atualizacao { get; set; }
        public string Excecoes { get; set; }

    }
}
