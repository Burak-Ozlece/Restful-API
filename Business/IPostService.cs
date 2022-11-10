using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeWebApi.Models;

namespace YoutubeWebApi.Business
{
    public interface IPostService
    {
        Posts Create(Posts post);
        Posts GetPost(int id);
        List<Posts> GetAll();
        Posts DeleteById(int id);
        Posts UpdatePost(int id, Posts posts);
    }
}