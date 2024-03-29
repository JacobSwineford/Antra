﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Description { get; set; }
    }
}
