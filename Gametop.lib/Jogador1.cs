using Gametop.Interface;

namespace Gametop.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;
        public Jogador1 (string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} está Chutando \n";
;       }

        //corre
        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }
        
        //passe
        public string Passa()
        {
            return $"{_Nome} está Passando \n";
        }

    }

}