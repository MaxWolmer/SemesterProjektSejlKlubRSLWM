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
        Blogpost AddTitle();
        Blogpost AddDescription();
    }
}
