//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikAcademy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.Logs = new HashSet<Log>();
        }
    
        public int AccountId { get; set; }
        public int PersonId { get; set; }
        public decimal Balance { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
