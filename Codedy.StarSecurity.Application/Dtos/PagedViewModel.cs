using Codedy.StarSecurity.Data.Entiies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Application.Dtos
{
    public class PagedViewModel<T>
    {
        public List<T> Items { set; get; }
        public int totalRecord { set; get; }

        public IEnumerable<User> User { set; get; }
    }
}
