﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumirApiBlazor.Modelos
{
    public class Personaje
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public string Localizacion { get; set; }
        //todo agregar un array para amigos, en los 2 modelos
        //

    }
}
