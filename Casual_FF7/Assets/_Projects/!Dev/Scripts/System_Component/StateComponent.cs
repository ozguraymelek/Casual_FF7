using System;
using ExtEvents.OdinSerializer.Utilities;
using nyy.FSMBuilder;
using Sirenix.OdinInspector;
using UnityEditor.Profiling;
using UnityEngine;

namespace nyy.System_Component
{
    public class StateComponent : Component<BaseState>
    {
        #region PROPERTIES

        [ShowInInspector][DisableIn(PrefabKind.All)]
        public override BaseState Value
        {
            get => _val;
            set
            {
                _val = value;
                if (EnableEvent) OnValueChanged.Invoke();
            }
        }

        private BaseState _val;
        
        public BaseState ExecutionValue;
        
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

            Request(RequestType.OnSet);
        }

        private void Update()
        {
            if (_val == null) return;

            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            Request(RequestType.Updating);
            print(Value);
        }

        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        public override void Request(RequestType reqType, Vector3 float3Value = default(Vector3), float floatValue = 0, int intValue = 0,
            bool state = false)
        {
            switch (reqType)
            {
                case RequestType.OnSet:
                    // ReSharper disable once HeapView.PossibleBoxingAllocation
                    Value.Onset(this);
                    break;
                
                case RequestType.Updating:
                    // ReSharper disable once HeapView.PossibleBoxingAllocation
                    Value.Updating(this);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(reqType), reqType, null);
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
        
        #endregion
    }
}