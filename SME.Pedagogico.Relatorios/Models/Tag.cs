using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Relatorios.Models
{
    public class Tag : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================
        public string Name { get; set; } = null;

        public virtual List<ReportTag> ReportTagList { get; set; }
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        #endregion ==================== METHODS ====================
    }
}
