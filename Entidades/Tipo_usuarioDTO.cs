﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Entidades
{
    public class Tipo_usuarioDTO
    {
        public void Tipo_usuario()
        {
            this.Usuario = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Denominacion { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
