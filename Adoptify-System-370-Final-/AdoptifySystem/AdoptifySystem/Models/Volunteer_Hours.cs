
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AdoptifySystem.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Volunteer_Hours
{

    public int Vol_Hours_ID { get; set; }

    public Nullable<System.DateTime> Vol_workDate { get; set; }

    public Nullable<System.DateTime> Vol_Start_Time { get; set; }

    public Nullable<System.DateTime> Vol_End_Time { get; set; }

    public Nullable<int> Vol_ID { get; set; }

    public Nullable<int> Vol_WorkType_ID { get; set; }



    public virtual Volunteer Volunteer { get; set; }

    public virtual Volunteer_Work_Type Volunteer_Work_Type { get; set; }

}

}
