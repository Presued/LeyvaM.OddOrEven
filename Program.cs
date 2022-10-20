//Manuel Leyva
//10-19-22
//Odd Or Even
//The user will input numbers and the code will tell it if it is odd or even
//Peer Review:

string iChoice = "";

do{
Console.Clear();
int rNum1, Nem1;
bool checkNum1;

do
{

Console.Write("Please Type a Number to check if it's Odd or Even: ");

checkNum1 = Int32.TryParse(Console.ReadLine(), out rNum1);
if (checkNum1 == false)
{
    Console.WriteLine(" That ain't a number bro, try again dude ");
}
}while(checkNum1 == false);

Nem1 = rNum1 % 2;
if (Nem1 == 0){

Console.WriteLine(rNum1 + " is an even number.\n",rNum1);

}
else{

Console.WriteLine(rNum1 + " is an odd number.\n",rNum1);

}

do
{
    Console.WriteLine("Do you wanna run the program again: Yes or No?");
    iChoice = Console.ReadLine().ToUpper();
    if(iChoice != "YES" && iChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (iChoice !="YES" && iChoice != "NO");
}while(iChoice == "YES");