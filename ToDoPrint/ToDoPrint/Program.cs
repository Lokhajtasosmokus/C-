using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            StringBuilder correctedTodoText = new StringBuilder(todoText);

            correctedTodoText.Insert(0,"My todo\n\t");
            correctedTodoText.Append("\t - Download games");
            correctedTodoText.Append("\n\t\t - Diablo");

            Console.WriteLine(correctedTodoText);
            Console.ReadLine();

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(todoText);
        }
    }
}