using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Students.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    public string Name { get; set; } = null!;
}
