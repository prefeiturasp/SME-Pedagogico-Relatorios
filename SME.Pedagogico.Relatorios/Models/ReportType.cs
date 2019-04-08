using System.Collections.Generic;

namespace SME.Pedagogico.Relatorios.Models
{
    public class ReportType : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================

        public virtual List<Report> ReportList { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}