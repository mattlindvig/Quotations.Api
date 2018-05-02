using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controllers;
using Interfaces.Controller;
using Interfaces.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository;
using Repository.EF;
using ServiceModel;

namespace Quotations.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<DatabaseSetup>
                (option => option.UseSqlServer(Configuration["database:connection"], b => b.MigrationsAssembly("Repository")));
            services.AddTransient<IQuoteController, QuoteController>();
            services.AddTransient<ISqlQuotes, QuoteRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
