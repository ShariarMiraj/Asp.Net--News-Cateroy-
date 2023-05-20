using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public  class NewsRepo
    {
        static CnContext db;

        static NewsRepo()
        {
            db = new CnContext();
        }

        public static List<News> Get()
        {
            return db.News.ToList();    
        }

        public static News Get(int id)
        {
            return db.News.Find(id);
        }

        public static bool Create (News news)
        {
            db.News.Add(news);
            return db.SaveChanges() > 0;
        }

        public static bool Update (News news)
        {
            var exnews= Get(news.Id);
            db.Entry(exnews).CurrentValues.SetValues(news);
            return db.SaveChanges() > 0;    
        }
        public static bool Delete (int id)
        {
            var exnews= Get(id);
            db.News.Remove(exnews);
            return db.SaveChanges() > 0;

        }

    }
}
