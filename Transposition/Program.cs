using Microsoft.VisualBasic;

Console.WriteLine("1 für Verschlüsselung/ 2 für Entschlüsselung");
var eingabe = Console.ReadLine();
if (eingabe == "1")

{
    Console.WriteLine("Wie lange ist die Blocklänge?");
    var blocklange = Convert.ToInt32(Console.ReadLine());
    var text = File.ReadAllText(@"C:\C#\Testfile.txt");
    text = text.Replace(" ", "");


    if (text.Length % blocklange != 0)
        do
        {
            text = text + "A";
        } while (text.Length % blocklange != 0);

    var zeile = text.Length / blocklange;
    Console.WriteLine(text);
    var board = new char[zeile, blocklange];
    var row = board.GetLength(0);
    var zeilen = board.GetLength(1);
    var sb = new FileStream(@"C:\C#\Testfile.txt", FileMode.OpenOrCreate);
    text.Replace(" ", "");
    var sw = new StreamWriter(sb);
    var zahl = 0;

    for (var i = 0; i < row; i++)
    {
        for (var j = 0; j < zeilen; j++) Console.Write(board[i, j] = text[zahl++]);

        Console.WriteLine();
    }

    Console.WriteLine("Verschlüsselter Text");
    for (var i = 0; i < zeilen; i++)
    for (row = 0; row < board.GetLength(0); ++row)
        sw.Write(board[row, i]);
    sw.Close();
}
else
{
    var verschlusselttext = File.ReadAllText(@"C:\C#\Testfile.txt");
    Console.WriteLine(verschlusselttext);
    Console.WriteLine("Wie lange ist die Blocklänge?");
    var blocklange1 = Convert.ToInt32(Console.ReadLine());
    var zeile1 = verschlusselttext.Length / blocklange1;
    var zahl2 = 0;
    char[,] array = new char[blocklange1, zeile1];
    
    
    //HILFE DURCH ERMIN!

    for (int i = 0; i < array.GetLength((0)); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = verschlusselttext[zahl2++];
        }
    }

    for (int i = 0; i < verschlusselttext.Length; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[j,i]);
        }
    }
    
    // for (var i = 0; i < row2; i++)
    // {
    //     for (var j = 0; j < zeilen2; j++) Console.Write(board2[i, j] = verschlusselttext[zahl2++]);
    //     Console.WriteLine();
    // }

        
    // string cxt = null;
    //
    // for (var i = 1; i < plain.Length / blocklange1; i++) plain[i * blocklange1] = cxt[plain.Length / blocklange1 + i];
    //
    // Console.WriteLine(plain);
    // for (var j = 0; j < plain.Length / 2; j++) plain[j * blocklange1] = cxt[j];
}