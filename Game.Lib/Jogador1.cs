using Game.Interface;

namespace Game.Lib
{
    public class Jogador1 : iJogador
    {
        public string _Nome { get; set; }

        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} está Chutando \n";
        }
        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }
        public string Passe()
        {
            return $"{_Nome} está Passando \n";
        }
    }
}