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
int[] majorIntervals = new int[] { 2, 2, 1, 2, 2, 2, 1 };       // Whole step = 2, Half step = 1

//Minor Scale intervals: W, H, W, W, H, W, W
int[] minorIntervals = new int[] { 2, 1, 2, 2, 1, 2, 2 };

//Create Scale starting from root note
string[] scale = new string[8];                                 //7 Notes plus the Octave
scale[0] = notes[index];                                        //Root note

for (int i = 1; i < 8; i++)                                     //Start from 1 as we have already set the root note
{
    index = (index + majorIntervals[i - 1]) % notes.Length;     //Calculate the index of the next note
    scale[i] = notes[index];                                    //Set the next note in the scale
}

//Output the scale to the console
Console.WriteLine($"The {rootNote} Major Scale is: ");
Console.WriteLine(string.Join(" ", scale));