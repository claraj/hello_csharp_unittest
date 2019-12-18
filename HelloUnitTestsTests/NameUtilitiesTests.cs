using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUnitTests.Tests
{
    [TestClass()]
    public class NameUtilitiesTests
    {
        [TestMethod()]
        public void makeNameTestFirstLast()
        {
            String example = "Knowles, Beyonce";
            Name name = NameUtilities.makeName(example);
            Assert.AreEqual(name.First, "Beyonce");
            Assert.AreEqual(name.Last, "Knowles");
        }

        [TestMethod()]
        public void makeNameTestSpecialChars()
        {
            String example = "Knowles-Carter, Beyonce ";
            Name name = NameUtilities.makeName(example);
            Assert.AreEqual(name.First, "Beyonce");
            Assert.AreEqual(name.Last, "Knowles-Carter");
        }

        [TestMethod()]
        public void makeNameTestOnlyFirst()
        {
            // This test fails - the makeName method throws an exception
            // The makeName method needs to be fixed 
            String example = "Beyonce";
            Name name = NameUtilities.makeName(example);
            Assert.AreEqual(name.First, "Beyonce");
            Assert.AreEqual(name.Last, null);
        }


        [TestMethod()]
        public void generateFullNameString()
        {
            Name test = new Name("Kanye", "West");
            test.Title = "Mr.";
            Assert.AreEqual("Mr. Kanye West", NameUtilities.fullNameString(test));
        }

    }
}