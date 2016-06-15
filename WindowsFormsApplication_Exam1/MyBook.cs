using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_Exam1
{
    [Serializable]
    public class MyBook : IComparable<MyBook>
    {
        public string Author;
        public string Name;
        public decimal PageCount;
        public DateTime DateAdded;
        public bool IsPresent;
        public string Price;

        //
        // Summary:
        //     Compares the current instance with another object of the same type and returns
        //     an integer that indicates whether the current instance precedes, follows, or
        //     occurs in the same position in the sort order as the other object.
        //
        // Parameters:
        //   other:
        //     An object to compare with this instance.
        //
        // Returns:
        //     A value that indicates the relative order of the objects being compared. The
        //     return value has these meanings: Value Meaning Less than zero This instance precedes
        //     other in the sort order. Zero This instance occurs in the same position in the
        //     sort order as other. Greater than zero This instance follows other in the sort
        //     order.
        public int CompareTo(MyBook other)
        {
            if (this.DateAdded < other.DateAdded)
            {
                return -1;
            }
            else if (this.DateAdded > other.DateAdded)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return "author: " + this.Author
                + " name: " + this.Name
                + " pages: " + this.PageCount
                + " price: " + this.Price
                + " present: " + this.IsPresent
                + " date: " + this.DateAdded.ToString("D");
        }

    }
}
