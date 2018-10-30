using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool isValid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
    }

    public enum EntityStateOption
    {
        Active,
        Deleted
    }
}
