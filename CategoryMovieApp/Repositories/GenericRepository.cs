using CategoryMovieApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CategoryMovieApp.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        Context c = new Context();

        public List<T> List()
        {
            return c.Set<T>().ToList();
        }
        public List<T> List(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
        public List<T> List(string us, string mo)
        {
            return c.Set<T>().Include(us).Include(mo).ToList();
        }
        public List<T> List(string ca,string ye ,string co)
        {
            return c.Set<T>().Include(ca).Include(ye).Include(co).ToList();
        }
        public void Add(T item)
        {
            c.Add(item);
            c.SaveChanges();
        }
        public void Update(T item)
        {
            c.Update(item);
            c.SaveChanges();
        }
        public void Delete(T item)
        {
            c.Remove(item);
            c.SaveChanges() ;
        }
        public T Get(int id) 
        {
          return c.Set<T>().Find(id);
        }
    }
}
