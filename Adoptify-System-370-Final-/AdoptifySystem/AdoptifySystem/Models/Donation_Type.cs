
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
    
public partial class Donation_Type
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Donation_Type()
    {

        this.Donation_Line = new HashSet<Donation_Line>();

    }


    public int Donation_Type_ID { get; set; }

    public string Donation_Type_Name { get; set; }

    public string Donation_Type_Description { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Donation_Line> Donation_Line { get; set; }

}

}
