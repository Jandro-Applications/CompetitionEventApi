using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompetitionEventApi.Services;
using CompetitionEventApi.Services.DataObjects;
using Microsoft.AspNetCore.Cors;
using CompetitionEventApi.Services.Interfaces;
using AutoMapper;
using CompetitionEventApi.Models;

namespace CompetitionEventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostsController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<PostViewModel> GetPosts()
        {
            return _mapper.Map<List<PostViewModel>>(_postService.GetAll());
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public IActionResult GetPost([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postViewModel = _mapper.Map<PostViewModel>(_postService.GetByIdAsync(id));

            if (postViewModel == null)
            {
                return NotFound();
            }

            return Ok(postViewModel);
        }

        // POST: api/Posts
        [HttpPost]
        public IActionResult PostPost([FromBody] PostViewModel post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postForSave = _mapper.Map<Post>(post);

            _postService.Save(postForSave);

            return CreatedAtAction("GetPost", new { id = postForSave.Id }, post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = await _postService.GetByIdAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            post.Status = Status.Deleted;

            await _postService.SaveAsync(post);

            return Ok(post);
        }

        private bool PostExists(int id)
        {
            return _postService.GetById(id) != null;
        }
    }
}