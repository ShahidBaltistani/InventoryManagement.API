//using InventryManagement.Data.Models;
//using InventryManagement.Repository.Users;
//using InventryManagement.ViewModel.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace InventryManagement.Service.Users
//{
//    public class UserService
//    {
//        readonly UserRepository userRepository;
//        public UserService(UserRepository _userRepository)
//        {
//            userRepository = _userRepository;
//        }
//        public UserViewModel Add(UserViewModel model)
//        {
//            var userM = new User()
//            {
//                Id = model.Id,
//                //Name = model.Name,
//               // Email = model.Email,
//            };
//            var category = userRepository.add(userM);
//            return model;
//        }

//        public UserViewModel Update(UserViewModel model)
//        {
//            var userM = new User()
//            {
//                Id = model.Id,
//               // Name = model.Name,
//               // Email = model.Email,


//            };
//            userRepository.Update(userM);
//            return model;
//        }

//        public UserViewModel GetById(int id)
//        {
//            var userVM = new UserViewModel();
//            var userM = userRepository.GetById(id);

//            {
//                userVM.Id = userM.Id;
//               // userVM.Name = userM.Name;
//               // userVM.Email = userM.Email;


//            };
//            return userVM;
//        }
//        public List<UserViewModel> GetAll()
//        {
//            var userModel = userRepository.GetAll();
//            var userVM = new List<UserViewModel>();
//            if (userModel != null && userModel.Count > 0)
//            {
//                foreach (var user in userModel)
//                {
//                    var userViewModel = new UserViewModel();
//                    userViewModel.Id = user.Id;
//                   // userViewModel.Name = user.Name;
//                   // userViewModel.Email = user.Email;

//                    userVM.Add(userViewModel);
//                }

//            }
//            return userVM;
//        }
//        public int Delete(int id)
//        {
//            var data = userRepository.Delete(id);
//            return data;
//        }
//    }
//}
