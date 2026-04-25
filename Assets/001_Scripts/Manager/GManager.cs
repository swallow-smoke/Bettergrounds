using System.Collections.Generic;
using Base;
using UnityEngine;

namespace _001_Scripts.Manager
{
    public class GManager : ManagerBase
    {
        [SerializeField] private Dictionary<string, ManagerBase> _managers;
        
        public override void Initialize()
        {
            base.Initialize();

            foreach (var manager in _managers)
            {
                manager.Value.Initialize();
            }
        }

        public ManagerBase GetManager(string key) {
            return _managers.TryGetValue(key, out var managerBase) ? managerBase : null;
        }
    }
}