using System.Text;

namespace CS;

/// <summary>
/// Main class for testing C# theme colors
/// </summary>
public class Csharp
{
    // Constants
    private const int MaxHours = 24;
    private const string DefaultFormat = "HH:mm:ss";

    // Fields
    private static readonly List<string> _timeLog = new();
    private static int _callCount = 0;

    // Property with getter and setter
    public static bool VerboseMode { get; set; } = false;

    // Enum
    public enum TimeFormat
    {
        Short,
        Long,
        Military,
        Custom
    }

    // Record (C# 9.0+)
    public record TimeEntry(int Hours, int Minutes, int Seconds, DateTime Timestamp);

    // Nullable reference type
    private static TimeEntry? _lastEntry = null;

    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter hours:");
            int hours = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter minutes:");
            int minutes = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter seconds:");
            int seconds = int.Parse(Console.ReadLine() ?? "0");

            // Using various language features
            string result = FormatTime(hours, minutes, seconds);
            Console.WriteLine($"Formatted time: {result}");

            // Pattern matching (C# 8.0+)
            var message = hours switch
            {
                0 => "Midnight hour!",
                12 => "Noon time!",
                >= 6 and < 12 => "Good morning!",
                >= 12 and < 18 => "Good afternoon!",
                >= 18 and < 22 => "Good evening!",
                _ => "Good night!"
            };
            Console.WriteLine(message);

            // LINQ query
            var totalSeconds = CalculateTotalSeconds(hours, minutes, seconds);
            Console.WriteLine($"Total seconds: {totalSeconds}");

            // Interpolated verbatim string
            Console.WriteLine($@"Path example: C:\Users\{Environment.UserName}\Documents");

            // Null-coalescing operator
            _lastEntry ??= new TimeEntry(hours, minutes, seconds, DateTime.Now);

            // Collection expression (C# 12)
            _callCount++;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex) when (ex.InnerException != null)
        {
            // Exception filter
            Console.WriteLine($"Unexpected error: {ex.InnerException.Message}");
        }
        finally
        {
            Console.WriteLine("--- End of program ---");
        }
    }

    private static string FormatTime(int hours, int minutes, int seconds)
    {
        if (hours < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(hours), "Invalid hours: must be non-negative");
        }

        if (minutes < 0 || minutes > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(minutes), "Invalid minutes: must be between 0 and 59");
        }

        if (seconds < 0 || seconds > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(seconds), "Invalid seconds: must be between 0 and 59");
        }

        return $"{hours}:{minutes:D2}:{seconds:D2}";
    }

    // Method with expression body
    private static int CalculateTotalSeconds(int h, int m, int s) => (h * 3600) + (m * 60) + s;

    // Async method
    private static async Task<string> FetchTimeAsync()
    {
        await Task.Delay(100);
        return DateTime.Now.ToString("T");
    }

    // Extension method example (in separate static class)
    // Generic method
    private static T? FindValue<T>(List<T> list, Predicate<T> match) where T : class
    {
        return list.Find(match);
    }

    // Method with ref, out, and in parameters
    private static void SplitTime(int totalSeconds, out int hours, out int minutes, ref int seconds)
    {
        hours = totalSeconds / 3600;
        minutes = (totalSeconds % 3600) / 60;
        seconds = totalSeconds % 60;
    }

    // Operator overloading example
    public class TimeSpan
    {
        public int TotalSeconds { get; set; }

        public static TimeSpan operator +(TimeSpan a, TimeSpan b)
        {
            return new TimeSpan { TotalSeconds = a.TotalSeconds + b.TotalSeconds };
        }

        public static bool operator ==(TimeSpan? a, TimeSpan? b)
        {
            if (a is null || b is null) return false;
            return a.TotalSeconds == b.TotalSeconds;
        }

        public static bool operator !=(TimeSpan? a, TimeSpan? b) => !(a == b);

        public override bool Equals(object? obj) => obj is TimeSpan span && this == span;
        public override int GetHashCode() => TotalSeconds.GetHashCode();
    }

    // Interface
    public interface ITimeFormatter
    {
        string Format(int hours, int minutes, int seconds);

        // Default interface method (C# 8.0+)
        string GetDescription() => "A time formatter";
    }

    // Class implementing interface with primary constructor (C# 12)
    public class CustomTimeFormatter(string separator) : ITimeFormatter
    {
        private readonly string _separator = separator;

        public string Format(int hours, int minutes, int seconds)
        {
            return $"{hours}{_separator}{minutes:D2}{_separator}{seconds:D2}";
        }
    }

    // Abstract class
    public abstract class BaseFormatter
    {
        protected abstract string Delimiter { get; }
        public abstract string Format(int value);
    }

    // Sealed class
    public sealed class FinalFormatter : BaseFormatter
    {
        protected override string Delimiter => ":";
        public override string Format(int value) => value.ToString("D2");
    }

    // Struct
    public struct TimeStruct
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public TimeStruct(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }

        public readonly override string ToString() => $"{Hours}:{Minutes:D2}:{Seconds:D2}";
    }

    // Delegate
    public delegate bool TimeValidator(int hours, int minutes, int seconds);

    // Event
    public static event EventHandler<TimeEntry>? TimeChanged;

    // Lambda expressions and delegates
    private static readonly Func<int, int, int> Multiply = (a, b) => a * b;
    private static readonly Action<string> Log = msg => Console.WriteLine($"[LOG] {msg}");

    // Local function example
    private static void ProcessTime()
    {
        // Local function
        static bool IsValidTime(int h, int m, int s)
        {
            return h >= 0 && m is >= 0 and <= 59 && s is >= 0 and <= 59;
        }

        if (IsValidTime(10, 30, 45))
        {
            Log("Time is valid");
        }
    }
}