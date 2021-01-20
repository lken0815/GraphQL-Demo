using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Gateway
{
    public class Startup
    {
        private const string Users = "users";
        private const string Books = "books";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient(Users, c => c.BaseAddress = new Uri("http://localhost:4000/graphql"));
            services.AddHttpClient(Books, c => c.BaseAddress = new Uri("http://localhost:4001/graphql"));

            services.AddGraphQLServer()
                .AddQueryType(d => d.Name("Query"))
                .AddRemoteSchema(Users, true)
                .AddRemoteSchema(Books, true)
                .AddTypeExtensionsFromFile("./Stitching.graphql");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });
        }
    }
}
