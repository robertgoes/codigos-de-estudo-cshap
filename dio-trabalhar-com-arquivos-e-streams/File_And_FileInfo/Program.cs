using System;

//Definir o caminho(diretório do arquivo).
var diretorioDoArquivoTexto = Path.Combine(Environment.CurrentDirectory, "texte.txt");

//Criar um arquivo de texto, passando por parâmetro o path(diretório).
//Declaramos o using para usar o método flush automaticamente.
using var arquivoTexto = File.CreateText(diretorioDoArquivoTexto);

//Através do método WriteLine, podemos passar o conteúdo do texto, por paramêtro.
arquivoTexto.WriteLine("Está é a linha 1");
arquivoTexto.WriteLine("Está é a linha 2");