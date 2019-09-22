using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.DataAccess
{
    interface IUnitOfWork
    {
        // list of repositories
        // not convinced yet


        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}