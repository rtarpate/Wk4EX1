using System.Net.Http.Headers;
//decalres variable for new number for array
int nNumber = 0;

//decalres variablle for user input
int Userinput = 0;

//decalres variable for the total sum
int totalsum = 0;

//declares variabel for max value
int MaxValue =Int32.MinValue;

//declares variabel for min value
int MinValue = Int32.MaxValue;

//creates int array and makes it null so to slove for totalsum
int[] UserArray = null;

//decalres variable for reverser array
int[] ReverseUserArray;

while (true)
{

    //use try and catch to make sure user input is valid
    try
    {

        //promt user to make a choice of what they want to do
        Console.WriteLine(" type 1 to access the array or press 2 to exit the program ");

        //collects and coverts user input
        Userinput = Convert.ToInt32(Console.ReadLine());

        if (Userinput == 1)
        {

            //promts user to creat the size of the array
            Console.WriteLine(" enter the size of the array ");

            //collects user input and converts it 
            nNumber = Convert.ToInt32(Console.ReadLine());

            //makes the array with the number of enter determinde by the user
            UserArray = new int[nNumber];

            //uses for loop to promt usre for the aray values
            for (int i = 0; i < nNumber; i++)
            {
                //promt user input for array values
                Console.WriteLine(" enter an value to add to the array " + (i + 1) + ":");

                //collects user input adds it to 
                UserArray[i] = Convert.ToInt32(Console.ReadLine());

            }


        }
        else if (Userinput == 2)
        {
            //prints that user exits the program
            Console.WriteLine(" you have exited the program");
            break;
        }

    }
    catch (Exception ex)
    {
        //prints if user input is invalid
        Console.WriteLine(" user input was invalid please input a valid input ");
    }

}

//sloves for the total sum of the array
for (int i = 0; i < UserArray.Length; i++)
{
    totalsum += UserArray[i];
}

//sloves for max value
for (int i = 0; i < UserArray.Length; i++)
{
    
    //checks to see if currernt max value is greater then whats in the user array
    if (UserArray[i] > MaxValue)
    {
        //changes the value of max value equal to user array
        MaxValue = UserArray[i];
    }
}

//sloves for min value
for (int i = 0; i < UserArray.Length; i++)
{
    //checks to see what the min value is less than array
    if (UserArray[i] < MinValue)
    {

        //changes min value if less than user array
        MinValue = UserArray[i];

    }

}

//revers the aray
ReverseUserArray = UserArray;

Array.Reverse(ReverseUserArray);


//prints out results
Console.WriteLine(" results of the array");

//prints all elements of the array
Console.WriteLine(UserArray);

//prints the total sum of the array
Console.WriteLine( " that total sum of the array is ");
Console.WriteLine(totalsum);

//prints the maxium of the array
Console.WriteLine(" the max value is");
Console.WriteLine(MaxValue);

//prints the minum of the array
Console.WriteLine(" the minum is ");
Console.WriteLine(MinValue);

//prints the revers of the array
Console.WriteLine(" the arry reversed is ");
Console.WriteLine(ReverseUserArray);

Console.ReadLine();