namespace Lovers;

public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "unknown";
    }

    // Constructor that takes one argument:
    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}

public class Class1
{
    static void Main()
    {
        // Call the constructor that has one parameter.
        var person2 = new Person("Sarah Jones");
        Console.WriteLine(person2.Name);
        // Get the string representation of the person2 instance.
        Console.WriteLine(person2);


	string accessKey = Environment.GetEnvironmentVariable("MESSAGEBIRD_ACCESS_KEY");
	MessageBird.Client client = MessageBird.Client.CreateDefault(accessKey);
	Console.WriteLine(client.Balance());

	Console.WriteLine(SillyLib.Silly.Add(4, 6));
    }
}
