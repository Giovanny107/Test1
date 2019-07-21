using System.Collections.Generic;
using System.Linq;
using Test2.Models;

namespace Test2.Process
{
    public class Filtered
    {
        public List<Student> FilterMarks(List<Student> students, int mark)
        {
            return students.OrderBy(x => x.Language > mark && x.Maths > mark && x.Science > mark && x.Social > mark).ToList();
        }

        public List<Student> FilterNames(List<Student> students)
        {
            return students.OrderBy(x => x.Name).ToList();
        }

        public List<Student> FilterMix(List<Student> students, int mark, string name)
        {
            return students.OrderBy(x => x.Name.Equals(name) && x.Language > mark && 
                                    x.Maths > mark && x.Science > mark && x.Social > mark).ToList();          
        }
    }
}
