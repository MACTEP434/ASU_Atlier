using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using ICSSoft.STORMNET.Web.Tools;
using IIS.АСУ_Ателье;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Fluent;
using System.Configuration;
using System.Data;

namespace ICSSoft.STORMNET.Web

{
    using ICSSoft.STORMNET.Web.AjaxControls.Forms;

    /// <summary>
    /// Класс страницы по-умолчанию.
    /// </summary>
    public partial class Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefConnStr"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            DateTime dtY = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime dtM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            string StartOfYear = dtY.ToString("yyyyMMdd");
            string StartOfMonth = dtM.ToString("yyyyMMdd");
            string now = DateTime.Now.AddDays(1).ToString("yyyyMMdd");

            SqlCommand AVGTime = new SqlCommand("SELECT AVG (DATEDIFF (hour, ДатаПоступления, ДатаЗакрытия)) as СреднееВремя, ФИОМастера FROM Заказ INNER JOIN МодельОдежды ON Заказ.Модель = МодельОдежды.primaryKey INNER JOIN Мастер ON Заказ.Мастер = Мастер.primaryKey INNER JOIN Цех ON Мастер.Цех = Цех.primaryKey WHERE ДатаЗакрытия IS NOT NULL GROUP BY ФИОМастера ", connection);
            
            SqlCommand getClientsByMonth = new SqlCommand("SELECT TOP 10 ФИОКлиента, SUM(Сумма) as Доход FROM Заказ INNER JOIN Клиент ON  Заказ.Клиент = Клиент.primaryKey WHERE ДатаПоступления BETWEEN '" + StartOfMonth + "' AND '" + now + "'  GROUP BY ФИОКлиента ORDER BY Доход DESC", connection);

            SqlCommand getClientsByYear = new SqlCommand("SELECT TOP 10 ФИОКлиента, SUM(Сумма) as Доход FROM Заказ INNER JOIN Клиент ON  Заказ.Клиент = Клиент.primaryKey  WHERE ДатаПоступления BETWEEN '" + StartOfYear + "' AND '" + now + "'  GROUP BY ФИОКлиента ORDER BY Доход DESC", connection);

            SqlCommand getTopCex = new SqlCommand("SELECT TOP 1 SUM(Сумма) as Доход, Цех.НаименованиеЦеха	FROM Заказ INNER JOIN Мастер ON Заказ.Мастер = Мастер.primaryKey INNER JOIN Цех ON Мастер.Цех = Цех.primaryKey WHERE ДатаПоступления BETWEEN '" + StartOfMonth + "' AND '" + now + "' GROUP BY НаименованиеЦеха ORDER BY Доход DESC ", connection);

            connection.Open();

            SqlDataAdapter daAVG = new SqlDataAdapter(AVGTime);
            DataSet dsAVG = new DataSet();
            daAVG.Fill(dsAVG);
            AVG.DataSource = dsAVG;
            AVG.DataBind();

            SqlDataAdapter da = new SqlDataAdapter(getClientsByMonth);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Top10m.DataSource = ds;
            Top10m.DataBind();

            SqlDataAdapter daYear = new SqlDataAdapter(getClientsByYear);
            DataSet dsYear = new DataSet();
            daYear.Fill(dsYear);
            Top10y.DataSource = dsYear;
            Top10y.DataBind();

            SqlDataAdapter daTopCex = new SqlDataAdapter(getTopCex);
            DataSet dsTopCex = new DataSet();
            daTopCex.Fill(dsTopCex);
            TopCex.DataSource = dsTopCex;
            TopCex.DataBind();

            connection.Close();
        }
    }
}