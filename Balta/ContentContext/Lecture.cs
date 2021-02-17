using Balta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }

}
