using System;
using nyy.FSMBuilder;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy
{
    public class BaseComponent : MonoBehaviour
    {
        #region PROPERTIES

        [ShowInInspector]
        protected StateComponent CurrentBaseState;
        
        #endregion
                
        #region EVENT FUNCTIONS

        private void Awake()
        {
            CurrentBaseState = GetComponent<StateComponent>();
        }

        private void Start()
        {
            CurrentBaseState.Request(RequestType.OnSet);
        }

        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
        #endregion
    }
}