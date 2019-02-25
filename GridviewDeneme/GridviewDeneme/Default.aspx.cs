using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GridviewDeneme.Models;

namespace GridviewDeneme
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Kisi[] kisi=new Kisi[3];
            kisi[0]=new Kisi { Id=10,Ad="Mehmet",Soyad = "Zafer",Maas = 2000};
            kisi[1] = new Kisi { Id = 11, Ad = "Ahmet", Soyad = "Dün", Maas = 2000 };
            kisi[2] = new Kisi { Id = 12, Ad = "Zehra", Soyad = "Bugün", Maas = 2000 };

            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Ad", typeof(string));
            dt.Columns.Add("Soyad", typeof(string));
            dt.Columns.Add("Maas", typeof(int));


            foreach (Kisi item in kisi)
            {

                DataRow satir = dt.NewRow();
                satir[0] = item.Id;
                satir[1] = item.Ad;
                satir[2] = item.Soyad;
                satir[3] = item.Maas;
                dt.Rows.Add(satir);
            }
            
            GridView1.DataSource = dt;
            GridView1.DataBind();
           
        }
    }
}