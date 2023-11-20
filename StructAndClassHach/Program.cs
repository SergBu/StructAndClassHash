// See https://aka.ms/new-console-template for more information

var inst1 = new TestClass()
{
    Id = 1,
    Name = "test",
    Deleted = false,
};

var inst2 = new TestClass()
{
    Id = 1,
    Name = "test",
    Deleted = false,
};

Console.WriteLine($"Instance are equal: {inst1.Equals(inst2)}");
Console.WriteLine($"Instance one hash code: {inst1.GetHashCode()}");
Console.WriteLine($"Instance two hash code: {inst2.GetHashCode()}");

var struct1 = new TestStruct()
{
    Id = 1,
    Name = "test",
    Deleted = false,
};

var struct2 = new TestStruct()
{
    Id = 1,
    Name = "test",
    Deleted = false,
};

Console.WriteLine($"Structures are equal: {struct1.Equals(struct2)}");
Console.WriteLine($"Structure one hash code: {struct1.GetHashCode()}");
Console.WriteLine($"Structure two hash code: {struct2.GetHashCode()}");
public class TestClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Deleted { get; set; }
}

public struct TestStruct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Deleted { get; set; }
}
