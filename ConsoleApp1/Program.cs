namespace ConsoleApp1;
 
class Program
{
    static void Main()
    {
        int examAssignments = 5;
        string studentLetterGrade = "";
 
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };
 
        int[] sophiaGrades = { 90, 86, 87, 98, 100, 91, 95 };
        int[] andrewGrades = { 92, 89, 81, 96, 90 };
        int[] emmaGrades = { 90, 85, 87, 98, 68, 91 };
        int[] loganGrades = { 90, 95, 87, 88, 96 };
 
        int[] studentGrades = new int[10];
 
        Console.WriteLine("Student\t\tGrade\n");
 
        foreach (string studentName in studentNames)
        {
            if (studentName == "Sophia")
                studentGrades = sophiaGrades;
            else if (studentName == "Andrew")
                studentGrades = andrewGrades;
            else if (studentName == "Emma")
                studentGrades = emmaGrades;
            else if (studentName == "Logan")
                studentGrades = loganGrades;
 
            int sumAssignmentGrades = 0;
            decimal studentAvgGrade = 0;
            int gradedAssignments = 0;
 
 
            foreach (int grade in studentGrades)
            {
                gradedAssignments += 1;
 
                if (gradedAssignments <= examAssignments)
                    sumAssignmentGrades += grade;
                else
                    sumAssignmentGrades += grade / 10;
            }
 
            studentAvgGrade = (decimal)(sumAssignmentGrades) / examAssignments;
            if (studentAvgGrade >= 97)
                studentLetterGrade = "A+";
            else if (studentAvgGrade >= 93)
                studentLetterGrade = "A";
            else if (studentAvgGrade >= 90)
                studentLetterGrade = "A-";
            else if (studentAvgGrade >= 87)
                studentLetterGrade = "B+";
            else if (studentAvgGrade >= 83)
                studentLetterGrade = "B";
            else if (studentAvgGrade >= 80)
                studentLetterGrade = "B-";
            else if (studentAvgGrade >= 77)
                studentLetterGrade = "C+";
            else if (studentAvgGrade >= 73)
                studentLetterGrade = "C";
            else if (studentAvgGrade >= 70)
                studentLetterGrade = "C-";
            else if (studentAvgGrade >= 67)
                studentLetterGrade = "D+";
            else if (studentAvgGrade >= 63)
                studentLetterGrade = "D";
            else if (studentAvgGrade >= 60)
                studentLetterGrade = "D-";
            else
                studentLetterGrade = "F";
 
            Console.WriteLine($"{studentName}:\t\t{studentAvgGrade}\t{studentLetterGrade}");
        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
 
    }
}
 
