//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoptifySystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_Event
    {
        public int Customer_Event_ID { get; set; }
        public string Customer_Event_Name { get; set; }
        public string Customer_Event_Surname { get; set; }
        public string Customer_Event_Email { get; set; }
        public Nullable<int> Number_of_tickects { get; set; }
        public Nullable<System.DateTime> TicketFee_Date { get; set; }
        public Nullable<decimal> TicketFee_Total { get; set; }
        public Nullable<int> Event_ID { get; set; }
        public Nullable<int> Payment_ID { get; set; }
    
        public virtual Event_ Event_ { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
