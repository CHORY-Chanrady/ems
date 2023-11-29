using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryMgr.Model;
using EmployeeSalaryMgr.Persistence;
using iText.Html2pdf;
using iText.Html2pdf.Css.Apply.Util;
using iText.Html2pdf.Resolver.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace EmployeeSalaryMgr.Service
{
    public class GeneratePaySlipsService
    {
        private IPaymentDetailRepository paymentDetailRepo = new PaymentDetailRepository();
        public void generateToPdf(DateTime from, DateTime to)
        {
            DataTable paymentDetailTable = paymentDetailRepo.getAllPaymentDetail(from, to);

            foreach(DataRow row in paymentDetailTable.Rows)
            {
                Employee employee = new Employee()
                {
                    ID = long.Parse(row[0].ToString()),
                    FirstName = row[1].ToString(),
                    LastName = row[2].ToString(),
                    Gender = (Gender) Enum.Parse(typeof(Gender), row[3].ToString()),
                    Email = row[4].ToString(),
                    Position = row[5].ToString(),
                    Salary = double.Parse(row[6].ToString()),
                };
                PaymentDetail paymentDetail = new PaymentDetail()
                {
                    Id = long.Parse(row[8].ToString()),
                    Employee = employee,
                    Date = DateTime.Parse(row[10].ToString()),
                    Ot = double.Parse(row[11].ToString()),
                    Bonus = double.Parse(row[12].ToString()),
                    Deduction = double.Parse(row[13].ToString()),
                };
                paymentDetail.calcTotal();
                detailToPdf(paymentDetail);
            }
            
        }

        private void detailToPdf(PaymentDetail paymentDetail)
        {
            DateTime current = DateTime.Now;
            string template = File.ReadAllText("./template/payroll.html");
            string dest = $"./payslip/{current.Date.ToString("dd-M-yyyy")}/";
            ConverterProperties converterProperties = new ConverterProperties();
            converterProperties.SetBaseUri("template/");
            converterProperties.SetFontProvider(new DefaultFontProvider(true, true, true));
            Directory.CreateDirectory(dest);
            HtmlConverter.ConvertToPdf(templateParser(template, paymentDetail), new FileStream($"{dest}{paymentDetail.Employee.ID.ToString()+"_"}{paymentDetail.Employee.FirstName+"_"+paymentDetail.Employee.LastName}.pdf", FileMode.Create), converterProperties);
        }
        private String templateParser(String html, PaymentDetail paymentDetail)
        {
            String template = html;
            template = template.Replace("{payId}", paymentDetail.Id.ToString());
            template = template.Replace("{empId}", paymentDetail.Employee.ID.ToString());
            template = template.Replace("{empName}", $"{paymentDetail.Employee.FirstName} {paymentDetail.Employee.LastName}");
            template = template.Replace("{empEmail}", paymentDetail.Employee.Email);
            template = template.Replace("{empPos}", paymentDetail.Employee.Position);
            template = template.Replace("{date}", DateTime.Now.ToString());

            template = template.Replace("{salary}", $"${paymentDetail.Employee.Salary.ToString()}");
            template = template.Replace("{ot}", $"${paymentDetail.Ot}");
            template = template.Replace("{bonus}", $"${paymentDetail.Bonus}");
            template = template.Replace("{deduct}", $"${paymentDetail.Deduction}");
            template = template.Replace("{total}", $"${paymentDetail.Total}");
            
            return template;
        }
    }
}
