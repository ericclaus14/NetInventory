//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetInvenApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class network_devices
    {
        public short asset_id { get; set; }
        public string host_name { get; set; }
        public string mac_address { get; set; }
        public string static_ip { get; set; }
    
        public virtual device device { get; set; }
    }
}
