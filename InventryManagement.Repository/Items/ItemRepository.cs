//using InventryManagement.Data.Models;
//using InventryManagement.Repository.Interfaces;
//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.EntityFrameworkCore;

//namespace InventryManagement.Repository.Items
//{
//   public class ItemRepository : IRepository
//    {
//        InventryDBContext context;
//        public ItemRepository(InventryDBContext _context)
//        {
//            context = _context;
//        }
//        public Item add(Item model)
//        {
//            context.Add(model);
//            context.SaveChanges();
//            return model;
//        }

//        public Item GetById(int id)
//        {
//            return (from i in context.Items
//                    where i.Id == id
//                    select i).FirstOrDefault();
//        }
//        public int Delete(int id)
//        {
//            var item = (from i in context.Items
//                        where i.Id == id
//                        select i).FirstOrDefault();
//            context.Remove(item);
//            context.SaveChanges();
//            return item.Id;
//        }

//        public List<Item> GetAll()
//        {
//            var items = (from i in context.Items
//                         .Include(x => x.Category)
//                         select i).ToList();
//            return items;
//        }

//        public void Update(Item model)
//        {
//            context.Entry(model).State = EntityState.Modified;
//            context.SaveChanges();
//        }
//    }
//}
