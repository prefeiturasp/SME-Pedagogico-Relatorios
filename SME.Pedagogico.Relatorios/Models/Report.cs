using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        #region ==================== CONSTRUCTORS ====================
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        #endregion ==================== METHODS ====================
    }
}
