using AracIhaleProje.Api.Models.VM;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AracIhaleProje.Api.DAL.Interfaces;
using AracIhaleProje.Api.DAL.İhaleEkleDAL;
using Newtonsoft.Json;
using AracIhaleProje.Api.Models;

namespace AracIhaleProje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IhalesController : ControllerBase
    {
        private readonly IIhaleDAL _dal;
        private readonly IMapper _mapper;
        public IhalesController(IIhaleDAL dal, IMapper mapper)
        {
            _dal = dal;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Ihale>> IhaleAc([FromBody] IhaleVM vm)
        {
        var AddedIhale = await  _dal.AddAsync(_mapper.Map<Ihale>(vm));
            return Created(string.Empty,AddedIhale);

            //  var hede=JsonConvert.DeserializeObject()
            //  try {
            //_dal.Add(_mapper.Map<Ihale>(vm));
            // 
            //  }
            //  catch (Exception ex)
            //  {

            //  }
            //  return new StatusCodeResult(400);
        }


        [HttpPost("Guncelle")]
        public ActionResult IhaleGuncelle([FromBody] IhaleVM vm)
        {
            _dal.UpdateAsync(_mapper.Map<Ihale>(vm));
            return NoContent  ();

            //  var hede=JsonConvert.DeserializeObject()
            //  try {
            //_dal.Add(_mapper.Map<Ihale>(vm));
            // 
            //  }
            //  catch (Exception ex)
            //  {

            //  }
            //  return new StatusCodeResult(400);
        }
        [HttpGet("hi")]
        public async Task<IActionResult> Liste()
        {
            var deger = await _dal.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<IhaleVM>>(deger));
        }
        [HttpGet("")]
        public  IActionResult Listele()
        {
            var deger = _dal.GetAll();
            return Ok(_mapper.Map<IEnumerable<IhaleVM>>(deger));


        }
        [HttpDelete]
        public IActionResult Sil(IhaleVM vm )
        {
             _dal.RemoveAsync(_mapper.Map<Ihale>(vm));
            return NoContent();


        }
    }
}
