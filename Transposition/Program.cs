﻿Console.WriteLine("1 für Verschlüsselung/ 2 für Entschlüsselung");
string eingabe = Console.ReadLine();
if (eingabe == "1")
        
{       Console.WriteLine("Wie lange ist die Blocklänge?");
        int blocklange = Convert.ToInt32(Console.ReadLine());
        string text = File.ReadAllText(@"C:\C#\Testfile.txt");
        int zeichen = text.Length;
        int zeile = zeichen / blocklange;
        char[,] board = new char[zeile, blocklange];
        int row = board.GetLength(0);
        int zeilen = board.GetLength(1);
        FileStream sb = new FileStream(@"C:\C#\Testfile.txt", FileMode.OpenOrCreate);  
        StreamWriter sw = new StreamWriter(sb);
        int zahl = 0;
        
        for (int i = 0; i < row; i++)
        {




                for (int j = 0; j < zeilen; j++)
                {
                        
                        
                        Console.Write( board[i, j] = text[zahl++]);

                }

                Console.WriteLine();





        }
        
        Console.WriteLine("Verschlüsselter Text");
        for (int i = 0; i < zeilen; i++)
        {


                for (row = 0; row < board.GetLength(0); ++row)
                {


                        sw.Write(board[row, i]);



                }
                
        }
        sw.Close();
        
        
}
Console.WriteLine("Wie lange ist die Blocklänge?");
int blocklange1 = Convert.ToInt32(Console.ReadLine());
string verschlusselttext = File.ReadAllText(@"C:\C#\Testfile.txt");
int zeichen1 = verschlusselttext.Length;
int zeile1 = zeichen1 / blocklange1;



char[,] board2 = new char[zeile1, blocklange1];
int row2 = board2.GetLength(0);
int zeilen2 = board2.GetLength(1);

int zahl2=0;
for (int i = 0; i < row2; i++)
{




        for (int j = 0; j < zeilen2; j++)
        {
        

                Console.Write( board2[i, j]= verschlusselttext[zahl2++]);

        }

        Console.WriteLine();





}