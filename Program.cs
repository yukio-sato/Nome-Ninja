Console.Clear();
for (int i = 0; i < 18; i++)
{
    Console.Write("Escreva seu nome: "[i]);
    Console.Beep(1350, 75);
}
string nomedigitado = Console.ReadLine()!;
string nomeninja = nomedigitado
            .ToUpper()
            .Replace("A", "ka")
            .Replace("Ã", "ka")
            .Replace("Á", "ka")
            .Replace("À", "ka")
            .Replace("B", "zu")
            .Replace("C", "mi")
            .Replace("D", "te")
            .Replace("E", "ku")
            .Replace("É", "ku")
            .Replace("É", "ku")
            .Replace("F", "lu")
            .Replace("G", "ji")
            .Replace("H", "ri")
            .Replace("I", "ki")
            .Replace("J", "zus")
            .Replace("K", "me")
            .Replace("L", "ta")
            .Replace("M", "rin")
            .Replace("N", "to")
            .Replace("O", "mo")
            .Replace("Ó", "mo")
            .Replace("Ò", "mo")
            .Replace("Õ", "mo")
            .Replace("P", "no")
            .Replace("Q", "ke")
            .Replace("R", "shi")
            .Replace("S", "ari")
            .Replace("T", "chi")
            .Replace("U", "do")
            .Replace("V", "ru")
            .Replace("W", "mei")
            .Replace("X", "na")
            .Replace("Y", "fu")
            .Replace("Z", "zi");
            Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine($"Seu nome ninja é {nomeninja.Substring(0,1).ToUpper()}{nomeninja.Substring(1).ToLower()}");
Console.ResetColor();
