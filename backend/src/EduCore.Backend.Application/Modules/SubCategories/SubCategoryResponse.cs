﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace EduCore.BackEnd.Application.Modules.SubCategories
{
    public  class SubCategoryResponse
    {
        [Key]
        [JsonPropertyOrder(0)]
        public int Id { get; set; }

        [JsonPropertyOrder(1)]
        public string Name { get; set; }


    }
}
