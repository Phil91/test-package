namespace TestPackage.Framework;

public static class StringHelper
{
    /// <summary>
    /// This method does a nullOrWhiteSpace test and logs the result to the console
    /// </summary>
    /// <param name="stringValue">the value that should be checked</param>
    /// <returns><c>true</c> if the string is null or whitespace otherwise <c>false</c></returns>
    public static bool IsNullOrWhiteSpaceWithConsoleOutput(this string? stringValue)
    {
        var result = string.IsNullOrWhiteSpace(stringValue);
        Console.WriteLine($"string check is {result}");
        return result;
    }
}