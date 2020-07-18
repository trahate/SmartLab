using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartLab.Models
{
    public class HomeModel
    {
        public string PatientID { get; set; }
        [Display(Name= "Pateint Name")]
        [Required(ErrorMessage ="please enter name")]
        public string PatientFName { get; set; }
        public string PateintLName { get; set; }
        public string PateintNumber { get; set; }
        public string PateintAddress { get; set; }
    }
}