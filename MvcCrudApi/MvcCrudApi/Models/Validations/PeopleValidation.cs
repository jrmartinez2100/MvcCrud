using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCrudApi.Models
{
    [MetadataType(typeof(people.MetaData))]
    public partial class people
    {
        sealed class MetaData
        {
            [Required]
            public string Name { get; set; }
        }

    }
}