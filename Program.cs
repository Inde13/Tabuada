Console.Clear();

int numero;
int i = 0;

Console.WriteLine("-= Gerador de Tabuada =-\n");

Console.Write("Digite um número e pressione ENTER: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n-= Tabuada do número {numero} =-\n");

while (i <= 10) {
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    i++;
}

