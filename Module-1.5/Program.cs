int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
int sophiaSum = sophia1+sophia2+sophia3+sophia4+sophia5;
decimal sophiaScore = (decimal)sophiaSum /currentAssignments;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
int nicolasSum = nicolas1 + nicolas2+nicolas3+nicolas4+nicolas5;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;


int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
int zahiraSum = zahirah1+zahirah2+zahirah3+zahirah4+zahirah5;
decimal zahiraScore = (decimal)zahiraSum / currentAssignments;


int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
int jeongSum = jeong1+jeong2+jeong3+jeong4+jeong5;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Total marks of Sophia: " +sophiaScore + " A ");
Console.WriteLine("Total marks of Nicolas: " +nicolasScore + " B ");
Console.WriteLine("Total masrks of Zahira: " +zahiraScore + " B ");
Console.WriteLine("Total marks of Jeong: " + jeongScore + " A ");