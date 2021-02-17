using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
