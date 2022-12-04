using property;

Property prop = new Property();
Console.WriteLine("Введите имя");
string name = Console.ReadLine();
prop.Name = name;
name = prop.Name;
Console.WriteLine("Введите фамилию");
string surname = Console.ReadLine();
prop.Surname = surname;
surname = prop.Surname;
Console.WriteLine("Введите дату рождения");
string dateOfBirth = Console.ReadLine();
prop.DateOfBirth = dateOfBirth;
dateOfBirth = prop.DateOfBirth;
Console.WriteLine($"Имя - {name}, фамилия - {surname}, дата рождения - {dateOfBirth}");