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
    public class TipoRequerimientoController : BaseController
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;

        public TipoRequerimientoController(IUnitOfWork unitOfWork, IMapper mapper){
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<TipoRequerimiento>>> Get(){
            var items = await _UnitOfWork.TipoRequerimiento.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<IEnumerable<TipoRequerimiento>>> Get(int id){
            var item = await _UnitOfWork.TipoRequerimiento.GetByIdAsync(id);
            return Ok(item); 
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoRequerimiento>> Post(TipoRequerimientoDto itemDto){
            var item = _mapper.Map<TipoRequerimiento>(itemDto);
            this._UnitOfWork.TipoRequerimiento.Add(item);
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

        public async Task<ActionResult<TipoRequerimiento>> Put(int id, [FromBody] TipoRequerimiento item){
            if (item.Id == 0){
                item.Id=id;
            }
            if (item.Id != id){
                return BadRequest();
            }
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.TipoRequerimiento.Update(item);
            await _UnitOfWork.SaveAsync();
            return item;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id){
            var item = await _UnitOfWork.TipoRequerimiento.GetByIdAsync(id);
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.TipoRequerimiento.Remove(item);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }
    }
}