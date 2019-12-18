using System;
namespace HelloUnitTests
{
    public class Name
    {
        public String First { get; set; }
        public String Last { get; set; }

        public String Title { get; set; }

        public Name(String first, String last)
        {
            this.First = first;
            this.Last = last;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Title, First, Last);
        }

    }
}