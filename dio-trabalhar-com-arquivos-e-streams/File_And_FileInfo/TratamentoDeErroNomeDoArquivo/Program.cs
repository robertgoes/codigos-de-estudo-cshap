using System;

Console.WriteLine("Informe o nome do arquivo:");
var nomeDoArquivo = Console.ReadLine();

nomeDoArquivo = TratarErroDeCaractereInvalido(nomeDoArquivo);

//Definir o caminho(diretório do arquivo).
var diretorioDoArquivoTexto = Path.Combine(Environment.CurrentDirectory, $"{nomeDoArquivo}.txt");

//Criar um arquivo de texto, passando por parâmetro o path(diretório).
//Declaramos o using para usar o método flush automaticamente.
using var arquivoTexto = File.CreateText(diretorioDoArquivoTexto);

//Através do método WriteLine, podemos passar o conteúdo do texto, por paramêtro.
arquivoTexto.WriteLine("Está é a linha 1");
arquivoTexto.WriteLine("Está é a linha 2");

string TratarErroDeCaractereInvalido(string _nomeDoArquivo)
{
    /*
    Tratar erro de caractere inválido. 
    Vamos percorrer o array que o método Path.GetInvalidFileNameChars(), vai nos retornar.
    */
    
    foreach (var caractereInvalido in Path.GetInvalidFileNameChars())
    {    
        /*
        No escopo do foreach, caso o nome do arquivo possua algum caractere inválido,
        vamos substituir pelo caractere "-", substituindo o nome atual do arquivo, usando o método Replace()

        No método Replace(), passamos por parâmetro o item(caractereInvalido) que está sendo iterado no foreach,
        esse item é um dos caracteres inválido, que contém no array e passamos outro parâmetro que é o caractere que queremos usar 
        na substituição "-".
        */
        _nomeDoArquivo = _nomeDoArquivo.Replace(caractereInvalido, '-');
    }
        return _nomeDoArquivo;
}