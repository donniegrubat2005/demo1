//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="Cannot be empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public Nullable<System.DateTime> Date { get; set; }
    }
}
