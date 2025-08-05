using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DB_First_Console_Practice.Models;

public partial class Student
{
    public int StuId { get; set; }

    public string StudentName { get; set; } = null!;

    public decimal Telugu { get; set; }

    public decimal Hindi { get; set; }

    public decimal English { get; set; }

    public decimal Maths { get; set; }

    public decimal Science { get; set; }

    public decimal Social { get; set; }
}
