using CompetitionEventApi.Services.DataObjects;
using CompetitionEventApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Services
{
    public class PostService : IPostService
    {
        CompetitionApiDbContext _context;

        public PostService(CompetitionApiDbContext competitionApiDbContext)
        {
            _context = competitionApiDbContext;
        }

        public List<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return _context.Posts.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _context.Posts.FindAsync(id);
        }

        public bool Save(Post post)
        {
            if(post.Id > 0)
            {
                post.DateModified = DateTime.Now;
                _context.Entry(post).State = EntityState.Modified;
            }
            else
            {
                post.Status = Status.Active;
                post.DateCreated = DateTime.Now;
                post.DateModified = DateTime.Now;

                _context.Posts.Add(post);
            }

            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> SaveAsync(Post post)
        {
            if (post.Id > 0)
            {
                _context.Entry(post).State = EntityState.Modified;
            }

            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
    }
}
