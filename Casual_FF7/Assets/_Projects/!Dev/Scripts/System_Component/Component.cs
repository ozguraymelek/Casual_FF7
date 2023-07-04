using System;
using GenericScriptableArchitecture;
using nyy.FSMBuilder;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.System_Component
{
    public abstract class Component<T> : MonoBehaviour
    {
        #region PROPERTIES

        public abstract T Value
        {
            get;
            set;
        }
        
        [ShowInInspector]
        protected bool EnableEvent;
        public ScriptableEvent OnValueChanged;
        
        [ShowInInspector]
        protected SetExecution Execution;
        
        #endregion

        #region EVENT FUNCTIONS

        #endregion

        #region IMPLEMENTED FUNCTIONS

        public abstract void Request(RequestType reqType, Vector3 float3Value = default(Vector3), float floatValue = 0,
            int intValue = 0, string keyword = "",
            bool state = false);

        #endregion

        #region PUBLIC FUNCTIONS

        #endregion

        #region PRIVATE FUNCTIONS

        #endregion
    }
    
    public interface IComponent<in T>
    {
        void Request(RequestType reqType, Vector3 float3Value = default(Vector3), float floatValue = 0, int intValue = 0,
            bool state = false);
    }
    
    public enum RequestType
    {
        OnSet, Updating,
        Enable, Disable, Trigger,
        Velocity, Drag, Gravity,
        SetFloat, SetInt, SetBool, SetTrigger, ResetTrigger
    }
    
    [EnumToggleButtons]
    public enum SetExecution
    {
        Awake, Start, OnEnable,
    }
}