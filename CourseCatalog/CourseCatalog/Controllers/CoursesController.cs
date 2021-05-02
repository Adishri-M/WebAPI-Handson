using CourseCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CourseCatalog.Controllers
{
    public class CoursesController : ApiController
    {
        static List<Course> courses = new List<Course>()
        {
            new Course() {CourseId = 1, CourseName = "Android", Trainer = "Shawn", Fees = 12000,
                          CourseDescription = "Android is a mobile operating system development" },

            new Course() {CourseId = 2, CourseName = "ASP.Net", Trainer = "Kevin", Fees = 10000,
                          CourseDescription = "ASP.Net is a open source web development framework" },

            new Course() {CourseId = 3, CourseName = "JSP", Trainer = "Debaratha", Fees = 10000,
                          CourseDescription = "Java server pages is a technology used for web page creations" },

            new Course() {CourseId = 4, CourseName = "Xamarin.forms", Trainer = "Mark John", Fees = 15000,
                          CourseDescription = "Xamarin forms are cross platform UI tools" },

        };
        public IEnumerable<Course> Get()
        {
            return courses;
        }
        public HttpResponseMessage Get(string courseName)
        {

            try
            {
                var findCourse = courses.First(p => p.CourseName == courseName);
                return Request.CreateResponse(HttpStatusCode.Found, findCourse);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Course Name not Found");
            }
        }
        public HttpResponseMessage Post([FromBody] Course course)
        {
            var searchCourse = courses.Where(p => p.CourseId == course.CourseId).FirstOrDefault();
            if (searchCourse == null)
            {
                courses.Add(course);
                return Request.CreateResponse(HttpStatusCode.Created, course);

            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Course Already Exists");
            }
        }
    }
}
