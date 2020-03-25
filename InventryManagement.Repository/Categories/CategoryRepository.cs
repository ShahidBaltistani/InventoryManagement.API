//using InventryManagement.Data.Models;
//using InventryManagement.Repository.Interfaces;
//using System.Linq;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.EntityFrameworkCore;

//namespace InventryManagement.Repository.Categories
//{
//    public class CategoryRepository : ICategoryRepository
//    {
//        InventryDBContext context;
//        public CategoryRepository(InventryDBContext _context)
//        {
//            context = _context;
//        }
//        public Category add(Category model)
//        {
//            context.Add(model);
//            context.SaveChanges();
//            return model;
//        }

//        public Category GetById(int id)
//        {
//            return (from c in context.Categories
//                    where c.Id == id
//                    select c).FirstOrDefault();
//        }

//        public int Delete(int id)
//        {
//            var category = (from c in context.Categories
//                        where c.Id == id
//                        select c).FirstOrDefault();
//            context.Remove(category);
//            context.SaveChanges();
//            return category.Id;
//        }

//        public List<Category> GetAll()
//        {
//            var categories = (from c in context.Categories
//                         select c).ToList();
//            return categories;
//        }

//        public void Update(Category model)
//        {
//            context.Entry(model).State = EntityState.Modified;
//            context.SaveChanges();
//        }
//    }
//}
