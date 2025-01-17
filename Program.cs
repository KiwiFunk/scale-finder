//Array to hold notes
string[] notes = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

string? returnResult = null;

Console.WriteLine("Enter the root note: ");
string rootNote = Console.ReadLine().ToUpper();

//Find index of root note
int index = Array.IndexOf(notes, rootNote);

//Make sure valid note was entered 
if (index == -1)
{
    Console.WriteLine("Invalid note entered");
    return;
}

// Major Scale intervals: W, W, H, W, W, W, H
int[] majorIntervals = new int[] { 2, 2, 1, 2, 2, 2, 1 };       // Whole step = 2, Half step = 1

//Minor Scale intervals: W, H, W, W, H, W, W
int[] minorIntervals = new int[] { 2, 1, 2, 2, 1, 2, 2 };

//Create Scale starting from root note
string[] scale = new string[8];                                 //7 Notes plus the Octave
scale[0] = notes[index];                                        //Root note


bool validInput = false;
do
{
    Console.WriteLine("Major or Minor scale?");
    returnResult = Console.ReadLine();
    if (returnResult != null)
    {
        if (returnResult.ToLower().Trim() == "major")
        {
            for (int i = 1; i < 8; i++)                                     //Start from 1 as we have already set the root note
            {
                index = (index + majorIntervals[i - 1]) % notes.Length;     //Use modulus to avoid going out of bounds
                scale[i] = notes[index];                                    //Set the next note in the scale
            }
            Console.WriteLine($"The {rootNote} Major Scale is: ");
            Console.WriteLine(string.Join(" ", scale));
            validInput = true;
        }

        else if (returnResult.ToLower().Trim() == "minor")
        {
            for (int i = 1; i < 8; i++)                                     
            {
                index = (index + minorIntervals[i - 1]) % notes.Length;     
                scale[i] = notes[index];                                    
            }
            Console.WriteLine($"The {rootNote} Minor Scale is: ");
            Console.WriteLine(string.Join(" ", scale));
            validInput = true;
        }

        else Console.WriteLine("Please enter a valid input");
    }

} while (!validInput);                                                      //Loop until valid string is entered.


/*
    Add logic/method to handle sharps and flats.
*/