
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
    
public partial class Volunteer
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Volunteer()
    {

        this.Volunteer_Hours = new HashSet<Volunteer_Hours>();

    }


    public int Vol_ID { get; set; }

    public string Vol_Name { get; set; }

    public string Vol_Surname { get; set; }

    public string Vol_Email { get; set; }

    public string Vol_ContactNumber { get; set; }

    public string Vol_Address { get; set; }

    public string Vol_Emergency_ContactName { get; set; }

    public string Vol_Emergency_ContactNumber { get; set; }

    public Nullable<int> Title_ID { get; set; }



    public virtual Title Title { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Volunteer_Hours> Volunteer_Hours { get; set; }

}

}
