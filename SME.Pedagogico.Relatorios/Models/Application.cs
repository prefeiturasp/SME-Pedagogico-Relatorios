using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Relatorios.Models
{
    public class Application : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================
        public string DigitalSignature { get; set; } = null;

        public virtual List<Report> ReportList { get; set; }
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        #endregion ==================== METHODS ====================
    }
}
