var age = 17;
char sex = 'm';  //male 'm' or female 'f'
string name = "Ewa";

if (age == 33)
{
    if (name == "Ewa")
    {
        Console.WriteLine("Ewa, lat33");
    }
    else
    {
        Console.WriteLine("33-latkowie");
    }
}
else if (age < 30 && sex == 'f')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 30 && age >= 18 && sex == 'm')
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (age < 18 && sex == 'm')
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
if (age >= 30 && age < 33)
{
    Console.WriteLine("Osoba w wieku 30 do 32 lat");
}
if (age > 33)
{
    Console.WriteLine("Osoba powyżej 33 lat");
}