using System;
using System.Collections.Generic;
using System.Linq;

namespace BTVN
{
    // Định nghĩa lớp Student
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }

    internal static class Program
    {
        public static void Main()
        {
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Hoang Minh", Age = 16 },
                new Student { Id = 2, Name = "Kieu Dung", Age = 14 },
                new Student { Id = 3, Name = "Nguyen Thi Lanh", Age = 17 },
                new Student { Id = 4, Name = "Minh Quang", Age = 19 },
                new Student { Id = 5, Name = "Van Manh", Age = 15 },
                new Student { Id = 5, Name = "An Lanh", Age = 15 },

            };

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("a.Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("b.Danh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in ageRangeStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var nameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("c.Danh sach hoc sinh có ten bat dau bang chu cai 'A':");
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"d.Tong tuoi cua tat ca sing vien: {totalAge}");

            Console.WriteLine();

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("e.Hoc sing co so tuoi lon nhat:");
            Console.WriteLine(oldestStudent);

            Console.WriteLine();

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sortedByAge = students.OrderBy(s => s.Age);
            Console.WriteLine("f.Danh sach hoc sinh theo thu tu tuoi tang dan la:");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine(student);
            }
        }
    }
}


