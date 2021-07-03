using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Model
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
