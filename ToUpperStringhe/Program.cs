string parolaMin = "", parolaMaiusc = "";

Console.WriteLine("Inserisci la parola in minuscolo da convertire in maiuscolo");
parolaMin = Console.ReadLine();

for (int i = 0; i < parolaMin.Length; i++)
{
    char c = parolaMin[i];
    if (c >= 'a' && c <= 'z')
    {
        parolaMaiusc += (char)(c - 32);
    }
    else
    {
        parolaMaiusc = parolaMaiusc + c;
    }
}
Console.WriteLine("la parola in maiuscolo è: " + parolaMaiusc);
