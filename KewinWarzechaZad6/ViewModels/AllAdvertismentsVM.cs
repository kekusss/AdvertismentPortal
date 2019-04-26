﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KewinWarzechaZad6.ViewModels
{
    public class AllAdvertismentsVM
    {
        public string Title{ get; set; }
        public string CategoryName { get; set; }
        public float Price { get; set; }
        public DateTime DateOfAddition { get; set; }
        public int Id { get; set; }

        public AllAdvertismentsVM(string title, string categoryName, float price, DateTime dateOfAddition,int id)
        {
            Title = title;
            CategoryName = categoryName;
            Price = price;
            DateOfAddition = dateOfAddition;
            Id = id;
        }
    }
}