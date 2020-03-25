//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using InventryManagement.Service.Categories;
//using InventryManagement.ViewModel.ViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace InventryManagementAPI.Controllers
//{
//    [Route("api/Category")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        readonly CategoryService categoryService;
//        public UserController(CategoryService _categoryService)
//        {
//            categoryService = _categoryService;
//        }
//        [HttpGet]
//        [Route("getall")]
//        public IActionResult GetAll()
//        {
//            var data = categoryService.GetAll();
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
//                var data = categoryService.GetById(id);
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
//        public IActionResult Add([FromBody] CategoryViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var data = categoryService.Add(model);
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

//            var data = categoryService.Delete(id);
//            return Ok();
//        }

//        [HttpPost]
//        [Route("update")]
//        public IActionResult Update([FromBody] CategoryViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var data = categoryService.Update(model);
//                    return Ok(data);
//                }
//                catch (Exception )
//                {

//                    return BadRequest();
//                }
//            }
//            return BadRequest();
//        }

//    }
//}
