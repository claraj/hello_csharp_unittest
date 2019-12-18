using System;

namespace HelloUnitTests
{
    public class NameUtilities
    {
        static public Name makeName(string nameText)
        {
            // Convert text in the form "Knowles, Beyonce" into a 
            // Name object with first = "Beyonce" and last = "Knowles"
            String text = nameText.Replace(" ", "");  // remove spaces
            String[] parts = text.Split(',');  // split on , character
            Name name = new HelloUnitTests.Name(parts[1], parts[0]);
            return name;
            // TODO - I'm sure you can think of ways to break this method
        }

        static public String fullNameString(Name name)
        {
            return name.ToString();
        }

    }
}