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
        #region List Creation
        private List<Blog> _postlist;

        public BlogRepo()
        {
            _postlist = new List<Blog>();
        }
        #endregion

        #region Methods
        public void AddPost(Blog blogpost)
        {
            _postlist.Add(blogpost);
        }
        public void DeletePost(int Id)
        {
            Blog toRemove = null;
            foreach (Blog blogpost in _postlist)
            {
                if (blogpost.Id == Id)
                {
                    toRemove = blogpost;
                    return;
                }
            }
            if (toRemove != null)
            {
                _postlist.Remove(toRemove);
            }
            throw new IdNotExistException("En post med dette ID findes ikke");
        }

        public void UpdateTitle(int Id, string newTitle)
        {
            foreach (Blog post in _postlist)
            {
                if (post.Id == Id)
                {
                    post.Title = newTitle;
                    return;
                }
            }
            throw new IdNotExistException("En post med dette ID findes ikke");
        }
        public void UpdateDesc(int Id, string newDescription)
        {
            foreach (Blog post in _postlist)
            {
                if (post.Id == Id)
                {
                    post.Description = newDescription;
                    return;
                }
            }
            throw new IdNotExistException("En post med dette ID findes ikke");
        }

        public void PrintListOfPosts()
        {
            foreach (Blog b in _postlist)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine("- Has printed all Blogposts -\n");
        }
        #endregion
    }
}
