using CompetitionEventApi.Services.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Interfaces
{
    public interface IPostService
    {
        List<Post> GetAll();
        Post GetById(int id);
        Task<Post> GetByIdAsync(int id);
        bool Save(Post post);
        Task<bool> SaveAsync(Post post);
    }
}
