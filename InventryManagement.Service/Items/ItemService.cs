//using InventryManagement.ViewModel.ViewModels;
//using InventryManagement.Repository.Items;

//using System;
//using System.Collections.Generic;
//using System.Text;
//using InventryManagement.Data.Models;

//namespace InventryManagement.Service.Items
//{
//   public class ItemService
//    {
//        readonly ItemRepository itemRepository;
//        public ItemService(ItemRepository _itemRepository)
//        {
//            itemRepository = _itemRepository;
//        }
//        public ItemViewModel Add(ItemViewModel model)
//        {
//            var itemM = new Item()
//            {
//                Id = model.Id,
//                Name=model.Name,
//                Price=model.Price

//            };
//            var item = itemRepository.add(itemM);
//            return model;
//        }

//        public ItemViewModel Update(ItemViewModel model)
//        {
//            var itemM = new Item()
//            {
//                Id = model.Id,
//                Name = model.Name,
//                Price = model.Price

//            };
//            itemRepository.Update(itemM);
//            return model;
//        }

//        public ItemViewModel GetById(int id)
//        {
//            var itemVM = new ItemViewModel();
//            var itemM = itemRepository.GetById(id);

//            {
//                itemVM.Id = itemM.Id;
//                itemVM.Name = itemM.Name;
//                itemVM.Price = itemM.Price;

//            };
//            return itemVM;
//        }
//        public List<ItemViewModel> GetAll()
//        {
//            var itemModel = itemRepository.GetAll();
//            var itemVM = new List<ItemViewModel>();
//            if (itemModel != null && itemModel.Count > 0)
//            {
//                foreach (var item in itemModel)
//                {
//                    var itemViewModel = new ItemViewModel();
//                    itemViewModel.Id = item.Id;
//                    itemViewModel.Name = item.Name;
//                    itemViewModel.Price = item.Price;
//                    itemViewModel.CategoryName = item.Category.Name;
//                    //itemViewModel.UserName = item.User.Name;
//                    itemVM.Add(itemViewModel);
//                }

//            }
//            return itemVM;
//        }
//        public int Delete(int id)
//        {
//           var data= itemRepository.Delete(id);
//            return data;
//        }
//    }
//}
