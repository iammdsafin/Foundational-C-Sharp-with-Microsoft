////Notice that this code uses the new operator to specify that you're creating a new instance of an array. 
////The set of square brackets in int[] tells the compiler that sophiaScores will be an integer array, while the set of square brackets in int[5] is used to specify the number of elements in the array.
////int[] sophiaScore = new int[5];
//int currentAssignments = 5;

////int sophia1 = 90;
////int sophia2 = 86;
////int sophia3 = 87;
////int sophia4 = 98;
////int sophia5 = 100;
//int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };

////int andrew1 = 92;
////int andrew2 = 89;
////int andrew3 = 81;
////int andrew4 = 96;
////int andrew5 = 90;
//int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };

////int emma1 = 90;
////int emma2 = 85;
////int emma3 = 81;
////int emma4 = 96;
////int emma5 = 90;
//int[] emmaScores = new int[] { 90, 85, 81, 96, 30 };

////int logan1 = 90;
////int logan2 = 85;
////int logan3 = 87;
////int logan4 = 88;
////int logan5 = 96;
//int[] loganScores = new int[] { 90, 85, 87, 88, 96 };

//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//foreach (string name in studentNames)
//{
//    if (name == "Sophia")
//    {
//        int sophiaSum = 0;
//        decimal sophiaScore;

//        foreach (int score in sophiaScores)
//        {
//            sophiaSum += score;
//            //sophiaSum = sophiaSum + score;
//        }
//        sophiaScore = (decimal)(sophiaSum) / currentAssignments;
//        Console.WriteLine("Student\t\tGrade\n");
//        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//    }
//}


//Console.WriteLine("Press the Enter key to continue");
//Console.ReadLine();
////int andrewSum = 0;
////decimal andrewScore;

////andrewScore = (decimal)andrewSum / currentAssignments;

////int emmaSum = 0;
////decimal emmaScore;

////emmaScore = (decimal)emmaSum / currentAssignments;

////int loganSum = 0;
////decimal loganScore;

////loganScore = (decimal)loganSum / currentAssignments;









////sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
////andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
////emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
////loganSum = logan1 + logan2 + logan3 + logan4 + logan5;



////Console.WriteLine("Student\t\tGrade\n");
////Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
////Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
////Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

////Console.ReadLine();
///
// initialize variables - graded assignments 







// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();