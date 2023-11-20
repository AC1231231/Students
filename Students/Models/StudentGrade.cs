using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Students.Models;

[Table("StudentGrade")]
public partial class StudentGrade
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    public string StudentId { get; set; } = null!;

    public int Score { get; set; }
}
