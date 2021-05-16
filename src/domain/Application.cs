using System;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class Application
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string  Instruments { get; set; }

        public IFormFile Image { get; set; }
        public virtual Artist Artist { get; set; }
    }
}