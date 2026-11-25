string parolaMin = "", parolaMaiusc = "";

Console.WriteLine("Inserisci la parola in minuscolo da convertire in maiuscolo");
parolaMin = Console.ReadLine();

for (int i = 0; i < parolaMin.Length; i++) //ciclo che scorrere la stringa carattere per carattere
{
    char c = parolaMin[i]; //estrae il singolo carattere alla posizione attuale (i)

    if (c >= 'a' && c <= 'z') //verifica se il carattere è una lettera minuscola controllando la tabella ASCII
    {
        parolaMaiusc += (char)(c - 32); //converte in maiuscolo sottraendo 32 (distanza ASCII) e lo aggiunge al risultato
    }
    else //se il carattere non è una lettera minuscola (è un numero, simbolo, o già maiuscolo)
    {
        parolaMaiusc = parolaMaiusc + c; //lo aggiunge alla stringa finale lasciandolo uguale
    }
}

Console.WriteLine("la parola in maiuscolo è: " + parolaMaiusc);