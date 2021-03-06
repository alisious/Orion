﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{
    public abstract class Entity :IEntity
    {

        private Guid _id = Guid.NewGuid();

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
