namespace NameSorter
{
    public class ImportUnsortedList
    {
        public static List<Person> ImportList(string filePath)
        {
            /*Read list of names from file and populate a list of string*/
            List<string> lines = new List<string>();
            try
            {
                lines = File.ReadAllLines(filePath).ToList();
            }
            catch (Exception)
            {
                throw new ImportNamesExceptions("File of unsorted names is not found");

            }

            /*Check the number of names submitted per person as a person
             * must have a last name and a minimum of one given name and a 
             * maximum of three given names*/

            List<Person> people = new List<Person>();
            foreach (string line in lines)
            {
                string[] entires = line.Split(' ');
                Person newPerson;
                switch (entires.Length)
                {
                    case 0:
                        throw new ImportNamesExceptions("Empty line provided in list");

                    case 1:
                        throw new ImportNamesExceptions("A Person must have atleast one given name and one last name");

                    case 2:
                        newPerson = new Person(entires[0], entires[1]);

                        break;
                    case 3:
                        newPerson = new Person(entires[0], entires[1], entires[2]);
                        break;
                    case 4:
                        newPerson = new Person(entires[0], entires[1], entires[2], entires[3]);
                        break;
                    default:
                        throw new ImportNamesExceptions("A Person may only have upto 3 given names");

                }
                people.Add(newPerson);
            }
            return people;

        }
    }
}