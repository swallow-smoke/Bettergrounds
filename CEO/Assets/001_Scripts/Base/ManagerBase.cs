using UnityEngine;

namespace Base
{
    public abstract class ManagerBase
    {
        public virtual void Initialize()
        {
            Debug.Log($"Initialize {GetType().Name}");
        }
    }
}