
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
    
public partial class CrossBreed
{

    public int CrossBreed_ID { get; set; }

    public Nullable<int> Animal_ID { get; set; }

    public Nullable<int> Animal_Breed_ID { get; set; }



    public virtual Animal Animal { get; set; }

    public virtual Animal_Breed Animal_Breed { get; set; }

}

}
