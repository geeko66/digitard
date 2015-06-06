//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Digitard.DAL
{
    using System.Runtime.Serialization
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference=true)]
    public partial class Component
    {
        public Component()
        {
            this.Component_has_Property = new HashSet<Component_has_Property>();
            this.Cart = new HashSet<Cart>();
        }
    
    [DataMember]
        public int idComponent { get; set; }
    [DataMember]
        public int idManufacturer { get; set; }
    [DataMember]
        public int idType { get; set; }
    [DataMember]
        public string name { get; set; }
    [DataMember]
        public string desc { get; set; }
    [DataMember]
        public string image { get; set; }
    [DataMember]
        public decimal price { get; set; }
    
    [DataMember]
        public virtual Manufacturer Manufacturer { get; set; }
    [DataMember]
        public virtual ICollection<Component_has_Property> Component_has_Property { get; set; }
    [DataMember]
        public virtual Type Type { get; set; }
    [DataMember]
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
