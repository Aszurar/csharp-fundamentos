namespace HelloWorld;
internal class Usuario
{
    public void Cadastro()
    {
        Console.WriteLine("Cadastrando Lucas de Lima");
    }

    void Deletar()
    {
        Console.WriteLine("Deletando usuário");
    }

    private void Editar() {
        Console.WriteLine("Editar usuário");
    
    }

    public void TentarDeletar()
    {
        Deletar();
    }
        
}
