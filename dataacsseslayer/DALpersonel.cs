using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Data.SqlClient;
using System.Data;

namespace dataacsseslayer
{
    public class DALpersonel
    {
        public static List<Class1> personellistesi()
        {
            List<Class1> degerler = new List<Class1>();
            SqlCommand komuut1 = new SqlCommand("Select * From tbl_Nkatmanlıtablo", baglanti.bgl);
            if (komuut1.Connection.State != ConnectionState.Open)
            {
                komuut1.Connection.Open();
            }
            SqlDataReader dr = komuut1.ExecuteReader();
            while (dr.Read())
            {
               Class1 ent = new Class1();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Sehir = dr["SEHİR"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close(); 
            return degerler;

        }

        public static int personelekle(Class1 p)
        {
            SqlCommand komut41 = new SqlCommand("insert into tbl_Nkatmanlıtablo (AD,SOYAD,SEHİR,GOREV,MAAS) values (@p1,@p2,@p3,@p4,@p5)", baglanti.bgl);
            if (komut41.Connection.State != ConnectionState.Open)
            {
                komut41.Connection.Open();
            }
            komut41.Parameters.AddWithValue("@p1", p.Ad);
            komut41.Parameters.AddWithValue("@p2", p.Soyad);
            komut41.Parameters.AddWithValue("@p3", p.Sehir);
            komut41.Parameters.AddWithValue("@p4", p.Gorev);
            komut41.Parameters.AddWithValue("@p5", p.Maas);
            return komut41.ExecuteNonQuery();

        }
        
        public static bool personelsil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From tbl_Nkatmanlıtablo where ID=@p1 ",baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() >0;
        }

        public static bool personelgüncelle(Class1 ent)
        {
            SqlCommand komut7 = new SqlCommand("Update tbl_Nkatmanlıtablo set AD=@r1,SOYAD=@r2,SEHİR=@r3,GOREV=@r4,MAAS=@r5 Where ID=@r6", baglanti.bgl);
            if (komut7.Connection.State != ConnectionState.Open)
            {
                komut7.Connection.Open();
            }
            komut7.Parameters.AddWithValue("@r1", ent.Ad);
            komut7.Parameters.AddWithValue("@r2", ent.Soyad);
            komut7.Parameters.AddWithValue("@r3", ent.Sehir);
            komut7.Parameters.AddWithValue("@r4", ent.Gorev);
            komut7.Parameters.AddWithValue("@r5", ent.Maas);
            komut7.Parameters.AddWithValue("@r6", ent.Id);
            return komut7.ExecuteNonQuery() >0;

        }
    }
}
