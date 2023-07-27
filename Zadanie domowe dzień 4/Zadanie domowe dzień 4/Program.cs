string name = "Kasia";
var age = 26;
bool woman = true;

if (woman == true && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (woman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (woman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}