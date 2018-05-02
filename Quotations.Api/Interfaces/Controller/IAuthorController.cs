using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Controller
{
    public interface IAuthorController
    {
        Author GetAuthor(int Id);

        List<Author> GetAllAuthors();

        void Add(Author author);
    }
}
