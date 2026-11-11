using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_pis_MVP
{
    class CourseModel : ICourseModel
    {
        double grade;
        double time_studying;
        public CourseModel(double g, double t)
        {
            grade = g;
            time_studying = t;
        }
        public CourseModel()
        {
            grade = 10;
            time_studying = 4;
        }
        public double Effective()
        {
            return grade / time_studying;
        }
    }
}
