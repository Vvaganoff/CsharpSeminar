// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input 2 numbers: ");

int Number1 = Convert.ToInt32( Console.ReadLine() );
int Number2 = Convert.ToInt32( Console.ReadLine() );
if (Number1 == Number2 * Number2) {
    Console.WriteLine( "Yes" );
} else
{
    Console.WriteLine( "No" );
}


