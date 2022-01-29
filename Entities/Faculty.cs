using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("faculties")]
    public class Faculty:DbEntity
    {
        [Column("name")]
        [StringLength(32)]
        public string Name { get; set; }
    }
}
