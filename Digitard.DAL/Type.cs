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
    public partial class Type
    {
        public Type()
        {
            this.Component = new HashSet<Component>();
        }
    
    [DataMember]
        public int idType { get; set; }
    [DataMember]
        public string name { get; set; }
    
    [DataMember]
        public virtual ICollection<Component> Component { get; set; }
    }
}
