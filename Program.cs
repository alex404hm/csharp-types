DotNetEnv.Env.Load();

var filePath = Environment.GetEnvironmentVariable("FILE_PATH");
WordCounter counter = new WordCounter();

Console.Write("Hvilket ord skal jeg søge på? ");
string searchWord = Console.ReadLine();

Console.Write("Angiv teksten der skal søges i: ");
string textSearch = Console.ReadLine();

int wordCount = counter.CountWords(searchWord, textSearch);
bool? result = counter.StatementCount(wordCount);

if (result == null)
{
    Console.WriteLine("Det søgte ord findes ikke i den angivne tekst.");
}

if (result == false)
{
    Console.WriteLine($"Ordet '{searchWord}' forekommer {wordCount} gange.");
}

if (result == true)
{
    Console.WriteLine($"Ordet '{searchWord}' forekommer {wordCount} gange.");
    await File.WriteAllTextAsync(filePath, textSearch);
}