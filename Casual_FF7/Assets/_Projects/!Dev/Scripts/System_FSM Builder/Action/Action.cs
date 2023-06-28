using JetBrains.Annotations;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.FSMBuilder
{
    public abstract class Action : SerializedScriptableObject
    {
        #region PROPERTIES
        
        // [ColoredGroup("Data",1f,.8f,.4f,1f)]
        // public Data data;
        
        // [TabGroup("Input Variables"),GUIColor(0f,1f,0f,1f)]
        // [ShowInInspector] protected FloatRef VerticalInput;
        // [TabGroup("Input Variables"),GUIColor(0f,1f,0f,1f)]
        // [ShowInInspector] protected FloatRef HorizontalInput;
        // [TabGroup("Input Variables"),GUIColor(0f,1f,0f,1f)]
        // [ShowInInspector] protected Vector3Ref MovementVector;
        //
        // [TabGroup("Detect Variables"),GUIColor(0f,1f,1f,1f)]
        // [ShowInInspector] protected BoolRef IsEnemyDetectedForAutoAttack;
        
        #endregion
        
        #region PUBLIC FUNCTIONS
        
        public virtual void Onset<T>(Component<T> component){}
        public virtual void Updating<T>(Component<T> component){}
        
        #endregion 
    }
}