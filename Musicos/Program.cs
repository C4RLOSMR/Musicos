namespace Musicos
{

    class Musico
    {
        public string Nombre{get;set;}
        public Musico(string n){Nombre=n;}
        public void Saluda(){Console.WriteLine($"Hola soy {Nombre}");}
        public virtual void Toca()
        {
            Console.WriteLine($"{Nombre} tocando si intrumento");
        }

        
    }

    class Baterista : Musico
    {
            public string baterista {get; set;}

            public Baterista(string Nombre, string baterista): base(n)
            {
                baterista = ;
            }
    }

    class Bajista : Musico
    {
            public string bajo {get;set;}

            public Bajista (string Nombre, string bajo): base (n)
            {
                bajo = b;
            }


        public override void Toca()
        {
            Console.WriteLine();
        }

        List<Musico> grupo = new List<Musico>();
         grupo.add(new Bajista("Joe", "Yamaha"));
    }

    

   

    class Program
    {
    static void Main()
    {

    }
}
}