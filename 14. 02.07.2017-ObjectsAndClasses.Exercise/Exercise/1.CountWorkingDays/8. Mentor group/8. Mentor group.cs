namespace _8._1.Mentor_group
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var userList = new List<Student>();

            Dictionary<string, List<DateTime>> dateAttendencyDict = new Dictionary<string, List<DateTime>>();
            Dictionary<string, List<string>> commentsDict = new Dictionary<string, List<string>>();

            /// Read dates
            string date = Console.ReadLine();
            while (date != "end of dates")
            {
                string[] dateArr = date.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string studentName = dateArr[0];

                if (dateArr.Length == 1)
                {
                    if (!dateAttendencyDict.ContainsKey(studentName))
                    {
                        dateAttendencyDict[studentName] = new List<DateTime>();
                    }
                }
                else
                {
                    List<DateTime> currStudentDatesList = new List<DateTime>();

                    for (int i = 1; i < dateArr.Length; i++)
                    {
                        currStudentDatesList.Add(DateTime.ParseExact(dateArr[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }

                    Student currStudent = new Student
                    {
                        Name = studentName,
                        Date = currStudentDatesList
                    };

                    if (!dateAttendencyDict.ContainsKey(currStudent.Name))
                    {
                        dateAttendencyDict[currStudent.Name] = new List<DateTime>();
                    }

                    dateAttendencyDict[currStudent.Name].AddRange(currStudent.Date);
                }
                
                date = Console.ReadLine();
            }

            /// Read comments
            string comments = Console.ReadLine();
            while (comments != "end of comments")
            {
                string[] commentsArr = comments.Split('-');

                string studentName = commentsArr[0];
                if (commentsArr.Length == 1)
                {
                    if (!dateAttendencyDict.ContainsKey(studentName))
                    {
                        comments = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    string studentComment = commentsArr[1];

                    List<string> currComment = new List<string>();
                    currComment.Add(studentComment);

                    Student currStudentComment = new Student
                    {
                        Name = studentName,
                        Comment = currComment
                    };

                    if (dateAttendencyDict.ContainsKey(studentName))
                    {
                        if (!commentsDict.ContainsKey(studentName))
                        {
                            commentsDict[studentName] = new List<string>();
                        }

                        commentsDict[studentName].AddRange(currStudentComment.Comment);
                    }
                }

                comments = Console.ReadLine();
            }

            /// Print result
            foreach (var user in dateAttendencyDict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                Console.WriteLine("Comments:");

                foreach (var student in commentsDict.Where(x => x.Key == user.Key))
                {
                    Console.WriteLine($"- {string.Join(Environment.NewLine + "- ", student.Value)}");
                }

                Console.WriteLine("Dates attended:");

                if (user.Value.ToList().Count > 0)
                {
                    Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", user.Value.OrderBy(x => x.Date).Select(y => y.Date.ToString("dd/MM/yyyy")))}");
                }
            }
        }
    }
}
