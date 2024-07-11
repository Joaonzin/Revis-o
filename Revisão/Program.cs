using Revisão;

Funcionario fun = new Funcionario();
dependente den = new dependente();
Automovel aut = new Automovel();

int MatriculaFuncionario = fun.MatriculaFuncionario();
Console.WriteLine(MatriculaFuncionario);

fun.PlacaVeiculo = "JKL2784";
if (fun.VerificarVeiculo(aut))
{
    Console.WriteLine("A placa contém 7 caracteres");
}
else
{
    Console.WriteLine("A Placa informada n contém 7 caracteres");
}

if (fun.Contatar())
{
    Console.WriteLine("Contato Realizado");
}


