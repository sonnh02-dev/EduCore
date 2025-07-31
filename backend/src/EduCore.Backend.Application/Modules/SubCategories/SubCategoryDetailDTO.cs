using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace EduCore.BackEnd.Application.Modules.SubCategories
{
    public class SubCategoryDetailDTO:SubCategoryResponse
    {
        [JsonPropertyOrder(2)]
        public int  CategoryId { get; set; }

        [JsonPropertyOrder(3)]


        public string CategoryName {  get; set; }
    }
}
