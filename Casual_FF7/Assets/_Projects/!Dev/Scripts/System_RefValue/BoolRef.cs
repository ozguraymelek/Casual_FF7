using UnityEngine;
using Sirenix.OdinInspector;

namespace nyy.System_ReferenceValue
{
    public abstract class BoolRef : RefValue
    {
        #region PROPERTIES
        
        public abstract bool Value { get; set; }
        
        protected bool _value;
        
        #endregion
        
        #region PUBLIC FUNCTIONS
        
        #endregion
    }
}