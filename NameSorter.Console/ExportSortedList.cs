namespace NameSorter
{
    /* Print the sorted list of names to screen and write/overwrite the sorted list of names to a file called sorted-names-list.txt.*/

    public class ExportSortedList
    {
        public static void ExportList(List<Person> sortedpeople)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\sorted-names-list.txt";
            List<string> output = new List<string>();
            foreach (Person sortedPerson in sortedpeople)
            {

                output.Add(sortedPerson.FullName());
                Console.WriteLine(sortedPerson.FullName());
                try
                {
                    File.WriteAllLines(path, output);

                }
                catch (IOException)
                {
                    throw new ExportNamesException("Was unable to write to the file.");

                }
            }
        }
    }
}