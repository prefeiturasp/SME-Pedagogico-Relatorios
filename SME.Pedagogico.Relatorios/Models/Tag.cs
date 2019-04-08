using System.Collections.Generic;

namespace SME.Pedagogico.Relatorios.Models
{
    public class Tag : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public string Name { get; set; } = null;

        public virtual List<ReportTag> ReportTagList { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}