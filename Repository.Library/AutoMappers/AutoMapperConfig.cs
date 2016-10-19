using AutoMapper;
using Repository.Library.DbContext.Entities;
using Repository.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Library.AutoMappers
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            //??ham initialze la demap 2 cai doi tuong 
            Mapper.Initialize(cfg =>
            {
                // Khai bao map object tai day
                cfg.CreateMap<Student, StudentMeta>();
                cfg.CreateMap<StudentMeta, Student>(); 
            });
        }
    }
}