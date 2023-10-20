using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNotas.Controllers;
using ApiNotas.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiNotas.Controllers
{
    public class EstadoNotiController : BaseController
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;

        public EstadoNotiController(IUnitOfWork unitOfWork, IMapper mapper){
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<EstadoNotificacion>>> Get(){
            var items = await _UnitOfWork.EstadoNotificacion.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<IEnumerable<EstadoNotificacion>>> Get(int id){
            var item = await _UnitOfWork.EstadoNotificacion.GetByIdAsync(id);
            return Ok(item); 
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<EstadoNotificacion>> Post(EstadoNotifiDto itemDto){
            var item = _mapper.Map<EstadoNotificacion>(itemDto);
            this._UnitOfWork.EstadoNotificacion.Add(item);
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

        public async Task<ActionResult<EstadoNotificacion>> Put(int id, [FromBody] EstadoNotificacion item){
            if (item.Id == 0){
                item.Id=id;
            }
            if (item.Id != id){
                return BadRequest();
            }
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.EstadoNotificacion.Update(item);
            await _UnitOfWork.SaveAsync();
            return item;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id){
            var item = await _UnitOfWork.EstadoNotificacion.GetByIdAsync(id);
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.EstadoNotificacion.Remove(item);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }
    }
}