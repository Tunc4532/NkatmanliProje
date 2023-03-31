using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using dataacsseslayer;
using System.Data;

namespace Logiclayer
{
    public class Logicpersonel
    {
        public static List<Class1> llpersonellistele()
        {
            return DALpersonel.personellistesi();
        }
        public static int LLpersonelekle(Class1 p)
        {
            if(p.Ad!=" " && p.Soyad!= " " && p.Maas >= 9000 && p.Ad.Length != 3)
            {
                return DALpersonel.personelekle(p);
            }
            else
            {
                return -1;
            }
        }
        
        public static bool LLpersonelsil(int per)
        {
            if (per >= 1)
            {
                return DALpersonel.personelsil(per);
            }
            else { return false; }
        }

        public static bool LLpersonelgüncelle(Class1 ent)
        {
            if (ent.Ad.Length >= 3 )
            {
                return DALpersonel.personelgüncelle(ent);
            }
            else
            { return false ; }
        }
        
    }
}
