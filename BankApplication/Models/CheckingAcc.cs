﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankApplication.Models
{
    public class CheckingAcc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [Column(TypeName="varchar")]
        [RegularExpression(@"\d{6,10}",ErrorMessage ="Account # must be between 6 and 10 digits")]
        [Display(Name ="Account # ")]
        public string AccountNumber { get; set; }
        [Display(Name = "First Name ")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
        public string LastName { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
        public string Email { get; set; }
        public virtual ApplicationUser User { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}