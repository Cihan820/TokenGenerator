using System;
using System.IO;
using System.Linq;

namespace Checker_v1
{
    internal static class Program
    {
        public static Random Random;
        private static Random random;
        private static Random clr = new Random();
        private static string selection = "";
        private static readonly Random r2 = new Random();
        private static int gened;

        public static void Main()
        {
            string str1 = "████████╗ ██████╗ ██╗  ██╗███████╗███╗   ██╗     ██████╗ ███████╗███╗   ██╗";
            string str2 = "╚══██╔══╝██╔═══██╗██║ ██╔╝██╔════╝████╗  ██║    ██╔════╝ ██╔════╝████╗  ██║";
            string str3 = "   ██║   ██║   ██║█████╔╝ █████╗  ██╔██╗ ██║    ██║  ███╗█████╗  ██╔██╗ ██║";
            string str4 = "   ██║   ██║   ██║██╔═██╗ ██╔══╝  ██║╚██╗██║    ██║   ██║██╔══╝  ██║╚██╗██║";
            string str5 = "   ██║   ╚██████╔╝██║  ██╗███████╗██║ ╚████║    ╚██████╔╝███████╗██║ ╚████║";
            string str7 = "   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝     ╚═════╝ ╚══════╝╚═╝  ╚═══╝";
            Console.Title = "Token Generator by Cihan820#0008";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str7);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Token Formats,");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[1] Format -> NjAzMjg1N ->.XTdL");
            Console.WriteLine("[2] Format -> NjAzNjg1M ->.XTdL");
            Console.WriteLine("[3] Format -> NTE3N ->.DPN");
            Console.WriteLine("[4] Format -> NTUyOTA ->.D2GQ");
            Console.WriteLine("[5] Format -> NTUyODk ->.D2GO");
            Console.WriteLine("[6] Format -> NjM4ODI");
            Console.WriteLine("[7] Format -> NjM4NDE");
            Console.WriteLine("");
            Program.selection = Console.ReadLine();
            if (Program.selection == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray1.Length);
                        int index16 = Program.r2.Next(charArray1.Length);
                        int index17 = Program.r2.Next(charArray1.Length);
                        int index18 = Program.r2.Next(charArray1.Length);
                        int index19 = Program.r2.Next(charArray2.Length);
                        int index20 = Program.r2.Next(charArray2.Length);
                        int index21 = Program.r2.Next(charArray2.Length);
                        int index22 = Program.r2.Next(charArray2.Length);
                        int index23 = Program.r2.Next(charArray2.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        int index45 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NjAzMjg1N" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + ".XTdL" + (object)charArray1[index17] + (object)charArray1[index18] + "." + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NjAzMjg1N" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + ".XTdL" + (object)charArray1[index17] + (object)charArray1[index18] + "." + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45]);
                    }
                }
                Console.WriteLine("Generating Success!!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + "Random-Tokens" + ".txt");
            }
            else if (Program.selection == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray1.Length);
                        int index16 = Program.r2.Next(charArray1.Length);
                        int index17 = Program.r2.Next(charArray1.Length);
                        int index18 = Program.r2.Next(charArray1.Length);
                        int index19 = Program.r2.Next(charArray2.Length);
                        int index20 = Program.r2.Next(charArray2.Length);
                        int index21 = Program.r2.Next(charArray2.Length);
                        int index22 = Program.r2.Next(charArray2.Length);
                        int index23 = Program.r2.Next(charArray2.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        int index45 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NjAzMjg1M" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + ".XTdL" + (object)charArray1[index17] + (object)charArray1[index18] + "." + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NjAzMjg1M" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + ".XTdL" + (object)charArray1[index17] + (object)charArray1[index18] + "." + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45]);
                    }
                }
                Console.WriteLine("Done Generating!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + "Random-Tokens" + ".txt");
            }
            else if (Program.selection == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray1.Length);
                        int index16 = Program.r2.Next(charArray1.Length);
                        int index17 = Program.r2.Next(charArray1.Length);
                        int index18 = Program.r2.Next(charArray1.Length);
                        int index19 = Program.r2.Next(charArray1.Length);
                        int index20 = Program.r2.Next(charArray1.Length);
                        int index21 = Program.r2.Next(charArray1.Length);
                        int index22 = Program.r2.Next(charArray1.Length);
                        int index23 = Program.r2.Next(charArray1.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        int index45 = Program.r2.Next(charArray2.Length);
                        int index46 = Program.r2.Next(charArray2.Length);
                        int index47 = Program.r2.Next(charArray2.Length);
                        int index48 = Program.r2.Next(charArray2.Length);
                        int index49 = Program.r2.Next(charArray2.Length);
                        int index50 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NTE3N" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + (object)charArray1[index17] + (object)charArray1[index18] + (object)charArray1[index19] + (object)charArray1[index20] + ".DPN" + (object)charArray1[index21] + (object)charArray1[index22] + (object)charArray1[index23] + "." + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45] + (object)charArray2[index46] + (object)charArray2[index47] + (object)charArray2[index48] + (object)charArray2[index49] + (object)charArray2[index50]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NTE3N" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + (object)charArray1[index17] + (object)charArray1[index18] + (object)charArray1[index19] + (object)charArray1[index20] + ".DPN" + (object)charArray1[index21] + (object)charArray1[index22] + (object)charArray1[index23] + "." + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45] + (object)charArray2[index46] + (object)charArray2[index47] + (object)charArray2[index48] + (object)charArray2[index49] + (object)charArray2[index50]);
                    }
                }
                Console.WriteLine("Done Generating!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + "Random-Tokens" + ".txt");
            }
            else if (Program.selection == "4")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray1.Length);
                        int index16 = Program.r2.Next(charArray1.Length);
                        int index17 = Program.r2.Next(charArray1.Length);
                        int index18 = Program.r2.Next(charArray1.Length);
                        int index19 = Program.r2.Next(charArray1.Length);
                        int index20 = Program.r2.Next(charArray1.Length);
                        int index21 = Program.r2.Next(charArray2.Length);
                        int index22 = Program.r2.Next(charArray2.Length);
                        int index23 = Program.r2.Next(charArray2.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        int index45 = Program.r2.Next(charArray2.Length);
                        int index46 = Program.r2.Next(charArray2.Length);
                        int index47 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NTUyOTA" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + (object)charArray1[index17] + (object)charArray1[index18] + ".D2GQ" + (object)charArray1[index19] + (object)charArray1[index20] + "." + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45] + (object)charArray2[index46] + (object)charArray2[index47]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NTUyOTA" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + (object)charArray1[index17] + (object)charArray1[index18] + ".D2GQ" + (object)charArray1[index19] + (object)charArray1[index20] + "." + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45] + (object)charArray2[index46] + (object)charArray2[index47]);
                    }
                }
                Console.WriteLine("Done Generating!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + "Random-Tokens" + ".txt");
            }
            else if (Program.selection == "5")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray1.Length);
                        int index16 = Program.r2.Next(charArray1.Length);
                        int index17 = Program.r2.Next(charArray1.Length);
                        int index18 = Program.r2.Next(charArray1.Length);
                        int index19 = Program.r2.Next(charArray1.Length);
                        int index20 = Program.r2.Next(charArray1.Length);
                        int index21 = Program.r2.Next(charArray2.Length);
                        int index22 = Program.r2.Next(charArray2.Length);
                        int index23 = Program.r2.Next(charArray2.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        int index45 = Program.r2.Next(charArray2.Length);
                        int index46 = Program.r2.Next(charArray2.Length);
                        int index47 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NTUyODk" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + (object)charArray1[index17] + (object)charArray1[index18] + ".D2GO" + (object)charArray1[index19] + (object)charArray1[index20] + "." + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45] + (object)charArray2[index46] + (object)charArray2[index47]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NTUyODk" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + (object)charArray1[index10] + (object)charArray1[index11] + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + (object)charArray1[index15] + (object)charArray1[index16] + (object)charArray1[index17] + (object)charArray1[index18] + ".D2GO" + (object)charArray1[index19] + (object)charArray1[index20] + "." + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44] + (object)charArray2[index45] + (object)charArray2[index46] + (object)charArray2[index47]);
                    }
                }
                Console.WriteLine("Done Generating!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + ("x" + str6 + "-Random-Tokens.txt") + ".txt");
            }
            else if (Program.selection == "6")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray2.Length);
                        int index16 = Program.r2.Next(charArray2.Length);
                        int index17 = Program.r2.Next(charArray2.Length);
                        int index18 = Program.r2.Next(charArray2.Length);
                        int index19 = Program.r2.Next(charArray2.Length);
                        int index20 = Program.r2.Next(charArray2.Length);
                        int index21 = Program.r2.Next(charArray2.Length);
                        int index22 = Program.r2.Next(charArray2.Length);
                        int index23 = Program.r2.Next(charArray2.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NjM4ODI" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + "M" + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + "ND" + (object)charArray1[index10] + (object)charArray1[index11] + "N" + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + ".Xbi" + (object)charArray2[index15] + (object)charArray2[index16] + (object)charArray2[index17] + "." + (object)charArray2[index18] + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NjM4ODI" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + "M" + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + "ND" + (object)charArray1[index10] + (object)charArray1[index11] + "N" + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + ".Xbi" + (object)charArray2[index15] + (object)charArray2[index16] + (object)charArray2[index17] + "." + (object)charArray2[index18] + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44]);
                    }
                }
                Console.WriteLine("Done Generating!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + ("x" + str6 + "-Random-Tokens.txt") + ".txt");
            }
            else
            {
                if (!(Program.selection == "7"))
                    return;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str7);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How many tokens do You want? ");
                Console.ForegroundColor = ConsoleColor.Red;
                string str6 = Console.ReadLine();
                Console.Clear();
                using (StreamWriter streamWriter = new StreamWriter("x" + str6 + "-Random-Tokens.txt"))
                {
                    for (int index1 = 0; index1 < Convert.ToInt32(str6); ++index1)
                    {
                        char[] charArray1 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                        char[] charArray2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
                        int index2 = Program.r2.Next(charArray1.Length);
                        int index3 = Program.r2.Next(charArray1.Length);
                        int index4 = Program.r2.Next(charArray1.Length);
                        int index5 = Program.r2.Next(charArray1.Length);
                        int index6 = Program.r2.Next(charArray1.Length);
                        int index7 = Program.r2.Next(charArray1.Length);
                        int index8 = Program.r2.Next(charArray1.Length);
                        int index9 = Program.r2.Next(charArray1.Length);
                        int index10 = Program.r2.Next(charArray1.Length);
                        int index11 = Program.r2.Next(charArray1.Length);
                        int index12 = Program.r2.Next(charArray1.Length);
                        int index13 = Program.r2.Next(charArray1.Length);
                        int index14 = Program.r2.Next(charArray1.Length);
                        int index15 = Program.r2.Next(charArray2.Length);
                        int index16 = Program.r2.Next(charArray2.Length);
                        int index17 = Program.r2.Next(charArray2.Length);
                        int index18 = Program.r2.Next(charArray2.Length);
                        int index19 = Program.r2.Next(charArray2.Length);
                        int index20 = Program.r2.Next(charArray2.Length);
                        int index21 = Program.r2.Next(charArray2.Length);
                        int index22 = Program.r2.Next(charArray2.Length);
                        int index23 = Program.r2.Next(charArray2.Length);
                        int index24 = Program.r2.Next(charArray2.Length);
                        int index25 = Program.r2.Next(charArray2.Length);
                        int index26 = Program.r2.Next(charArray2.Length);
                        int index27 = Program.r2.Next(charArray2.Length);
                        int index28 = Program.r2.Next(charArray2.Length);
                        int index29 = Program.r2.Next(charArray2.Length);
                        int index30 = Program.r2.Next(charArray2.Length);
                        int index31 = Program.r2.Next(charArray2.Length);
                        int index32 = Program.r2.Next(charArray2.Length);
                        int index33 = Program.r2.Next(charArray2.Length);
                        int index34 = Program.r2.Next(charArray2.Length);
                        int index35 = Program.r2.Next(charArray2.Length);
                        int index36 = Program.r2.Next(charArray2.Length);
                        int index37 = Program.r2.Next(charArray2.Length);
                        int index38 = Program.r2.Next(charArray2.Length);
                        int index39 = Program.r2.Next(charArray2.Length);
                        int index40 = Program.r2.Next(charArray2.Length);
                        int index41 = Program.r2.Next(charArray2.Length);
                        int index42 = Program.r2.Next(charArray2.Length);
                        int index43 = Program.r2.Next(charArray2.Length);
                        int index44 = Program.r2.Next(charArray2.Length);
                        ++Program.gened;
                        Console.Title = "Cihan820 - Token Generated: " + (object)Program.gened;
                        streamWriter.WriteLine("NjM4NDE" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + "N" + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + "ND" + (object)charArray1[index10] + (object)charArray1[index11] + "N" + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + ".Xbi" + (object)charArray2[index15] + (object)charArray2[index16] + (object)charArray2[index17] + "." + (object)charArray2[index18] + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("NjM4NDE" + (object)charArray1[index2] + (object)charArray1[index3] + (object)charArray1[index4] + (object)charArray1[index5] + (object)charArray1[index6] + "N" + (object)charArray1[index7] + (object)charArray1[index8] + (object)charArray1[index9] + "ND" + (object)charArray1[index10] + (object)charArray1[index11] + "N" + (object)charArray1[index12] + (object)charArray1[index13] + (object)charArray1[index14] + ".Xbi" + (object)charArray2[index15] + (object)charArray2[index16] + (object)charArray2[index17] + "." + (object)charArray2[index18] + (object)charArray2[index19] + (object)charArray2[index20] + (object)charArray2[index21] + (object)charArray2[index22] + (object)charArray2[index23] + (object)charArray2[index24] + (object)charArray2[index25] + (object)charArray2[index26] + (object)charArray2[index27] + (object)charArray2[index28] + (object)charArray2[index29] + (object)charArray2[index30] + (object)charArray2[index31] + (object)charArray2[index32] + (object)charArray2[index33] + (object)charArray2[index34] + (object)charArray2[index35] + (object)charArray2[index36] + (object)charArray2[index37] + (object)charArray2[index38] + (object)charArray2[index39] + (object)charArray2[index40] + (object)charArray2[index41] + (object)charArray2[index42] + (object)charArray2[index43] + (object)charArray2[index44]);
                    }
                }
                Console.WriteLine("Done Generating!");
                Console.WriteLine("Saved " + Program.gened.ToString() + " Tokens to: " + ("x" + str6 + "-Random-Tokens.txt") + ".txt");
            }
        }

        public static string RandomString(int length) => new string(Enumerable.Repeat<string>("0123456789", length).Select<string, char>((Func<string, char>)(s => s[Program.random.Next(s.Length)])).ToArray<char>());

        static Program()
        {
            Program.Random = new Random(Environment.TickCount ^ DateTime.Now.Millisecond);
            Program.random = new Random();
        }
    }
}
