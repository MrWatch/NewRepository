using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08_2_
{
    public interface IStudent
    {
        string Name { get; set; }
	    string FullName { get; set; }
	    int[] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }
}
