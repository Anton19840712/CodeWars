namespace AnyLevel;

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
				var newElement = string.Join("", word.Reverse());
				elements[i] = newElement;
			}
		}

		var newSentence = string.Join(" ", elements);
		Console.WriteLine(newSentence);
		return newSentence;

	}
}