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
    public partial class Cart
    {
        public Cart()
        {
            this.Component = new HashSet<Component>();
        }
    
    [DataMember]
        public int idCart { get; set; }
    [DataMember]
        public Nullable<int> idUser { get; set; }
    [DataMember]
        public Nullable<byte> qty { get; set; }
    
    [DataMember]
        public virtual User User { get; set; }
    [DataMember]
        public virtual ICollection<Component> Component { get; set; }
    }
}
