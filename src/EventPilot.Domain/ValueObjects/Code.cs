using System.Text.RegularExpressions;

namespace EventPilot.Domain.ValueObjects;

public class Code : IEquatable<Code>
{
    public string Value { get; }

    private Code(string value)
    {
        Value = value;
    }

    public static Code Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Code can't be empty.");

        // Validation
        if (!Regex.IsMatch(value, @"^[A-Z]{2}-\d{3}$"))
            throw new ArgumentException("Invalid code format. Expected: XX-123");

        return new Code(value);
    }

    
    public static Code GenerateRandom()
    {
        var letters = $"{RandomLetter()}{RandomLetter()}";
        var numbers = Random.Shared.Next(0, 1000).ToString("000");
        return Code.Create($"{letters}-{numbers}");
    }

    private static char RandomLetter()
    {
        return (char)Random.Shared.Next('A', 'Z' + 1);
    }
    
    
    
    // EF Core needs a private and empty ctor
    private Code() { }

    public bool Equals(Code other) =>
        other is not null && Value == other.Value;

    public override bool Equals(object obj) => Equals(obj as Code);
    public override int GetHashCode() => Value.GetHashCode();
    public override string ToString() => Value;
}