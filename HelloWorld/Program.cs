using HelloWorld.Test1.Test2;

namespace HelloWorld {

    class Program {
        
       static void Main()
        {
            Console.WriteLine("Olá sorveteiros");

            Funcao funcao = new Funcao();

            Usuario myUser = new Usuario();
            myUser.Cadastro();
            myUser.TentarDeletar();


            Carro carro = new Carro();
            carro.Ligar();
            carro.Desligar();


            Pokemon typhlosion = new Pokemon();
            typhlosion.AtaqueRapido();
            typhlosion.RodaDeFoco();
                

        }
    }
}

// Comentário de 1 lina5

/*
 Comentário de 
 várias linhas
 */