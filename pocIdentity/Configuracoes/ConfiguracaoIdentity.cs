using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pocIdentity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pocIdentity.Configuracoes
{
    public static class ConfiguracaoIdentity
    {
        public static void AdicionarIdentity(this IServiceCollection servicos)
        {
            if (servicos == null) throw new ArgumentNullException(nameof(servicos));

            servicos
                .AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ContextoBase>()
                .AddDefaultTokenProviders();
        }
    }
}
