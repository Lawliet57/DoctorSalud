//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorSalud
{
    using System;
    using System.Collections.Generic;
    
    public partial class EPI_A_Patologicos
    {
        public int idPatologicos { get; set; }
        public string EnfermedadCongenita { get; set; }
        public string Alergias { get; set; }
        public string TranstornoMemoria { get; set; }
        public string Pulmonar { get; set; }
        public string Quirurgicos { get; set; }
        public string Transfuncionales { get; set; }
        public string Diabetes { get; set; }
        public string Traumatismo { get; set; }
        public string Convulsivas { get; set; }
        public string Oncologicos { get; set; }
        public string Cardiopatias { get; set; }
        public string Hipertension { get; set; }
        public string Alcoholismo { get; set; }
        public string Fuma { get; set; }
        public string Drogas { get; set; }
        public Nullable<int> idPaciente { get; set; }
        public string EnfermedadCongenita_ESP { get; set; }
        public string Alergias_ASP { get; set; }
        public string TrastornoMemoria_ESP { get; set; }
        public string Pulmonar_ESP { get; set; }
        public string Quirurgicos_ESP { get; set; }
        public string Transfuncionales_ESP { get; set; }
        public string Diabetes_ESP { get; set; }
        public string Traumatismo_ESP { get; set; }
        public string Convulsivas_ESP { get; set; }
        public string Oncologicos_ESP { get; set; }
        public string Cardiopatias_ESP { get; set; }
        public string Hipertension_ESP { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}