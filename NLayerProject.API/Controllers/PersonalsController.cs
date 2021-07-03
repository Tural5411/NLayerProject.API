using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.API.Filters;
using NLayerProject.Core.Model;
using NLayerProject.Core.Services;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Personal> _personalService;
        public PersonalsController(IMapper mapper,IService<Personal> personalService)
        {
            _mapper = mapper;
            _personalService = personalService;
        }
        public async Task<IActionResult> GetAll()
        {
            var personals = await _personalService.GetAllAsync();
            return Ok(personals);
        }
        //Dto cevir,yoxlamaq ucun yazmisam
        [ValidationFilter]
        public async Task<IActionResult> Save(Personal model)
        {
            var personal = await _personalService.AddAsync(model);
            return Ok(personal);
        }
    }
}
