using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Domain.UnitTests
{
    public class PostBuilder
    {
        private RandomGenerator generator = new RandomGenerator();
        public Post getValidPost()
        {
            
            return Builder<Post>
                .CreateNew()
                .With(x=> x.Id= generator.Guid())
                .With(x => x.title = "t" + generator.Phrase(10).Replace(" ", "1"))
                .With(x => x.body = generator.Phrase(100))
                .Build();
        }
    }
}
