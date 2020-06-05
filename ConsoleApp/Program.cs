using ConsoleApp1.Models;
using SqlSugar;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = DbType.SqlServer,
                ConnectionString = "Data Source=.;Initial Catalog=Test;Integrated Security=True",
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });

            List<GDDRU> gDDRUs = db.Queryable<GDDRU>().ToList();
            List<GDFAN> gDFANs = db.Queryable<GDFAN>().ToList();


            List<string> tableNameList = new List<string> { "fmu", "med", "chk", "dru","lab","ope" };


            foreach (var gDFANItem in gDFANs)
            {
                if (tableNameList.Contains(gDFANItem.FTBL.ToLower()))
                {
                    string sql = $"select * from {gDFANItem.FTBL} where conid={gDFANItem.FCONID} and cvocable='{gDFANItem.FSTR}'";

                    var list = db.SqlQueryable<dynamic>(sql).ToList();
                    foreach (var item in list)
                    {
                        //CVOCABLE  CONID
                        System.Console.WriteLine(item.CVOCABLE.ToString());
                        gDFANItem.FKEY_NO = item.KEY_NO;
                    }
                    db.Updateable(gDFANItem).WhereColumns(e => new { e.FCONID, e.FSTR, e.id, e.IFID }).ExecuteCommand();
                }
            }



            //foreach (var gDDRUItem in gDDRUs)
            //{
            //    if (tableNameList.Contains(gDDRUItem.DRUTBL.ToLower()))
            //    {
            //        string sql = $"select * from {gDDRUItem.DRUTBL} where conid={gDDRUItem.DRUCONID} and cvocable='{gDDRUItem.DRUNAME}'";

            //        var list = db.SqlQueryable<dynamic>(sql).ToList();
            //        foreach (var item in list)
            //        {
            //            //CVOCABLE  CONID
            //            System.Console.WriteLine(item.CVOCABLE.ToString());
            //            gDDRUItem.DRUKey_No = item.KEY_NO;
            //        }
            //        db.Updateable(gDDRUItem).WhereColumns(e=>new {e.DRUCONID,e.DRUNAME,e.id,e.IFID }).ExecuteCommand();
            //    }
            //}
        }
    }
}