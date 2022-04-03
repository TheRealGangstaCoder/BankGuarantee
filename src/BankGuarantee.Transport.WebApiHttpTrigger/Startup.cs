using System;
using System.IO;
using BankGuarantee.Core.Actions;
using BankGuarantee.Transport.WebApiHttpTrigger.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace BankGuarantee.Transport.WebApiHttpTrigger
{
    public class Startup
    {
        private readonly IWebHostEnvironment _hostingEnv;

        private IConfiguration Configuration { get; }
        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _hostingEnv = env;
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services
                .AddMvc(options =>
                {
                    options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>();
                    options.OutputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter>();
                })
                .AddNewtonsoftJson(opts =>
                {
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opts.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
                })
                .AddXmlSerializerFormatters();


            services
                .AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("10.0.0", new OpenApiInfo
                    {
                        Version = "10.0.0",
                        Title = "Bank Guarantee",
                        Description = "CBA BIAN Implementation of Bank Guarantee",
                        Contact = new OpenApiContact()
                        {
                            Name = "Test Environment 'https://secure.group.api.test.commbank.com.au/BIAN-3/BankGuarantee/10.0.0' ",
                            Url = new Uri("https://secure.group.api.test.commbank.com.au/BIAN-3/BankGuarantee/10.0.0"),
                            Email = ""
                        },
                    });
                    c.CustomSchemaIds(type => type.FullName);
                    //c.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{_hostingEnv.ApplicationName}.xml");
                    // Sets the basePath property in the Swagger document generated
                    c.DocumentFilter<BasePathFilter>("/BIAN-3/BankGuarantee/10.0.0");

                    // Include DataAnnotation attributes on Controller Action parameters as Swagger validation rules (e.g required, pattern, ..)
                    // Use [ValidateModelState] on Actions to actually validate it in C# as well!
                    c.OperationFilter<GeneratePathParamsValidationFilter>();
                });

            services.AddScoped<IBQBankGuaranteeIssuanceAndBookingTask, BQBankGuaranteeIssuanceAndBookingTask>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //TODO: Enable production exception handling (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling)
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //TODO: Either use the SwaggerGen generated Swagger contract (generated from C# classes)
                c.SwaggerEndpoint("/swagger/10.0.0/swagger.json", "Bank Guarantee");

                //TODO: Or alternatively use the original Swagger contract that's included in the static files
                // c.SwaggerEndpoint("/swagger-original.json", "Bank Guarantee Original");
            });

        }
    }
}
