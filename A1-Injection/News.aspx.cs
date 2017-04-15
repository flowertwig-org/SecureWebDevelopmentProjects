using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace A1_Injection
{
    public partial class Calendar : System.Web.UI.Page
    {
        private const string ConnString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-A1-Injection-20170331092246.mdf;Initial Catalog=aspnet-A1-Injection-20170331092246;Integrated Security=True";

        public DataTable dataTable = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            var tagId = this.Request.QueryString["tag"] ?? "1";

            string query = "select * from Calendar, CalendarItemTags " +
                           "WHERE Calendar.Id = CalendarItemTags.CalendarItemId AND CalendarItemTags.TagItemId = " + tagId;

            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            StringBuilder sb = new StringBuilder();
            for (int rowIndex = 0; rowIndex < dataTable.Rows.Count; rowIndex++)
            {
                var row = dataTable.Rows[rowIndex];
                var header = row["Header"] as string;
                var description = row["Description"] as string;

                sb.Append($"<div class=\"calendar-item\"><h2>{header}</h2><p>{description}</p></div>");
            }

            label.Text = sb.ToString();
        }
    }
}



