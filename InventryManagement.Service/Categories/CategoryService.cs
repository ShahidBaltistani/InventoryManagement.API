//using InventryManagement.Data.Models;
//using InventryManagement.Repository.Categories;
//using InventryManagement.Repository.Items;
//using InventryManagement.ViewModel.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace InventryManagement.Service.Categories
//{
//    public class CategoryService
//    {
//        readonly CategoryRepository categoryRepository;
//        public CategoryService(CategoryRepository _categoryRepository)
//        {
//            categoryRepository = _categoryRepository;
//        }
//        public CategoryViewModel Add(CategoryViewModel model)
//        {
//            var categoryM = new Category()
//            {
//                Id = model.Id,
//                Name = model.Name,

//            };
//            var category = categoryRepository.add(categoryM);
//            return model;
//        }

//        public CategoryViewModel Update(CategoryViewModel model)
//        {
//            var categoryM = new Category()
//            {
//                Id = model.Id,
//                Name = model.Name,

//            };
//            categoryRepository.Update(categoryM);
//            return model;
//        }

//        public CategoryViewModel GetById(int id)
//        {
//            var categoryVM = new CategoryViewModel();
//            var categoryM = categoryRepository.GetById(id);

//            {
//                categoryVM.Id = categoryM.Id;
//                categoryVM.Name = categoryM.Name;

//            };
//            return categoryVM;
//        }
//        public List<CategoryViewModel> GetAll()
//        {
//            var categoryModel = categoryRepository.GetAll();
//            var categoryVM = new List<CategoryViewModel>();
//            if (categoryModel != null && categoryModel.Count > 0)
//            {
//                foreach (var category in categoryModel)
//                {
//                    var categoryViewModel = new CategoryViewModel();
//                    categoryViewModel.Id = category.Id;
//                    categoryViewModel.Name = category.Name;
//                    categoryVM.Add(categoryViewModel);
//                }

//            }
//            return categoryVM;
//        }
//        public int Delete(int id)
//        {
//            var data = categoryRepository.Delete(id);
//            return data;
//        }
//    }
//}
