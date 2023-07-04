using System;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;
using Action = nyy.FSMBuilder.Action;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Action/Idle", fileName = "new Idle Data")]
    public class PlayerIdleAction : Action
    {
        #region PROPERTIES
        
        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        // ReSharper disable Unity.PerformanceAnalysis
        public override void Onset<T>(Component<T> component)
        {
            
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public override void Updating<T>(Component<T> component)
        {
            Idle(component);
            SetAnimation(component);
        }        
         
        #endregion  
        
        #region PRIVATE FUNCTIONS
        
        private void Idle<T>(Component<T> component)
        {
            var request = typeof(PhysicComponent<Rigidbody>).GetMethod("Request");

            request!.Invoke(component.GetComponent<PhysicComponent<Rigidbody>>(),
                new object[] { RequestType.Velocity, Vector3.zero, 2, 0, "", false });
        }
        
        private void SetAnimation<T>(Component<T> component)
        {
            var request = typeof(ArtComponent<Animator>).GetMethod("Request");
            
            if (Mathf.Abs(VerticalInput.Value) >= Mathf.Abs(HorizontalInput.Value))
                request!.Invoke(component.GetComponent<ArtComponent<Animator>>(), new object[]
                {
                    RequestType.SetFloat,
                    Vector3.zero, Mathf.Abs(VerticalInput.Value), 0, "Speed", false
                });

            
            if (Mathf.Abs(HorizontalInput.Value) > Mathf.Abs(VerticalInput.Value))
                request!.Invoke(component.GetComponent<ArtComponent<Animator>>(), new object[]
                {
                    RequestType.SetFloat,
                    Vector3.zero, Mathf.Abs(HorizontalInput.Value), 0, "Speed", false
                });
        }

        private void Detector<T>(Component<T> component)
        {
            // component.detectComponent.Request(reqType: RequestType.Detector, floatValue: .5f);
        }
        
        #endregion
    }
}