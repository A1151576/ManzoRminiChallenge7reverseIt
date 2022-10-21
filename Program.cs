/*                      Rafael Manzo
                Mini Challenge 7 "reverse it" 
                            10/20/2022
    In this program we will be aking the user for a numerical value, we will then reverse it and
    display it back to them.
    */Console.Clear();

bool playover = true;

while (playover)
{

    Console.WriteLine("Hello, Enter a numerical value and I will reverse it for you.");

           int  n, reverse=0, rem;           
       Console.Write("Enter a number: ");      
       n= int.Parse(Console.ReadLine());     
       while(n!=0)      
       {      
        rem=n%10;        
        reverse=reverse*10+rem;      
        n/=10;      
       }      
       Console.Write("Reversed Number: "+reverse+". ");       

       Console.WriteLine(" Would you like to play again? type no to quit or any key to play again.");
    string answer01 = Console.ReadLine();
    if (answer01 == "no")
    {
        playover = false;
}
   
    }