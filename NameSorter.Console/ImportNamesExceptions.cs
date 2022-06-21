namespace NameSorter
{
    /* Catch the exceptions thrown due to invalid data passed from unsorted-name-list.txt*/
    public class ImportNamesExceptions : Exception
    {
        public ImportNamesExceptions(string ex) : base(ex)
        {

        }
    }
}