using OOpDemo;

public class App
{
     public void Run()
     {
        var houseList = new List<House>();
        var yellowHouse = new House(1999, "Testgatan 12");
        //yellowHouse.Adress = "Testgatan 12";
        //yellowHouse.Color = "Yellow";
        //yellowHouse.Year = 1999;
        yellowHouse.Repaint("Yellow");
        //yellowHouse.spentOnRenovations += 10000;
        houseList.Add(yellowHouse);


        var deliasHouse = new House(2017, "Lindövägen 6");
        //deliasHouse.Adress = ;
        //deliasHouse.Color = "Brown";
        deliasHouse.Repaint("Brown");
        houseList.Add(deliasHouse);

        var annasHouse = new House(2022, "Testgatan 1");
        //annasHouse.Adress = ;
        //annasHouse.Color = "Green";
        annasHouse.Repaint("Green");
        houseList.Add(annasHouse);



         yellowHouse.Repaint("Blue");
         Console.WriteLine($"Renovering: {yellowHouse.TotalRenovations()} kr");
        
        foreach(var house in houseList)
        {
            Console.WriteLine($"Adress: {house.GetAdress()}");
        }


     }
    
}