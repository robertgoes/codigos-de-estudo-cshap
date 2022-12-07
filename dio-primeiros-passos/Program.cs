using System;
using dio_primeiros_passos.Models;

string opcaoUsuario = ObterOpcaoUsuario();
List<Aluno> listaAlunos = new List<Aluno>();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {   
        case "1":
            listaAlunos.Add(InserirNovoAluno());
            break;
        case "2":
            ListarAlunos();
            break;
        case "3":
            Console.WriteLine($"Média Geral: {CalcularMediaGeral()}");
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    opcaoUsuario = ObterOpcaoUsuario();
}

decimal CalcularMediaGeral()
{
    decimal totalDasNotas = 0;

    foreach(var aluno in listaAlunos)
    {
        totalDasNotas += aluno.Nota;
    }
    
    int quantidadeAlunos = listaAlunos.Count;

    return totalDasNotas / quantidadeAlunos;
}

void ListarAlunos()
{
    foreach(var aluno in listaAlunos)
    {
        Console.WriteLine($"ALUNO: {aluno.Nome} - NOTA: {aluno.Nota}");
    }
}

static Aluno InserirNovoAluno()
{
    Aluno aluno = new Aluno();

    Console.WriteLine("Nome do aluno:");
    string nome = Console.ReadLine();
    aluno.Nome = nome;

    Console.WriteLine("Nota do aluno:");
    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
        aluno.Nota = nota;
    
    else
        throw new ArgumentException("Valor da nota deve ser decimal");

    return aluno;

}

static string ObterOpcaoUsuario()
{
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular Média Geral");
    Console.WriteLine("X - Sair");

    return Console.ReadLine();
}