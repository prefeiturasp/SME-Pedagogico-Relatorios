using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Relatorios.Models.Abstracts
{
    public class Table
    {
        #region ==================== ATTRIBUTES ====================
        public string Id { get; set; } = null;
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        public virtual void NewId()
        {
            Id = Guid.NewGuid().ToString();
        }
        #endregion ==================== METHODS ====================
    }
}
