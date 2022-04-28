Console.WriteLine("Estudo de escopo em estruturas condicionais");

int idade = 18;
bool acompanhado = true;
string mensagemAdicional; // Sem essa declaração há erro, pois variáveis declaradas dentro de if são locais, e não podem ser acessadas fora do if.

if (acompanhado == true)
    mensagemAdicional = "Está acompanhado";
else
    mensagemAdicional = "Não está acompanhado";

if (idade >= 18 || acompanhado == true)
{
    Console.WriteLine("Pode entrar.");
    Console.WriteLine(mensagemAdicional);
}
else
    Console.WriteLine("Não pode entrar");

Console.ReadLine();