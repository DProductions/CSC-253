
/**
* 10 SEP 2023
* CSC 253
* Daniel Parks
* File Encryption and Decryption
*/


using System;
using System.IO;
using EncryptionDictionary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Encrypt a text file");
        Console.WriteLine("2. Decrypt an encrypted file");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                EncryptFile();
                break;
            case 2:
                DecryptFile();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void EncryptFile()
    {
        Console.WriteLine("Enter file path for file encryption.");
        Console.WriteLine("Please use the following example:");
        Console.WriteLine("");
        Console.WriteLine(@"C:\Users\adamp\Desktop\NormalFile.txt");
        Console.WriteLine();
        Console.WriteLine("Be sure to include the file extension (i.e., .txt)");
        Console.WriteLine("File Path:");
        string inputFile = Console.ReadLine();
        Console.WriteLine("Enter the path for the encrypted file to save to (either an existing file or a new file): ");
        Console.WriteLine("Please use the following example:");
        Console.WriteLine("");
        Console.WriteLine(@"C:\Users\adamp\Desktop\EncryptedFile.txt");
        Console.WriteLine();
        Console.WriteLine("Be sure to include the file extension (i.e., .txt)");
        Console.WriteLine("File Path:");
        string outputFile = Console.ReadLine();


        try
        {
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                int character;
                while ((character = reader.Read()) != -1)
                {
                    char originalChar = (char)character;
                    if (EncryptionDictionary.Dictionary.decryptionDict.ContainsKey(originalChar))
                    {
                        char encryptedChar = EncryptionDictionary.Dictionary.decryptionDict[originalChar];
                        writer.Write(encryptedChar);
                    }
                    else
                    {
                        writer.Write(originalChar); 
                    }
                }
            }

            Console.WriteLine("Encryption completed.");
            Console.ReadKey(true);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.ReadKey(true);
        }
    }

    static void DecryptFile()
    {
        Console.WriteLine("Enter the path of the encrypted file to decrypt: ");
        string inputFile = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(inputFile))
            {
                Console.WriteLine("The file decrypted reads:");
                Console.WriteLine("*************************************************************");
                Console.WriteLine();
                int character;
                while ((character = reader.Read()) != -1)
                {


                    char encryptedChar = (char)character;
                    if (EncryptionDictionary.Dictionary.encryptionDict.ContainsKey(encryptedChar))
                    {
                        char originalChar = EncryptionDictionary.Dictionary.encryptionDict[encryptedChar];

                        Console.Write(originalChar);
                    }
                    else
                    {
                        Console.Write(encryptedChar); 
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("\nDecryption completed.");

            Console.ReadKey(true);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.ReadKey(true);
        }
    }
}