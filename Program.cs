namespace OOPExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.StudentName = "Gizem";
            students.StudentSurname = "Ustahüseyin";
            students.StudentGender = "Kadın";
            students.StudentNumber = 1;
            students.StudentAge = 23;
            students.StudentDepartmant = "Bilgisayar Programcılığı";

            Console.WriteLine("Öğrencinin Adı: " + students.StudentName + "\nÖğrencinin Soyadı: " + students.StudentSurname.ToUpper() + "\nÖğrencinin Cinsiyeti: " + students.StudentGender + "\nÖğrencinin Numarası: " + students.StudentNumber + "\nÖğrencinin Yaşı: " + students.StudentAge + "\nÖğrencinin Bölümü: " + students.StudentDepartmant);
            Console.ReadKey();
        }

        public class Students
        {
            public string StudentName { get; set; }
            public string StudentSurname { get; set; }
            public string StudentGender { get; set; }
            public int StudentNumber { get; set; }
            public int StudentAge { get; set; }
            public string StudentDepartmant { get; set; }
        }
    }
}