using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Data.Model;
using MusicApp.Services;

namespace MusicApp.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class SongController : ControllerBase
    {
        SongRepository repository;
        public SongController()
        {
            repository = new SongRepository();
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<Song> Get()
        {
            return this.repository.GetSongs().AsEnumerable();
        }
    }
}