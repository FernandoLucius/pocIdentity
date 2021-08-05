using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pocIdentity.Data;
using pocIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pocIdentity.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutosController : ControllerBase
    {
        private readonly ContextoBase _contexto;
        public ProdutosController(ContextoBase contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Produto>>> ListarProdutos()
        {
            return await _contexto.Produtos.ToListAsync();
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult<Produto>> Cadastrar([FromBody]Produto produto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Produtos.Add(produto);
                await _contexto.SaveChangesAsync();
                return produto;
            }
            else
                return BadRequest(ModelState);
        }
    }
}
