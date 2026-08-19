//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private ArrayList order = new ArrayList();
        public int Number
        {
            get; set;
        }

        private bool isOccupied;
        public bool IsOccupied
        {
            get { return this.isOccupied;}
        }
        public void Occupy()
        {
            this.isOccupied = true;
        }
        public void Free()
        {
            order.Clear();
            this.isOccupied = false;
        }
        public void AddToOrder(Dish)
        {
            order.Add(Dish);
        }
        public bool HasOrders()
        {
            if (this.order.Count > 0)
            {
                return true
            }
            else
            {
                return false
            }
        }
    }
}