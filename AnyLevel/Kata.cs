namespace AnyLevel;
//short memory refresher:
//to reverse word use element.Reverse
//to join words use string.Join(" ", wordsArray)

public class Kata
{
	public static string SpinWords(string sentence)
	{
		var elements = sentence.Split(" ");

		for (int i = 0; i < elements.Length; i++)
		{
			var word = elements[i];
			if (word.Length > 5)
			{
				var newElement = string.Join("", word.Reverse());//forget about string reverse.
				elements[i] = newElement;
			}
		}

		var newSentence = string.Join(" ", elements);//forget about string join.
		Console.WriteLine(newSentence);
		return newSentence;
	}

	//alternative:
	//var newSentence = string.Join(" ",
	//	sentence.Split(" ")
	//		.ToList()
	//		.Select(x => x.Length >= 5 ? string.Join("", x.Reverse()) : x));// use select instead of foreach, because you create a new one instance.
	//Console.WriteLine(newSentence);
	//return newSentence;
}