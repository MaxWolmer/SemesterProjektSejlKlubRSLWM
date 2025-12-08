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
        void AddBlogpost(Blog blogpost);
        void DeletePostById(int Id);

        void UpdateTitle(int Id, string newTitle);
        void UpdateDesc(int Id, string newDescription);

        void PrintListOfBlogposts();
    }
}
