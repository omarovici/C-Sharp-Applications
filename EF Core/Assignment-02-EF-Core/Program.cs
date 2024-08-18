using Assignment_02_EF_Core.Contexts;
using Assignment_02_EF_Core.Entities;

namespace Assignment_02_EF_Core;

class Program
{
    static void Main(string[] args)
    {
        // Do CRUD operations on all tables 

        #region CRUD operations

        using (ITIDbContext context = new ITIDbContext())
        {
            #region Topic
            
            // Topic topic = new Topic()
            // {
            //     Name = "C#",
            // };
            // Console.WriteLine(context.Entry(topic).State); // Detached
            // context.Add(topic);
            // Console.WriteLine(context.Entry(topic).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(topic).State); // Unchanged
            // topic = context.Topic.Find(4);
            // if (topic != null)
            // {
            //     topic.Name = "Java";
            //     Console.WriteLine(context.Entry(topic).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            #endregion

            #region Course

            // Course course = new Course()
            // {
            //     Duration = 10,
            //     Name = "Fundmentals of C#",
            //     Description = "C# Course",
            //     TopicId = 3,
            // };

            // Console.WriteLine(context.Entry(course).State); // Detached
            // context.Add(course);
            // Console.WriteLine(context.Entry(course).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(course).State); // Unchanged
            // course = context.Course.Find(2);
            // if (course != null)
            // {
            //     course.Duration = 20;
            //     Console.WriteLine(context.Entry(course).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }

            #endregion

            #region Instructor

            // Instructor instructor = new Instructor()
            // {
            //     Name = "Ahmed",
            //     Address = "Cairo",
            //     Bonus = 1000,
            //     HourRate = 100,
            //     Salary = 10000
            // };

            // Console.WriteLine(context.Entry(instructor).State); // Detached
            // context.Add(instructor);
            // Console.WriteLine(context.Entry(instructor).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(instructor).State); // Unchanged
            // instructor = context.Instructor.Find(1);
            // if (instructor != null)
            // {
            //     instructor.Salary = 20000;
            //     Console.WriteLine(context.Entry(instructor).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }

            #endregion

            #region Department

            // Department department = new Department()
            // {
            //     Name = "ITI",
            //     HiringDate = DateTime.Now,
            //     InstructorId = 1
            // };
            // Console.WriteLine(context.Entry(department).State); // Detached
            // context.Add(department);
            // Console.WriteLine(context.Entry(department).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(department).State); // Unchanged
            // department = context.Department.Find(1);
            // if (department != null)
            // {
            //     department.Name = "ITI2";
            //     Console.WriteLine(context.Entry(department).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }

            #endregion

            #region Student

            // Student student = new Student()
            // {
            //     FName = "Ahmed",
            //     LName = "Ali",
            //     Age = 20,
            //     Address = "Cairo",
            //     DepartmentId = 1
            // };
            // Console.WriteLine(context.Entry(student).State); // Detached
            // context.Add(student);
            // Console.WriteLine(context.Entry(student).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(student).State); // Unchanged
            // student = context.Student.Find(3);
            // if (student != null)
            // {
            //     student.FName = "Omar";
            //     Console.WriteLine(context.Entry(student).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }

            #endregion

            #region StudentCourse

            // Stud_Course studCourse = new Stud_Course()
            // {
            //     CourseId = 2,
            //     StudentId = 3,
            //     Grade = 100
            // };

            // Console.WriteLine(context.Entry(studCourse).State); // Detached
            // context.Add(studCourse);
            // Console.WriteLine(context.Entry(studCourse).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(studCourse).State); // Unchanged
            //
            // studCourse = context.Stud_Course.Find(3,2);
            // if (studCourse != null)
            // {
            //     studCourse.Grade = 80;
            //     Console.WriteLine(context.Entry(studCourse).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            #endregion

            #region CourseInstructor

            // Course_Inst courseInst = new Course_Inst()
            // {
            //     CourseId = 2,
            //     InstructorId = 1,
            //     Evaluate = 100
            // };
            // Console.WriteLine(context.Entry(courseInst).State); // Detached
            // context.Add(courseInst);
            // Console.WriteLine(context.Entry(courseInst).State); // Added
            // context.SaveChanges();
            // Console.WriteLine(context.Entry(courseInst).State); // Unchanged

            // courseInst = context.Course_Inst.Find(2,1);
            // if (courseInst != null)
            // {
            //     courseInst.Evaluate = 80;
            //     Console.WriteLine(context.Entry(courseInst).State); // Modified
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }

            #endregion

            #region Remove from all tables

            // Course_Inst courseInst = context.Course_Inst.Find(2,1);
            // if (courseInst != null)
            // {
            //     context.Remove(courseInst);
            //     Console.WriteLine(context.Entry(courseInst).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            // Stud_Course studCourse = context.Stud_Course.Find(3,2);
            // if (studCourse != null)
            // {
            //     context.Remove(studCourse);
            //     Console.WriteLine(context.Entry(studCourse).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            // Student student = context.Student.Find(3);
            // if (student != null)
            // {
            //     context.Remove(student);
            //     Console.WriteLine(context.Entry(student).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            // Department department = context.Department.Find(1);
            // if (department != null)
            // {
            //     context.Remove(department);
            //     Console.WriteLine(context.Entry(department).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            // Instructor instructor = context.Instructor.Find(1);
            // if (instructor != null)
            // {
            //     context.Remove(instructor);
            //     Console.WriteLine(context.Entry(instructor).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            // Course course = context.Course.Find(2);
            // if (course != null)
            // {
            //     context.Remove(course);
            //     Console.WriteLine(context.Entry(course).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }
            
            // Topic topic = context.Topic.Find(3);
            // if (topic != null)
            // {
            //     context.Remove(topic);
            //     Console.WriteLine(context.Entry(topic).State); // Deleted
            //     context.SaveChanges();
            // }
            // else
            // {
            //     Console.WriteLine("not found.");
            // }

            #endregion
        }

        #endregion
    }
}