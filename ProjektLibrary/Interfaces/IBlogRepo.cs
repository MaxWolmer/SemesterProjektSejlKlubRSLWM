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
        void AddBlogpost(Blogpost blogpost);
        void DeletePost(int id);
    }
}
