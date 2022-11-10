using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeWebApi.Models;
using YoutubeWebApi.Repository;

namespace YoutubeWebApi.Business
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;
        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        } 
        public Posts Create(Posts post)
        {
            return _repository.Add(post);
        }

        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }

        public Posts DeleteById(int id)
        {
            var deletepost = _repository.GetById(id);
            return _repository.Delete(deletepost);
        }

        public Posts GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Posts UpdatePost(int id, Posts posts)
        {
            return _repository.UpdateById(posts,id);
        }
    }
}