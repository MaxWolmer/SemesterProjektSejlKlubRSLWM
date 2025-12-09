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
        void AddPost(Blog blogpost);
        void DeletePost(int Id);

        void UpdateTitle(int Id, string newTitle);
        void UpdateDesc(int Id, string newDesc);

        void PrintListOfPosts();
    }
}
