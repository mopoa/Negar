using System;
using Microsoft.AspNetCore.Http;

namespace Negar.Domain
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long RemainderCount { get; set; }
        public string Description { get; set; }
        public int Fee { get; set; }
        public IFormFile Picture { get; set; }
        
    }
}