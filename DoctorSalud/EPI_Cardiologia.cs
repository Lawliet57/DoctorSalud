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
    
    public partial class EPI_Cardiologia
    {
        public int idCardiologia { get; set; }
        public string Ritmo { get; set; }
        public string Frecuencia { get; set; }
        public string Eje { get; set; }
        public string PR { get; set; }
        public string QT { get; set; }
        public string QRS { get; set; }
        public string OndaP { get; set; }
        public string OndaT { get; set; }
        public Nullable<int> idPaciente { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
