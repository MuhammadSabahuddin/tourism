//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace WebApplication26.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Friend
    {
        [ReadOnly(true)]
        public int MemberId { get; set; }
        public int FriendId { get; set; }
        [DisplayName("Friendship Status")]
        public string FriendStatus { get; set; }
        public virtual Member Member { get; set; }
    }
}
