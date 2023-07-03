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
        
        public override void Onset<T>(Component<T> component)
        {
            Debug.Log("Idle Start Action");
        }

        public override void Updating<T>(Component<T> component)
        {
            Debug.Log("Idle Update Action");
            
            var metSum = typeof(PhysicComponent<Rigidbody>).GetMethod("Request");
            metSum!.Invoke(component.GetComponent<PhysicComponent<Rigidbody>>(),
                new object[] { RequestType.Velocity, new Vector3(0f, 0f, 50f), 2, 0, false });


            // SetAnimation(component);
            // Detector(component);

            // component.animatorComponent.Request(reqType: RequestType.SetBool, keyword: "EnemyDetectedForAutoAttack",
            //     state: IsEnemyDetectedForAutoAttack.Value);
        }        
         
        #endregion  
#pragma warning disable CS0693
        protected T ChangeType<T>(object o)
#pragma warning restore CS0693
        {
            var conversionType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            return (T)Convert.ChangeType(o, conversionType);
        }
        #region PRIVATE FUNCTIONS
        private void Idle<T>(Component<T> component)
        {
            // component.rigidbodyComponent.Request(reqType: RequestType.Velocity,
            //     float3: Vector3.zero);
        }
        
        private void SetAnimation<T>(Component<T> component)
        {
            // if (Mathf.Abs(VerticalInput.Value) >= Mathf.Abs(HorizontalInput.Value))
            //     component.animatorComponent.Request(reqType: RequestType.SetFloat, keyword: "Speed",
            //         floatValue: Mathf.Abs(VerticalInput.Value));
            //
            // if (Mathf.Abs(HorizontalInput.Value) > Mathf.Abs(VerticalInput.Value))
            //     component.animatorComponent.Request(reqType: RequestType.SetFloat, keyword: "Speed",
            //         floatValue: Mathf.Abs(HorizontalInput.Value));
        }

        private void Detector<T>(Component<T> component)
        {
            // component.detectComponent.Request(reqType: RequestType.Detector, floatValue: .5f);
        }
        
        #endregion
    }
}