//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Restaurant
{
    
    public class Dish
    {
        public string Name{get;set ;}
        public double Price{get;set;}
        public bool IsVegetarian{get;set;}
        public Dish(string name, double price, bool isVegetarian)
        {
            Name=name;
            Price=price;
            IsVegetarian=isVegetarian;
        }
    }
}