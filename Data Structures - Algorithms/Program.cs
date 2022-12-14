using Data_Structures___Algorithms.GoogleInterview;
using Data_Structures_and_Algorithms.Big0;

#region Big0 Lecture Notes

string[] names = { "nemo" };string[] moreNames = { "random", "another", "Justin" };var big0 = new Big0();big0.findNemo(names);big0.findNemo(moreNames);int[] boxes = { 0, 1, 2, 3, 4, 5 };big0.logFirstTwoBoxes(boxes);big0.arrayPairs(boxes);big0.rules();
big0.goodCode();

big0.spaceComplexity(boxes);

big0.exercise();

#endregion Big0 Lecture Notes

#region Google Interview Video

var google = new InterviewQuestion();

google.interview();
Console.WriteLine(google.interview02());

//setting up the problem to take in two arrays here first.
string[] array01 = { "a", "b", "c", "x" };
string[] array02 = { "z", "y", "i" };
Console.WriteLine(google.interveiew02Answer(array01, array02));

#endregion Google Interview Video