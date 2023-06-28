using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.FSMBuilder
{
    public abstract class Decision : SerializedScriptableObject
    {
        #region PUBLIC FUNCTIONS
        
        public abstract bool Decide<T>(Component<T> component);
        
        #endregion  
    }
}