﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    interface IClientRepository<TEntity> : IRepository<TEntity> where TEntity : Client
    {
    }
}