/**The program will take a file path to file that contains a list of unsorted names and 
order that set first by last name, then by any given names the person may have. A
name must have at least 1 given name and may have up to 3 given names*/

namespace NameSorter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            /*Check if an argument was passed when executing the application*/
            string filepath;
            if (args.Length == 1)
            {
                filepath = args[0];
            }
            else
            {
                throw new ImportNamesExceptions("Input file path not specified");
            }

            var unsortedpeople = ImportUnsortedList.ImportList(filepath);
            var sortedPeople = SortList.SortNames(unsortedpeople);
            ExportSortedList.ExportList(sortedPeople);
            StandardMessages.ExitMessage();
            Console.ReadLine();

        }
    }
}