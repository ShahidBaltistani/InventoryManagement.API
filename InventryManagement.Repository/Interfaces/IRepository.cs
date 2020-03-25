using InventryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.Repository.Interfaces
{
   public interface IRepository
    {
        Item add(Item model);
        Item GetById(int  id);
        List<Item> GetAll();
        void Update(Item model);
        int Delete(int id);


    }
}
