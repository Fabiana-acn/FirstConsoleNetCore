namespace P1
{
    public class Automovel{
        public string Nome { get; set; }
        public string  Cor { get; set; }
        public int Portas { get; set; } = 4;

        public int Rodas
        {
            get { return 4; } 
        }

        public int Rodas2 => 4;
    
        
    }
}