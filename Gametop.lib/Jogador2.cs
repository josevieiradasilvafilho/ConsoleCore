using Gametop.Interface;

namespace Gametop.lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passa()
        {
            return "Maradona estas pasando \n";
        }
    }
}