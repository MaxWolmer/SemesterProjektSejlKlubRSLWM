using ProjektLibrary.Data;
using ProjektLibrary.Exceptions.BlogExceptions;
using ProjektLibrary.Exceptions.EventExceptions;
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
        private List<Blogpost> _blogpostlist;

        public BlogRepo()
        {
            _blogpostlist = MockData.PostList;
        }
        #endregion

        #region Methods
        public void AddPost(Blogpost blogpost)
        {
            _blogpostlist.Add(blogpost);
        }
        public void DeletePost(int id)
        {
            Blogpost toRemove = FindPostById(id);
            if (toRemove != null)
            {
                _blogpostlist.Remove(toRemove);
                return;
            }
            throw new BlogIdNotExistException("En post med dette ID findes ikke");
        }

        public void UpdatePost(int id, string newTitle, string newDescription)
        {
            Blogpost post = FindPostById(id);
            if (post == null)
            {
                throw new BlogIdNotExistException("En post med dette ID findes ikke");
            }
            post.BlogTitle = newTitle;
            post.BlogDescription = newDescription;
        }

        public Blogpost FindPostById(int id)
        {
            foreach (Blogpost post in _blogpostlist)
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
            foreach (Blogpost b in _blogpostlist)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine("- Has printed all Blogposts -\n");
        }
        #endregion
    }
}
