using Microsoft.AspNetCore.Mvc;
using cs_prak_3.Models.Dto;
using cs_prak_3.Models;
using cs_prak_3.Data;

namespace real_prac_3.Controllers
{
    [Route("Villa")]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: api/<VillaAPIController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(_db.Villa);
            // return Ok(VillaStore.villaDTOs);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var villa = _db.Villa.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound(new { message = $"Villa with ID {id} not found." });
            }

            _db.Villa.Remove(villa);
            _db.SaveChanges();

            return NoContent();
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] VillaDTO villaDto)
        {
            if (villaDto == null || id != villaDto.Id)
            {
                return BadRequest(new { message = "Invalid data or ID mismatch." });
            }

            var villa = _db.Villa.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound(new { message = $"Villa with ID {id} not found." });
            }

            villa.Name = villaDto.Name;

            _db.SaveChanges();

            return NoContent();
        }





        // GET api/<VillaAPIController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            //var villa = VillaStore.villaDTOs.FirstOrDefault(u => u.Id == id);
            var villa = _db.Villa.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return BadRequest();
            }
            return Ok(villa);
        }

        // POST api/<VillaAPIController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] Villa villaDTO)
        {
            if (villaDTO == null)
            {
                return BadRequest(villaDTO);
            }
            if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            _db.Villa.Add(villaDTO);

            _db.SaveChanges();

            return Ok(villaDTO);
        }
    }
}