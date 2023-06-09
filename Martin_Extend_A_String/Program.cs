using Martin_Extend_A_String;

Console.WriteLine("Is racecar a palindrome: " + StringExtensions.IsPalindrome("racecar"));
Console.WriteLine("Is testing a palingdrome: " + StringExtensions.IsPalindrome("testing"));
Console.WriteLine("If this is case sensitive is Racecar a palingdrome: " + StringExtensions.IsPalindrome("testing", true));
Console.WriteLine("Is this a reverse string of Sure : " + StringExtensions.ReverseString("Sure"));
Console.WriteLine("Is this a reverse string of Sure and did capitalization stay in the same spot? : " + StringExtensions.ReverseString("Sure", true));
Console.WriteLine("Does this remove duplicates of Lets Pets Bets?: " + StringExtensions.RemoveDuplicates("Lets Pets Bets"));
Console.WriteLine("How much does J appear in Jordan?: " + StringExtensions.CountOccurrences("Jordan", 'J'));
Console.WriteLine("How much does an appear in Bananas?: " + StringExtensions.CountOccurrences("Bananas", "an"));
Console.WriteLine("Whats the count of the min letter to occur in Joorrddaann?:" + StringExtensions.CountOccurrences("Joorrddaann", OccurrenceType.MinOccurrence));
Console.WriteLine("Whats the count of the max letter to occur in Joorrddaannn?:" + StringExtensions.CountOccurrences("Joorrddaannn", OccurrenceType.MaxOccurrence));
Console.WriteLine("Whats the count of the min vowel to occur in Joordan?:" + StringExtensions.CountOccurrences("Joordan", OccurrenceType.MinOccurrenceVowels));
Console.WriteLine("Whats the count of the max vowel to occur in Joordan?:" + StringExtensions.CountOccurrences("Joordan", OccurrenceType.MaxOccurrenceVowels));