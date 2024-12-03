﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Shared;

public class Könyv
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid LSz { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Writer { get; set; }

    [Required]
    public string Publisher { get; set; }    
    
    [Required]
    [Range(typeof(int), "0", "2024")]
    public int Date { get; set; }
}