﻿using CategoryMovieApp.Models;

namespace CategoryMovieApp.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        internal object Include(object p)
        {
            throw new NotImplementedException();
        }

        internal object Set<T>()
        {
            throw new NotImplementedException();
        }
    }
}
