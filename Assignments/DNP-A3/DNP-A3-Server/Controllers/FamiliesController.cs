using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using A1_DNP1Y.Data.Impl;
using A1_DNP1Y.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNP_A3_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamiliesController : ControllerBase
    {
        private IWebFamilyService familiesService;

        public FamiliesController(IWebFamilyService familiesService)
        {
            this.familiesService = familiesService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamilies()
        {
            try
            {
                IList<Family> families = await familiesService.GetFamiliesAsync();
                return Ok(families);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Family>> GetFamily([FromRoute] int id)
        {
            try
            {
                Family family = await familiesService.GetFamilyAsync(id);
                return Ok(family);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] Family family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Family added = await familiesService.AddFamilyAsync(family);
                return Created($"/{added.Id}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Family>> UpdateTodo([FromBody] Family family)
        {
            try
            {
                Family updatedFamily = await familiesService.UpdateFamily(family);
                return Ok(updatedFamily);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Family>> DeleteFamily([FromQuery] string streetname, [FromQuery] int housenumber)
        {
            try
            {
                Family deletedFamily = await familiesService.RemoveFamily(streetname, housenumber);
                return Ok(deletedFamily);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}