using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SME.Pedagogico.Relatorios.Models
{
    public class Report : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        [Column(TypeName = "jsonb")]
        public string Data { get; set; } = null;

        public virtual Application Application { get; set; }
        public virtual LogControl LogControl { get; set; }
        public virtual List<ReportTag> Tags { get; set; }
        public virtual ReportType Type { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}