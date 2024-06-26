﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        public DateOnly Expire { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}

