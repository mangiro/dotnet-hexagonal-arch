using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Api.Filters
{
    public class PaginationFilter
    {
        [BindProperty(Name ="page")]
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; } = 1;

        [BindProperty(Name ="size")]
        [Range(10, 20)]
        public int PageSize { get; set; } = 10;
    }
}
