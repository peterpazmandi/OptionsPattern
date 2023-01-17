using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsPattern
{
    public class ApplicationOptions
    {
        [Required]
        public string ExampleValue { get; init; } = string.Empty;
    }
}