using System;
using nyy.FSMBuilder;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.System_Component
{
    public class StateComponent : Component<BaseState>,  IComponent<BaseState>
    {
        #region PROPERTIES
        
        [ShowInInspector]
        public override BaseState Value 
        { 
            get => _val;
            set => _val = value;
        }
        
        private BaseState _val;
        
        [ShowInInspector]
        protected BaseState ExecutionValue;
        
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
        
        public void Request(RequestType reqType, Vector3 float3Value = default(Vector3), float floatValue = 0, int intValue = 0,
            bool state = false)
        {
            switch (reqType)
            {
                case RequestType.OnSet:
                    print("SA");
                    // ReSharper disable once HeapView.PossibleBoxingAllocation
                    Value.Onset(this);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(reqType), reqType, null);
            }
        }
         
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
#pragma warning disable CS0693
        private T ChangeType<T>(object o)
#pragma warning restore CS0693
        {
            var conversionType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            return (T)Convert.ChangeType(o, conversionType);
        }
        
        private void ValueSet()
        {
            _val = ExecutionValue;
        }
        
        #endregion
    }
}