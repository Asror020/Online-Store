<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
=======
﻿using Microsoft.OpenApi.Models;
>>>>>>> 590daec0dc66520f7b7354303db1793ad334c24f

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
<<<<<<< HEAD
            
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c => 
            {
                var securityScheme = new OpenApiSecurityScheme
                {
                    Description = "JWT Auth Bearer Scheme",
                    Name = "Authorization",
=======
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                var securitySchema = new OpenApiSecurityScheme
                {
                    Description = "JWT Auth Bearer Scheme",
                    Name = "Authorisation",
>>>>>>> 590daec0dc66520f7b7354303db1793ad334c24f
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                };

<<<<<<< HEAD
                c.AddSecurityDefinition("Bearer", securityScheme);
=======
                c.AddSecurityDefinition("Bearer", securitySchema);
>>>>>>> 590daec0dc66520f7b7354303db1793ad334c24f

                var securityRequirement = new OpenApiSecurityRequirement
                {
                    {
<<<<<<< HEAD
                        securityScheme, new[] {"Bearer"}
=======
                        securitySchema, new[]{"Bearer"}
>>>>>>> 590daec0dc66520f7b7354303db1793ad334c24f
                    }
                };

                c.AddSecurityRequirement(securityRequirement);
            });
<<<<<<< HEAD

=======
>>>>>>> 590daec0dc66520f7b7354303db1793ad334c24f
            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
<<<<<<< HEAD

             app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "";
            });
            
            return app;
        }
    }
}
=======
            return app;
        }
    }
}
>>>>>>> 590daec0dc66520f7b7354303db1793ad334c24f
