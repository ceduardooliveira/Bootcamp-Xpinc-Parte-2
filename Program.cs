using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


Venda v1 = new Venda(1, "Material de escritorio", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(serializado);

















// int numero = 15;
// bool ehPar = false;

// // if ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero que temos: {numero} é: " + (ehPar ? "par": "ímpar"));

















// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O numero é {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero é {numero} é ímpar");
// }













// Pessoa p1 = new Pessoa("Carlos Eduardo", "Pereira de Oliveira" );

// (string nome, string sobrenome) = p1;


// Console.WriteLine($"{nome} {sobrenome}");
















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhas, _) = arquivo.LerArquivos("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo: " + QuantidadeLinhas);
//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }    
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo.");
// }




// (int ID, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Eduardo", "Oliveira", 1.69M);

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Eduardo", "Oliveira", 1.69M);
// // var outroExemploTupla = Tuple.Create(1, "Eduardo", "Oliveira", 1.69M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);




// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("=====================");
// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }

// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }








// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");


// pilha.Push(20);
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }











// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }





















//new ExemploExcecao().Metodo1();
























// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");


//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquvio.Arquivo não encontrado. {ex.Message}");
// }

//  catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquvio. Caminho não econtrado. {ex.Message}");
// }

//  catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// } finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }















// string dataString = "2021-09-04 14:28";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InstalledUICulture, 
//                         DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data} ");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válid.");
// }



















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));










// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);










// Pessoa p1 = new Pessoa(nome: "Carlos Eduardo", sobrenome: "Pereira de Oliveira");
// Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();


// cursoDeIngles.adicionarAluno(p1);
// cursoDeIngles.adicionarAluno(p2);
// cursoDeIngles.ListarAlunos();















// Pessoa p1 = new Pessoa();

// p1.Nome = "Carlos Eduardo";
// p1.Sobrenome = "Pereira de Oliveira";
// p1.Idade = 30;
// p1.Apresentar();