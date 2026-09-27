using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_01.DeliveryManagementSystem;

internal struct DeliveryAdress
{
    public string City;
    public string Street;
    public int BuildingNumber;

    public DeliveryAdress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }

    public string GetFullAddress()
    {
        return City + " " + Street;
    }


    public void printAdress()
    {
        Console.WriteLine($"City: {City} Street: {Street} Building number is: {BuildingNumber} ");
    }
}
