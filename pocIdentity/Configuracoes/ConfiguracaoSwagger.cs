using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pocIdentity.Configuracoes
{
    public static class ConfiguracaoSwagger
    {
        public static void AdicionarSwagger(this IServiceCollection servicos)
        {
            if (servicos == null) throw new ArgumentNullException(nameof(servicos));

            servicos.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "pocIdentity", Version = "v1" });
            });
        }

        public static void UsarConfiguracaoSwagger(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "pocIdentity v1"));
        }
    }
}
