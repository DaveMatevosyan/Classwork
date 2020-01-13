using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    [BugFixed("Added new properties.")]
    [BugFixed(3, "Added exceptions.")]
    public class Example
    {
        [Required]
        public int MyProperty { get; set; }
        public void Method()
        {

        }

        [BugFixed(1, "Fixed Print method.")]
        [BugFixed(4, "Chnaged List to dictionary.")]
        public void Print()
        {

        }

        public static void StaticMethod()
        { }

        [BugFixed(2, "Changed DateTime to UTC.")]
        public DateTime GetCurrentDate()
        {
            return DateTime.UtcNow;
        }
    }
}
