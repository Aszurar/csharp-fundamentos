using HelloWorld.Test1.Test2;

namespace HelloWorld {

    class Program {
        
       static void Main()
        {
            Console.WriteLine("Olá, tudo bem?");


            Usuario myUser = new Usuario();
            myUser.Cadastro();
            myUser.TentarDeletar();


            Carro carro = new Carro();
            carro.Ligar();
            carro.Desligar();
                

        }
    }
}

// Comentário de 1 lina5

/*
 Comentário de 
 várias linhas
 */