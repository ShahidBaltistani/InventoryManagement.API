//using InventryManagement.Data.Models;
//using InventryManagement.Repository.Interfaces;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using System.Collections.Generic;
//using System.Text;

//namespace InventryManagement.Repository.Users
//{
//   public class UserRepository : IUserRepository
//    {
//            InventryDBContext context;
//            public UserRepository(InventryDBContext _context)
//            {
//                context = _context;
//            }
//            public User add(User model)
//            {
//                context.Add(model);
//                context.SaveChanges();
//                return model;
//            }

//            public User GetById(int id)
//            {
//                return (from u in context.Users
//                        where u.Id == id
//                        select u).FirstOrDefault();
//            }

//            public int Delete(int id)
//            {
//                var user = (from u in context.Users
//                            where u.Id == id
//                            select u).FirstOrDefault();
//                context.Remove(user);
//                context.SaveChanges();
//                return user.Id;
//            }

//            public List<User> GetAll()
//            {
//                var users = (from u in context.Users
//                             select u).ToList();
//                return users;
//            }

//            public void Update(User model)
//            {
//                context.Entry(model).State = EntityState.Modified;
//                context.SaveChanges();
//            }
//    }
//}
