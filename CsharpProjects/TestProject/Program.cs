
//This is the incorrect way to call the next().
//int result = Random.Next(1, 7);

int firstNo= 500;
int secondNo= 600;

int largeNo= Math.Max(firstNo,secondNo);    

Console.WriteLine(largeNo);

//Create a rolling dice game with 3 dice

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int tot = roll1 + roll2 + roll3;

Console.WriteLine($"{roll1} + {roll2} + {roll3} = {tot}");

//This statement test if you rolled same number on 2 dice from the 3 dice
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){

    Console.WriteLine("You rolled doubles so add +2 to your total");
    tot+=2;
}


if (tot >= 15){

    Console.WriteLine("Yey you won!!");
} 

if (tot < 15){

    Console.WriteLine("Meh you lose!!");
} 