using SME.Pedagogico.Relatorios.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SME.Pedagogico.Relatorios
{
    public class ReportManager
    {
        #region ==================== ATTRIBUTES ====================
        private Contexts.SmeReportsContext db;
        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================
        public ReportManager()
        {
            db = new Contexts.SmeReportsContext();
        }
        public ReportManager(string connectionString)
        {
            db = new Contexts.SmeReportsContext(connectionString);
        }
        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================
        /// <summary>
        /// Entrada de dados genéricos de Relatório
        /// </summary>
        /// <param name="data">Informações no formato Json</param>
        /// <param name="applicationCode"></param>
        /// <param name="logControlId"></param>
        /// <param name="tags"></param>
        /// <param name="reportTypeCode"></param>
        /// <returns></returns>
        public bool AddEntry(string data, string applicationCode, string logControlId, List<string> tags, string reportTypeCode)
        {

            Report report = new Report();
            report.NewId();
            report.Data = data;

            report.Application = db.Applications
                                 .SingleOrDefault(x => x.Code == applicationCode);


            if (report.Application == null)
            {
                report.Application = new Application();
                report.Application.NewId();
                report.Application.Code = applicationCode;
            }

            report.LogControl = db.LogControls
                                    .SingleOrDefault(x => x.Id == logControlId);
            if (report.LogControl == null)
            {
                report.LogControl = new LogControl();
                report.LogControl.NewId();
            }

            report.Type = db.ReportTypes
                                .SingleOrDefault(x => x.Name == reportTypeCode);
            if (report.Type == null)
            {
                report.Type = new ReportType();
                report.Type.NewId();
                report.Type.Code = reportTypeCode;
            }

            db.Reports.Add(report);
            db.SaveChanges();

            List<ReportTag> listReportTags = new List<ReportTag>();
            foreach (string tag in tags)
            {
                ReportTag reportTag = new ReportTag();
                reportTag.Report = report;

                Tag newTag = db.Tags.Where(x => x.Name == tag).FirstOrDefault();

                if (newTag == null)
                {
                    newTag = new Tag();
                    newTag.Name = tag;
                    newTag.NewId();
                    db.Add(newTag);
                    db.SaveChanges();
                }

                reportTag.Tag = newTag;
                listReportTags.Add(reportTag);
            }

            db.AddRange(listReportTags);
            db.SaveChanges();


            return true;
        }

        /// <summary>
        /// Lista todos os relatórios
        /// </summary>
        /// <returns></returns>
        public List<Report> ListAllReports()
        {
            List<Report> listReports = new List<Report>();
            listReports = db.Reports.ToList();
            return listReports;
        }

        /// <summary>
        /// Lista todos os relatórios por data
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Report> ListReportsByDate(DateTime date)
        {
            List<Report> listReports = new List<Report>();
            listReports = db.Reports
                                .Where(x => x.LogControl.CreatedAt == date).ToList();
            return listReports;
        }

        #endregion ==================== METHODS ====================
    }
}
