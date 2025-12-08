using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Interfaces;
using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Services
{
    public class BlogRepo : IBlogRepo
    {
        //List Creations
        private List<Blog> _postlist;

        public BlogRepo()
        {
            _postlist = new List<Blog>();
        }

        public void AddBlogpost(Blog blogpost)
        {
            _postlist.Add(blogpost);
        }
        public void DeletePostById(int Id)
        {
            Blog toRemove = null;
            foreach (Blog post in _postlist)
            {
                if (post.Id == Id)
                {
                    toRemove = post;
                    break;
                }
            }
            if (toRemove != null)
            {
                _postlist.Remove(toRemove);
            }
            //else
            //{
            //    throw new IdNotExistException($"This post does not exist\n");
            //}
        }

        public void UpdateTitle(int Id, string newTitle)
        {
            Blog titleToChange = null;
            foreach (Blog post in _postlist)
            {
                if (post.Id == Id)
                {
                    post.Blogtitle = newTitle;
                }
                //else
                //{
                //    throw new IdNotExistException($"This post does not exist\n");
                //}
            }
        }
        public void UpdateDesc(int Id, string newDescription)
        {
            Blog descToChange = null;
            foreach (Blog post in _postlist)
            {
                if (post.Id == Id)
                {
                    post.Description = newDescription;
                }
                //else
                //{
                //    throw new IdNotExistException($"This post does not exist\n");
                //}
            }
        }

        public void PrintListOfBlogposts()
        {
            foreach (Blog b in _postlist)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine(" - Has printed all Blogposts -\n");
        }
    }
}
