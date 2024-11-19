using _VC.Application.Contents.MailServicesIntr;
using _VC.Domain.Contents.MailEntities;
using _VC.Persistance.Repositories.MailServicesRep;
using IMS.Application.Interfaces.IEntitiesRepo;
using IMS.Application.Interfaces;
using IMS.Domain.Entites;
using IMS.Persistance.Repositories.EntitiesRepo;
using IMS.Persistance.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace IMS.Persistance.Tests
{
    public static class TestingContainer
    {
        public static IServiceCollection AddTestingService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InMemoryDbContext>(opt =>
            opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));

            return services;

        }
    }
}
