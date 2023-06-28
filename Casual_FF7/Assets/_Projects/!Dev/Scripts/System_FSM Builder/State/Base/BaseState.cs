using nyy.System_Component;
using UnityEngine;
using Sirenix.OdinInspector;

namespace nyy.FSMBuilder
{
    public class BaseState : SerializedScriptableObject
    {
        #region PUBLIC FUNCTIONS
        
        public virtual void Onset<T>(Component<T> component){} //event func. Start()
        public virtual void Updating<T>(Component<T> component){} //event func. Update()
        
        #endregion
    }
}