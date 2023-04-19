// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var personas = new List<PersonaEnt>();
while (true)
{
    var nuevaPersona = IngresarPersona();
    personas.Add(nuevaPersona);
    Console.WriteLine("Se ha agregado una nueva persona.");
    Console.WriteLine($"Cantidad: {personas.Count}");

    Console.WriteLine("Desea continuar[s/n]");
    string continuar = null;
    while (continuar != "S" && continuar != "N")
    {
        continuar = Console.ReadLine();
    }
    if (continuar == "N")
    {
        break;
    }

   

}

class PersonaEnt
{

}




