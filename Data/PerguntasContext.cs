using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap01.Models;


namespace Fiap01.Data
{
    public class PerguntasContext : DbContext 
    {

        public PerguntasContext(DbContextOptions<PerguntasContext> options) : base(options)
        {

        }

        public DbSet<Pergunta> Perguntas { get; set; }
    }
}
