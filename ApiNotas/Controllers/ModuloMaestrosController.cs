using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using ApiNotas.Controllers;
using ApiNotas.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ModulosMaestrosController : BaseController
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;

        public ModulosMaestrosController(IUnitOfWork unitOfWork, IMapper mapper){
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<ModulosMaestros>>> Get(){
            var items = await _UnitOfWork.ModuloMaestros.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<IEnumerable<ModulosMaestros>>> Get(int id){
            var item = await _UnitOfWork.ModuloMaestros.GetByIdAsync(id);
            return Ok(item); 
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ModulosMaestros>> Post(ModuloMaestrosDto itemDto){
            var item = _mapper.Map<ModulosMaestros>(itemDto);
            this._UnitOfWork.ModuloMaestros.Add(item);
            await _UnitOfWork.SaveAsync();
            if (item==null){
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ModulosMaestros>> Put(int id, [FromBody] ModulosMaestros item){
            if (item.Id == 0){
                item.Id=id;
            }
            if (item.Id != id){
                return BadRequest();
            }
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.ModuloMaestros.Update(item);
            await _UnitOfWork.SaveAsync();
            return item;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id){
            var item = await _UnitOfWork.ModuloMaestros.GetByIdAsync(id);
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.ModuloMaestros.Remove(item);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }
    }
}