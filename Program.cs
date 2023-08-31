using System;
using System.IO;
namespace Enums
{

    enum Months
    {
        Jan = 1, 
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    /// <summary>
    /// A global enum called months starts from Jan to Dec & Jan is set to 1
    /// An int in Main method called myBirthMonth is set to my birth month
    /// An int called myBirthYear is set to my the year of my birth
    /// An int called MyBirthDay is set to my day of birth
    /// The string myBirthDate is set equal to show my birthday with an interpolated message.
    /// myFile.txt is made with some text added
    /// The text in file is appeneded and displayed to console
    /// myBirthDate string is appended to the new file and text is displayed on the console
    /// 
    /// </summary>
    class Program
    {

       static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Nov;
            int myBirthDay = 17;
            int myBirthYear = 2004;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}