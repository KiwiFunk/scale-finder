//Array to hold notes
string[] notes = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };


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
int[] majorIntervals = new int[] { 2, 2, 1, 2, 2, 2, 1 };   // Whole step = 2, Half step = 1

//Minor Scale intervals: W, H, W, W, H, W, W
int[] minorIntervals = new int[] { 2, 1, 2, 2, 1, 2, 2 };

//Create Scale starting from root note

//Output the scale to the console