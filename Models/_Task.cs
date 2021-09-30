using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToDo.Models
{
    public enum Color
    {
        RED,
        GREEN,
        YELLOW,
        WHITE,
    }
    
    public class _Task
    // Task Model for the to-do list
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Action { get; set; }
        public DateTime DateCreated { get; set; }
        public Color Color { get; set; }

        public _Task()
        {
            this.DateCreated = DateTime.Now;
        }
    }
}
