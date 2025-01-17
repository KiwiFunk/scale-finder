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

//Minor Scale intervals: W, H, W, W, H, W, W

//Create Scale starting from root note

//Output the scale to the console