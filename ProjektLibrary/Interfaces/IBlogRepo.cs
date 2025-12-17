using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLibrary.Interfaces
{
    public interface IBlogRepo
    {
        void AddPost(Blogpost blogpost);
        void DeletePost(int Id);
        void UpdatePost(int id);
        Blogpost FindPostById(int id);

        void PrintListOfPosts();
    }
}
