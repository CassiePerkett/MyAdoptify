
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
    
public partial class Microchip
{

    public int Microchip_ID { get; set; }

    public string Animal_Microchip_Code { get; set; }

    public Nullable<System.DateTime> Date_of_Implant { get; set; }

    public string Implanters_PIN_Number { get; set; }

    public string Owner_Name { get; set; }

    public string Owner_Address { get; set; }

    public Nullable<int> Animal_ID { get; set; }



    public virtual Animal Animal { get; set; }

}

}
