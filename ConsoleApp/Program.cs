using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Data;
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TestContext db=new TestContext())
            {
                List<Gddru> list = db.Gddru.ToList();
                foreach (var item in list)
                {
                    string sql = $"select * from {item.Drutbl} where conid={item.Druconid} and cvocable='{item.Druname}'";
                    var l=db.Gddru.FromSqlRaw(sql).ToList();
                    foreach (var litem in l)
                    {
                        Console.WriteLine();
                    }
                }
            }
          
        }
    }
}
