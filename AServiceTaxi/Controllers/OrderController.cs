using AServiceTaxi.BL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AServiceTaxi
{
        [ApiController]
        [Route("api/orders")]
        public class OrderController : Controller
        {
            private readonly IOrderService _orderService;
            public OrderController(IOrderService orderService)
            {
                _orderService = orderService;
            }
            [HttpGet]
            public IEnumerable<DL.Order> Get()
            {
                return _orderService.GetOrders();
            }

            [HttpGet("{id}")]
            public DL.Order Get(int id)
            {
            DL.Order order = _orderService.GetOrder(id);
                return order;
            }

            [HttpPost]
            public IActionResult Post(DL.Order order)
            {
                if (ModelState.IsValid)
                {
                    _orderService.AddOrder(order);
                    return Ok(order);
                }
                return BadRequest(ModelState);
            }

            [HttpPut]
            public IActionResult Put(DL.Order order)
            {
            if (ModelState.IsValid)
            {
                _orderService.UpdateOrder(order);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
            _orderService.DelOrder(id);
                return Ok();
            }
        }
    }
