//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demochat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int id_mess { get; set; }
        public string mess_content { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_userSend { get; set; }
    }
}