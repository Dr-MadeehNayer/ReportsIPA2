using Microsoft.Reporting.WebForms;
using ReportsIPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportsIPA.WebForms
{
    public partial class ReportDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string CourseName = "";

                if (Request.QueryString["CourseName"] != null)
                {
                    CourseName = Request.QueryString["CourseName"].ToString();



                    using (var db = new SchoolEntities1())
                    {
                        //var courses = db.Course.ToList();    //.Where(t => t.FirstName.Contains(searchText) || t.LastName.Contains(searchText)).OrderBy(a => a.CustomerID).ToList();
                        var courses = db.Course.Where(t => t.Title.Contains(CourseName)).OrderBy(a => a.Title).ToList();

                        ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/Courses.rdlc");
                        ReportViewer1.LocalReport.DataSources.Clear();

                        ReportViewer1.LocalReport.EnableHyperlinks = true;
                        ReportViewer1.LocalReport.EnableExternalImages = true;

                        ReportDataSource rpt = new ReportDataSource("Courses", courses);


                        ReportParameter[] parameters = new ReportParameter[1];
                        parameters[0] = new ReportParameter("CourseName", CourseName);
                        ReportViewer1.LocalReport.SetParameters(parameters);

                        ReportViewer1.LocalReport.DataSources.Add(rpt);
                        ReportViewer1.LocalReport.Refresh();
                        ReportViewer1.DataBind();
                    }

                }
            }

        }
    }
}