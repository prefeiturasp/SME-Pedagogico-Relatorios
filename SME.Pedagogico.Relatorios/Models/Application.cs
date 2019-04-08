using System.Collections.Generic;

namespace SME.Pedagogico.Relatorios.Models
{
    public class Application : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================

        public string DigitalSignature { get; set; } = null;

        public virtual List<Report> ReportList { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}