﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Class1
    {
        public static int Acerto = 0;
        public static int Erro = 0;

        public static void Acertou()
        {
            Acerto++;
        }
        
        public static void Errou()
        {
            Erro++;
        }

        public static int MostrarAcertos()
        {
            return Acerto;
        }

        public static int MostrarErro()
        {
            return Erro;
        }
    }
}
