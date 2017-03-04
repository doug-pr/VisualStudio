using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TrabalhoEntity.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}