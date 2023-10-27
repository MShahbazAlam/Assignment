using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Case_Study_MiniProject
{
    class AppEngine
    {
        static SqlConnection connection;
        public AppEngine()
        {
            connection = new SqlConnection("Data Source=ICS-LT-8ZLV6D3; Initial Catalog=Code_Challenge_6;Integrated Security = True;") ;
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                string query = "Select StudentId, StudentName, DateOfBirth FROM Students";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentId = reader.GetInt32(0);
                        string studentName = reader.GetString(1);
                        DateTime dateOfBirth = reader.GetDateTime(2);

                        students.Add(new Student
                        {
                            StudentId = studentId,
                            StudentName = studentName,
                            DateOfBirth = dateOfBirth
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error fetching students: " + ex.Message);
            }

            return students;
        }

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();

            try
            {
                string query = "Select CourseId, CourseName FROM Courses";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int courseId = reader.GetInt32(0);
                        string courseName = reader.GetString(1);

                        courses.Add(new Course
                        {
                            CourseId = courseId,
                            CourseName = courseName
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error fetching courses: " + ex.Message);
            }

            return courses;
        }

        public void RegisterStudent(Student student)
        {
            try
            {
                string insertQuery = "Insert into Student (StudentName, DateOfBirth) values (@StudentName, @DateOfBirth)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error registering student: " + ex.Message);
            }
        }

        public void IntroduceCourse(Course course)
        {
            try
            {
                string insertQuery = "Insert into Courses (CourseName) values (@CourseName)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error introducing course: " + ex.Message);
            }
        }

        public void EnrollStudentInCourse(Student student, Course course)
        {
            try
            {
                string insertQuery = "Insert into Enrollments (StudentId, CourseId, EnrollmentDate) values (@StudentId, @CourseId, @EnrollmentDate)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentId", student.StudentId);
                    cmd.Parameters.AddWithValue("@CourseId", course.CourseId);
                    cmd.Parameters.AddWithValue("@EnrollmentDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error enrolling student in the course: " + ex.Message);
            }
        }

        public List<Enroll> GetEnrollments()
        {
            List<Enroll> enrollments = new List<Enroll>();

            try
            {
                string query = "Select Student.StudentId, StudentName, DateOfBirth, Courses.CourseId, CourseName, EnrollmentDate from Student "
                                + "join Enrollments ON Student.StudentId = Enrollments.StudentId "
                                + "join Courses ON Enrollments.CourseId = Courses.CourseId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentId = reader.GetInt32(0);
                        string studentName = reader.GetString(1);
                        DateTime dateOfBirth = reader.GetDateTime(2);
                        int courseId = reader.GetInt32(3);
                        string courseName = reader.GetString(4);
                        DateTime enrollmentDate = reader.GetDateTime(5);

                        enrollments.Add(new Enroll
                        {
                            Student = new Student { StudentId = studentId, StudentName = studentName, DateOfBirth = dateOfBirth },
                            Course = new Course { CourseId = courseId, CourseName = courseName },
                            EnrollmentDate = enrollmentDate
                        });
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error fetching enrollments: " + ex.Message);
            }

            return enrollments;
        }




        public Student GetStudentById(int studentId)
        {
            try
            {
                string query = "Select StudentId, StudentName, DateOfBirth from Student where StudentId = @StudentId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentId = reader.GetInt32(0),
                                StudentName = reader.GetString(1),
                                DateOfBirth = reader.GetDateTime(2)
                            };
                        }
                        else
                        {
                            Console.WriteLine("Student not found with the specified ID.");
                            return null;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error fetching student by ID: " + ex.Message);
                return null;
            }
        }


        public Course GetCourseById(int courseId)
        {
            try
            {
                string query = "Select CourseId, CourseName from Courses where CourseId = @CourseId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CourseId", courseId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Course
                            {
                                CourseId = reader.GetInt32(0),
                                CourseName = reader.GetString(1)
                            };
                        }
                        else
                        {
                            Console.WriteLine("Course not found with the specified ID.");
                            return null;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error fetching course by ID: " + ex.Message);
                return null;
            }
        }


        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
