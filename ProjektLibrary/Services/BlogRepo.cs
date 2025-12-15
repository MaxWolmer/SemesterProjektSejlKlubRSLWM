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
        private List<Blogpost> _postlist;

        public BlogRepo()
        {
            _postlist = new List<Blogpost>();
        }
        #endregion

        #region Methods
        public void AddPost(Blogpost blogpost)
        {
            _postlist.Add(blogpost);
        }
        public void DeletePost(int id)
        {
            Blogpost toRemove = FindPostById(id);
            if (toRemove != null)
            {
                _postlist.Remove(toRemove);
                return;
            }
            throw new IdNotExistException("En post med dette ID findes ikke");
        }

        public void UpdatePostTitle(int id, string newTitle)
        {
            Blogpost post = FindPostById(id);
            if (post != null)
            {
                post.Title = newTitle;
                return;
            }
            throw new IdNotExistException("En post med dette ID findes ikke");
        }

        public void UpdatePostDesc(int id, string newDescription)
        {
            Blogpost post = FindPostById(id);
            if (post != null)
            {
                post.Description = newDescription;
                return;
            }
            throw new IdNotExistException("En post med dette ID findes ikke");
        }

        public Blogpost FindPostById(int id)
        {
            foreach (Blogpost post in _postlist)
            {
                if (post.Id == id)
                {
                    return post;
                }
            }
            return null;
        }
        public void PrintListOfPosts()
        {
            foreach (Blogpost b in _postlist)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine("- Has printed all Blogposts -\n");
        }
        #endregion
    }
}
