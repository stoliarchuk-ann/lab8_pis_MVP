using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_pis_MVP
{
    class CoursePresenter
    {
        private readonly ICourseView view;
        private readonly ICourseModel model;

    public CoursePresenter(ICourseView view, ICourseModel model)
    {
        this.view = view;
        this.model = model;
    }

    public void LoadEffective(double g, double t)
    {
        var course = new CourseModel(g, t);
        view.SetEffective(course.Effective());
    }
    }
}
