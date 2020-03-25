using InventryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.Repository.Interfaces
{
   public interface ICategoryRepository
    {
        Category add(Category model);
        Category GetById(int id);
        List<Category> GetAll();
        void Update(Category model);
        int Delete(int id);
    }
}
