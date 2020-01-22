using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ByteBank.Forum.Models
{
    public static class teste
    {
        public static bool Verificar<T>(T param)
        {
            if(param.GetType() == Int)
            return false;
        }
    }
}