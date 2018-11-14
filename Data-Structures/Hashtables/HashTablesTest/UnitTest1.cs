using System;
using Xunit;
using Hashtables.Classes;

namespace HashTablesTest
{
    public class UnitTest1
    {
        Hashtable myTable = new Hashtable();

        /// <summary>
        /// Tests that key value pairs will be succesfully added.
        /// </summary>
        [Fact]
        public void KeyValuePairWillBeAddedTest()
        {
            myTable.Add("seal", "lion");
            Assert.Equal("seal", (string)myTable.List[246].Head.Key);
        }

        /// <summary>
        /// Tests that key collisions will be taken care of.
        /// </summary>
        [Fact]
        public void CollisionsWillBeResolvedTest()
        {
            myTable.Add("seal", "lion");
            myTable.Add("eals", "otter");
            Assert.Equal("eals", (string)myTable.List[246].Head.Next.Key);
        }
        
        /// <summary>
        /// Tests that key collisions will be taken care of.
        /// </summary>
        [Fact]
        public void SecondCollisionsWillBeResolvedTest()
        {
            myTable.Add("seal", "lion");
            myTable.Add("eals", "otter");
            myTable.Add("ales", "beer");

            Assert.Equal("ales", (string)myTable.List[246].Head.Next.Next.Key);
        }

        /// <summary>
        /// Tests that .Find will return the corresponding value to a key.
        /// </summary>
        [Fact]
        public void HashtableWillFindTest()
        {
            myTable.Add("seal", "lion");
            myTable.Add("jim", "nwen");
            myTable.Add("hydro", "pump");

            Assert.Equal("nwen", myTable.Find("jim"));
        }

        /// <summary>
        /// Tests that .Contains will return the correct output.
        /// </summary>
        [Fact]
        public void HashtableContainsTest()
        {
            myTable.Add("seal", "lion");
            myTable.Add("jim", "nwen");
            myTable.Add("hydro", "pump");

            Assert.True(myTable.Contains("hydro"));
        }
        
        /// <summary>
        /// Tests that .Contains will return the correct output.
        /// </summary>
        [Fact]
        public void SecondHashtableContainsTest()
        {
            myTable.Add("seal", "lion");
            myTable.Add("jim", "nwen");
            myTable.Add("hydro", "pump");

            Assert.True(myTable.Contains("macaroni") == false);
        }
    }
}
