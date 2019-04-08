namespace SME.Pedagogico.Relatorios.Models
{
    public class ReportTag : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public virtual Report Report { get; set; }
        public virtual Tag Tag { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}