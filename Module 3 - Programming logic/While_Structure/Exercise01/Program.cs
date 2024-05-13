
int tentativas = 0;
string senha;

Console.WriteLine("Digite uma senha com mínimo 6 dígitos: ");
senha = Console.ReadLine();

bool resultado = Senha(senha);

while (resultado == false)
{
    Console.Clear();
    Console.WriteLine("Senha inválida");
    Console.WriteLine("Digite uma senha com o mínimo 6 dígitos: ");

    senha = Console.ReadLine();
    resultado = Senha(senha);
}

Console.WriteLine("Repita sua senha: ");
string repeatSenha = Console.ReadLine();


if (senha == repeatSenha)
{
    Console.WriteLine("Senha salva com sucesso!");

}
else
{
    while (repeatSenha != senha)
    {
        Console.WriteLine("As senhas não conferem!");
        Console.WriteLine("Repita sua senha: ");
        repeatSenha = Console.ReadLine();
    }

    Console.WriteLine("Senha salva com Sucesso!");

}

Console.Write("Para realizar o login, digite sua senha: ");
string loginSenha = Console.ReadLine();

while (loginSenha != senha && tentativas < 3)
{
    Console.WriteLine("Senha inválida");
    tentativas++;
    Console.Write("Digite novamente sua senha: ");
    loginSenha = Console.ReadLine();

    if (tentativas == 2)
    {
        Console.WriteLine("Atenção! Se errar novamente sua senha será bloqueada! ");

    }

}

if (tentativas <= 3)
{
    Console.WriteLine("Login realizado com sucesso!"); 
}
else
{
    Console.WriteLine("Bloqueado");
}

static bool Senha(string a)
{
    bool verdadeiro;
    if (a.Length >= 6)
    {
        verdadeiro = true;
    }
    else
    {
        verdadeiro = false;
    }
    return verdadeiro;
}