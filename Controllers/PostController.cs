using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YoutubeWebApi.Business;
using YoutubeWebApi.Models;

namespace YoutubeWebApi.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController:ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpPost]
        public IActionResult Create(Posts post)
        {
            var response = _postService.Create(post);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var result = _postService.GetPost(id);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _postService.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var result = _postService.DeleteById(id);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id, Posts posts)
        {
            var response = _postService.UpdatePost(id,posts);
            return Ok(response);
        }

    }
}