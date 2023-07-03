using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.System_Component
{
    public class PhysicComponent<T> : Component<T>
    {
        #region PROPERTIES
        public override T Value 
        { 
            get => _val;
            set => _val = value;
        }
        
        public T ExecutionValue;
        
        private T _val;
        
        #endregion
                
        #region EVENT FUNCTIONS
        
        private void Awake()
        {
            if (Execution == SetExecution.Awake)
                ValueSet();
        }

        private void OnEnable()
        {
            if (Execution == SetExecution.OnEnable)
                ValueSet();
        }

        private void Start()
        {
            if (Execution == SetExecution.Start)
                ValueSet();
        }
        
        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        public override void Request(RequestType reqType, Vector3 float3Value = default(Vector3), float floatValue = 0, int intValue = 0,
            bool state = false)
        {
            switch (reqType)
            {
                case RequestType.Velocity:
                    // ReSharper disable once HeapView.PossibleBoxingAllocation
                    var converted = ChangeType<Rigidbody>(Value);
                    converted.velocity = float3Value * floatValue * Time.fixedDeltaTime;
                    break;
            }
        }
         
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS

        private void ValueSet()
        {
            _val = ExecutionValue;
        }
        
#pragma warning disable CS0693
        protected T ChangeType<T>(object o)
#pragma warning restore CS0693
        {
            var conversionType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            return (T)Convert.ChangeType(o, conversionType);
        }
        
        #endregion

        
    }
}