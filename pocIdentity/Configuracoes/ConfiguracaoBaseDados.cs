using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pocIdentity.Data;
using System;

namespace pocIdentity.Configuracoes
{
    public static class ConfiguracaoBaseDados
    {
        public static void AdicionarBancosDados(this IServiceCollection servicos, IConfiguration configuracao)
        {
            if (servicos == null) throw new ArgumentNullException(nameof(servicos));

            servicos.AddDbContext<ContextoBase>(opcoes =>
                opcoes.UseSqlServer(configuracao.GetConnectionString("SqlServer")));
        }
    }
}
