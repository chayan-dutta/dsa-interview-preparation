using Arrays;

Console.WriteLine(" ----------------- Array Problems ----------------- ");

int[] arr = [1, 2, 2, 3, 1, 4, 2, 3];
Dictionary<int, int> frequency = FrequencyOfElements.GetFrequency(arr);

foreach (var kvp in frequency)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}

Console.WriteLine("------------- Lets test using LINQ ---------------------");
var freq = FrequencyOfElementsUsingLinq.GetFrequency(arr);

foreach (var kvp in freq)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}

int[] duplicateArr = [1, 2, 2, 3, 1, 4, 2, 3, 4, 7,9,7, 9, 1];

Console.WriteLine("-------- Finding duplicates in the array ----------");

var duplicates = DuplicateElements.GetDuplicateElements(duplicateArr);

foreach(var i in duplicates)
    Console.WriteLine(i);