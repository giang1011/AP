using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Menu
    {
        private GenericManager<Student> studentManager = new GenericManager<Student>();

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- STUDENT MANAGEMENT MENU ---");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. List");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ListStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Please choose from 1 to 5.");
                        break;
                }
            } while (choice != 5);
        }

        private void AddStudent()
        {
            int id = ReadIntInput("Enter ID: ");
            string name = ReadNonEmptyString("Enter Name: ");
            int age = ReadValidAge("Enter Age: ");

            studentManager.Add(new Student { Id = id, Name = name, Age = age });
            Console.WriteLine("Student added successfully!");
        }

        private void ListStudents()
        {
            var students = studentManager.GetAll();
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            students.ForEach(Console.WriteLine);
        }

        private void UpdateStudent()
        {
            int id = ReadIntInput("Enter the ID of the student to update: ");
            var students = studentManager.GetAll();
            var index = students.FindIndex(s => s.Id == id);

            if (index == -1)
            {
                Console.WriteLine("Student not found with this ID.");
                return;
            }

            string name = ReadNonEmptyString("Enter new Name: ");
            int age = ReadValidAge("Enter new Age: ");

            studentManager.Update(index, new Student { Id = id, Name = name, Age = age });
            Console.WriteLine("Student updated successfully!");
        }

        private void DeleteStudent()
        {
            int id = ReadIntInput("Enter the ID of the student to delete: ");
            var students = studentManager.GetAll();
            var index = students.FindIndex(s => s.Id == id);

            if (index == -1)
            {
                Console.WriteLine("Student not found with this ID.");
                return;
            }

            studentManager.Delete(index);
            Console.WriteLine("Student deleted successfully!");
        }
        private int ReadIntInput(string message)
        {
            int value;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out value) && value > 0)
                    return value;

                Console.WriteLine("Please enter a valid positive number.");
            } while (true);
        }

        private string ReadNonEmptyString(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input))
                    return input;

                Console.WriteLine("Input cannot be empty.");
            } while (true);
        }

        private int ReadValidAge(string message)
        {
            int age;
            do
            {
                age = ReadIntInput(message);

                if (age >= 18 && age <= 100)
                    return age;

                Console.WriteLine("Please enter a valid age between 18 and 100.");
            } while (true);
        }
    }
}
