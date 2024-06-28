using AttributesSamples;


[DBMethod("ABC")]
[Obsolete("This is old method")]
void PrintHelloWorld()
{
    Console.WriteLine("Hello");

}


var dbMethod = (DBMethodAttribute)Attribute.GetCustomAttribute(typeof(Class1).GetMethod("PrintHelloWorld1"), typeof(DBMethodAttribute));
Console.WriteLine(dbMethod.message);
dbMethod = (DBMethodAttribute)Attribute.GetCustomAttribute(typeof(Class1).GetMethod("PrintHelloWorld2"), typeof(DBMethodAttribute));
Console.WriteLine(dbMethod.message);
    
//PrintHelloWorld();
var a = new Class1();
