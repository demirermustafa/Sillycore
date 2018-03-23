﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sillycore.EntityFramework.Mapping
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DataContextAttribute:Attribute
    {
        private Type _type;

        public Type Type
        {
            get { return _type; }
            set
            {
                if (!value.IsAssignableFrom(typeof(DataContextBase)))
                {
                    throw new InvalidOperationException($"Only types those derive from DataContextBase can be assigned to DataContextAttribute's Type property. The type {value.FullName} is not derived from DataContextBase.");
                }

                _type = value;
            }
        }
    }
}
