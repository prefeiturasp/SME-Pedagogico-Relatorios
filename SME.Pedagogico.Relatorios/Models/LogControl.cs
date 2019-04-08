using System;
using System.Collections.Generic;

namespace SME.Pedagogico.Relatorios.Models
{
    public class LogControl : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = null;
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; } = null;

        public virtual List<Report> ReportList { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}