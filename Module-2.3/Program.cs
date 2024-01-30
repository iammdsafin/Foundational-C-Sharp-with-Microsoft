////Notice that the if statement is made up of three parts:

////The if keyword
////A Boolean expression between parenthesis ()
////A code block defined by curly braces { }
////A Boolean expression is any code that returns a Boolean value, either true or false.

////Recap
////The combination of if and else statements allows you to test for one condition, and then perform one of two outcomes. The code block for the if will be run when the Boolean expression is true, and the code block for the else will be run when the Boolean expression is false.
////You can nest if statements to narrow down a possible condition. However, you should consider using the if, else if, and else statements instead.
////Use else if statements to create multiple exclusive conditions.
////An else is optional, but it must always come last when included.


//Random dice = new();

//int rollout_one = dice.Next(1, 7);
//int rollout_two = dice.Next(1, 7);
//int rollout_three = dice.Next(1, 7);
//int totalwithbonus;

//int total = rollout_one + rollout_two + rollout_three;
//Console.WriteLine($"Dice roll: {rollout_one} + {rollout_two} + {rollout_three} = {total}");

//if ((rollout_one == rollout_two) || (rollout_two == rollout_three) || (rollout_one == rollout_three))
//{
//    if ((rollout_one == rollout_two) && (rollout_two == rollout_three))
//    {
//        Console.WriteLine("Ypu rolled thrice! +6 bonus to total");
//        totalwithbonus = total + 6;
//        Console.WriteLine($"Your final total is {totalwithbonus}");
//    } else 
//    {
//        Console.WriteLine("You rolled doubles! +2 bonus to total");
//        totalwithbonus = total + 2;
//        Console.WriteLine($"Your final total is {totalwithbonus}");
//    }
//}

//if (total >= 15)
//{
//    Console.WriteLine("Congratulations you won!");
//}
//else if (total >= 10)
//{
//    Console.WriteLine("Okay you are not a loser.");
//}
//else
//{
//    Console.WriteLine("Please try again.");
//}


////==, the "equals" operator, to test for equality
////>, the "greater than" operator, to test that the value on the left is greater than the value on the right
////<, the "less than" operator, to test that the value on the left is less than the value on the right
////>=, the "greater than or equal to" operator
////<=, the "less than or equal to" operator

//string message = "A quick brown fox jumps over the lazy dog";
//bool result = message.Contains("dog");
//Console.WriteLine(message);

//if (message.Contains("bird"))
//{
//    Console.WriteLine("What does the fox says");
//}
//else {
//    Console.WriteLine("No fox found");
//}


////What is a code block?
////A code block is a collection of one or more lines of code that are defined by an opening and closing curly brace symbol { }.
////It represents a complete unit of code that has a single purpose in your software system. In this case, at runtime, all lines of code in the code block are executed if the Boolean expression is true. Conversely, if the Boolean expression is false, all lines of code in the code block are ignored.

////Recap ->
////Use an if statement to branch your code logic. The if decision statement will execute code in its code block if its Boolean expression equates to true. Otherwise, the runtime will skip over the code block and continue to the next line of code after the code block.
////A Boolean expression is any expression that returns a Boolean value.
////Boolean operators will compare the two values on its left and right for equality, comparison, and more.
////A code block is defined by curly braces { }. It collects lines of code that should be treated as a single unit.
////The logical AND operator && aggregates two expressions so that both subexpressions must be true in order for the entire expression to be true.
////The logical OR operator || aggregates two expressions so that if either subexpression is true, the entire expression is true.


Random random = new ();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0) 
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}