//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP3_GestionHackathon
{
    using System;
    using System.Collections.Generic;
    
    public partial class INSCRIRE
    {
        public int idhackathon { get; set; }
        public int idequipe { get; set; }
        public System.DateTime dateinscription { get; set; }
    
        public virtual EQUIPE EQUIPE { get; set; }
        public virtual HACKATHON HACKATHON { get; set; }
    }
}