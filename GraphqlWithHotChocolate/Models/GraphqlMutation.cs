using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlWithHotChocolate.Models
{
    public class GraphqlMutation
    {
        public string AddBook(Book book)
        {
            return book.Title;
        }
    }
}
