//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using InventryManagement.Service.Users;
//using InventryManagement.ViewModel.ViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace InventryManagementAPI.Controllers
//{
//    [Route("api/User")]
//    public class UsersController : ControllerBase
//    {
//        readonly UserService userService;
//        public UsersController(UserService _userService)
//        {
//            userService = _userService;
//        }
//        [HttpGet]
//        [Route("getall")]
//        public IActionResult GetAll()
//        {
//            var data = userService.GetAll();
//            if (data.Count == 0)
//            {
//                return NotFound("No data found");
//            }
//            return Ok(data);


//        }
//        [Route("getbyid/{id}")]
//        public IActionResult GetById(int id)
//        {
//            try
//            {
//                var data = userService.GetById(id);
//                if (data == null)
//                {
//                    return NotFound();
//                }
//                return Ok(data);

//            }
//            catch (Exception)
//            {

//                return BadRequest();
//            }
//        }
//        [HttpPost]
//        [Route("add")]
//        public IActionResult Add([FromBody] UserViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var data = userService.Add(model);
//                    return Ok(data);
//                }
//                catch (Exception)
//                {

//                    return BadRequest();
//                }
//            }
//            return BadRequest();
//        }
//        [Route("delete/{id}")]
//        [HttpDelete]
//        public IActionResult Delete(int id)
//        {
//            if (id <= 0)
//                return BadRequest("Not a Valid Id");

//            var data = userService.Delete(id);
//            return Ok();
//        }

//        [HttpPost]
//        [Route("update")]
//        public IActionResult Update([FromBody] UserViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var data = userService.Update(model);
//                    return Ok(data);
//                }
//                catch (Exception)
//                {

//                    return BadRequest();
//                }
//            }
//            return BadRequest();
//        }

//    }
//}