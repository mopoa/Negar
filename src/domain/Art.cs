using System;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class Art
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IFormFile Picture { get; set; }
        public int  Price { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
        public virtual Designer Designer { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
