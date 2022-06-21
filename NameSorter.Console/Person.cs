namespace NameSorter
{
    /*A person should have atleast one given name and a last name and can have a max of three given names*/
    public class Person
    {
        public string givenName1 { get; set; }
        public string givenName2 { get; set; }
        public string givenName3 { get; set; }
        public string lastName { get; set; }

        public Person() { }
        public Person(string givenName1, string lastName)
        {
            this.givenName1 = givenName1;
            this.lastName = lastName;
        }
        public Person(string givenName1, string givenName2, string lastName)
        {
            this.givenName1 = givenName1;
            this.givenName2 = givenName2;
            this.lastName = lastName;
        }
        public Person(string givenName1, string givenName2, string givenName3, string lastName)
        {
            this.givenName1 = givenName1;
            this.givenName2 = givenName2;
            this.givenName3 = givenName3;
            this.lastName = lastName;

        }
        public string FullName()
        {

            string personNameWithSpaces = $"{givenName1} {givenName2} {givenName3} {lastName}";
            string personName = personNameWithSpaces.Replace(" ", "()").Replace(")(", "").Replace("()", " ");
            return personName;


        }

    }
}