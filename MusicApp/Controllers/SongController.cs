using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Data.Model;
using MusicApp.Services;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        SongRepository repository;
        public SongController()
        {
            repository = new SongRepository();
        }

        [HttpGet]
        public async Task<ActionResult<Song>> GetAllSongs()
        {
            var songs = repository.GetSongs();

            if (songs == null)
                return NotFound();

            return Ok(songs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Song>> GetSong(int id)
        {
            var song = repository.GetSong(id);

            if (song == null)
                return NotFound();

            return Ok(song);
        }
        [HttpPost]
        public async Task<ActionResult<Song>> CreateSong(HttpRequest request)
        {
            
            return BadRequest("Cannot create object like this.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSongItem(int id)
        {
            if (this.repository.DeleteFromListById(id))
            {
                return Ok($"Deleted song with id={id}");
            }

            return BadRequest("Can't delete with this index!");
        }
        [HttpPut]
        public HttpResponseMessage UpdateSongItem([FromBody] dynamic content)
        {
            
            
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

    }
}