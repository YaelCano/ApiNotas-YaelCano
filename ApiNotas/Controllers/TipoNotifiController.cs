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
    public class TipoNotfiController : BaseController
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;

        public TipoNotfiController(IUnitOfWork unitOfWork, IMapper mapper){
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<TipoNotificaciones>>> Get(){
            var items = await _UnitOfWork.TipoNotificaciones.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<IEnumerable<TipoNotificaciones>>> Get(int id){
            var item = await _UnitOfWork.TipoNotificaciones.GetByIdAsync(id);
            return Ok(item); 
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoNotificaciones>> Post(TipoNotificacionDto itemDto){
            var item = _mapper.Map<TipoNotificaciones>(itemDto);
            this._UnitOfWork.TipoNotificaciones.Add(item);
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

        public async Task<ActionResult<TipoNotificaciones>> Put(int id, [FromBody] TipoNotificaciones item){
            if (item.Id == 0){
                item.Id=id;
            }
            if (item.Id != id){
                return BadRequest();
            }
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.TipoNotificaciones.Update(item);
            await _UnitOfWork.SaveAsync();
            return item;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id){
            var item = await _UnitOfWork.TipoNotificaciones.GetByIdAsync(id);
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.TipoNotificaciones.Remove(item);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }
    }
}