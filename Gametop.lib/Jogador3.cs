using Gametop.Interface;

namespace Gametop.lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste Chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre \n";
        }

        public string Passa()
        {
            return "Teste Passa \n";
        }
    }
}