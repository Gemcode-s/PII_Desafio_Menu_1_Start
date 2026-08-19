//------------------------------------------------------------------------------
// <copyright file="Waiter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        public Waiter(string name)
        {
            Name=name;
        }
        private ArrayList assignedTables = new ArrayList();
        public string Name {get; set;}
        public void AssignTable(Table mesa)
        {
            assignedTables.Add(mesa);
        }
        public void TakeOrder(Table mesa, Dish plato)
        {
            mesa.AddToOrder(plato);
        }
    }
}