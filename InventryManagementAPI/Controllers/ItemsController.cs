//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using InventryManagement.Data.Models;
//using InventryManagement.Service.Items;
//using InventryManagement.ViewModel.ViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace InventryManagementAPI.Controllers
//{
//    [Route("api/items")]
//    public class ItemsController : ControllerBase
//    {
//        readonly ItemService itemService;
//        public ItemsController(ItemService _itemService)
//        {
//            itemService = _itemService;
//        }
//        [HttpGet]
//        [Route("getall")]
//        public IActionResult GetAll()
//        {
//            var data = itemService.GetAll();
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
//                var data = itemService.GetById(id);
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
//        public IActionResult Add([FromBody] ItemViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var data = itemService.Add(model);
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

//           var data= itemService.Delete(id);
//                return Ok();
//        }

//        [HttpPost]
//        [Route("update")]
//        public IActionResult Update([FromBody] ItemViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var data = itemService.Update(model);
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
