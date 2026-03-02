namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> grades = new Dictionary<int, double>
        {
            { 101, 78 },
            { 102, 42 },
            { 103, 65 },
            { 104, 35 }
        };
            Func<double> averageGrade = () => grades.Values.Average();
            Console.WriteLine($"Average Grade: {averageGrade():F2}");

            Predicate<double> isAtRisk = grade => grade < 40;

            Console.WriteLine("\nAt-risk students:");
            foreach (var student in grades)
            {
                if (isAtRisk(student.Value))
                    Console.WriteLine($"Roll No: {student.Key}, Grade: {student.Value}");
            }
            grades[102] = 55;

            Console.WriteLine("\nAfter updating grade:");
            foreach (var student in grades)
            {
                string status = isAtRisk(student.Value) ? "At Risk" : "Safe";
                Console.WriteLine($"Roll No: {student.Key}, Grade: {student.Value}, Status: {status}");
            }
        }
    }
}
