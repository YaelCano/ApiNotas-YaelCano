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

namespace ApiNotas.Controllers;

    public class RolController : BaseController
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _mapper;

        public RolController(IUnitOfWork unitOfWork, IMapper mapper){
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<Rol>>> Get(){
            var items = await _UnitOfWork.Rol.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<IEnumerable<Rol>>> Get(int id){
            var item = await _UnitOfWork.Rol.GetByIdAsync(id);
            return Ok(item); 
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<Rol>> Post(RolDto itemDto){
            var item = _mapper.Map<Rol>(itemDto);
            this._UnitOfWork.Rol.Add(item);
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

        public async Task<ActionResult<Rol>> Put(int id, [FromBody] Rol item){
            if (item.Id == 0){
                item.Id=id;
            }
            if (item.Id != id){
                return BadRequest();
            }
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.Rol.Update(item);
            await _UnitOfWork.SaveAsync();
            return item;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id){
            var item = await _UnitOfWork.Rol.GetByIdAsync(id);
            if (item == null){
                return NotFound();
            }
            _UnitOfWork.Rol.Remove(item);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }
    }
