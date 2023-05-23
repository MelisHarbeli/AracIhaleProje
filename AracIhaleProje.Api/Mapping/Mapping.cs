using AracIhaleProje.Api.Models;
using AracIhaleProje.Api.Models.VM;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleProje.Api.Mapping
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Ihale, IhaleVM>();
            CreateMap<IhaleVM, Ihale>();
        }
    }
}
