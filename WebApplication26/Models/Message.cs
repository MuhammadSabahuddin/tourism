//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication26.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Message
    {
        [ReadOnly(true)]
        public int MemberId { get; set; }
        [ReadOnly(true)]
        public int MessengerId { get; set; }
        public System.DateTime MessageDateTime { get; set; }
        public string MessageText { get; set; }
        public bool MessageStatus { get; set; }
        public Nullable<bool> UnknownStatus { get; set; }
    
        public virtual Member Member { get; set; }
    }
}