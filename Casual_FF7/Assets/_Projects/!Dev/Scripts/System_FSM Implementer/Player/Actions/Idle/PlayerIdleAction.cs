using nyy.FSMBuilder;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

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
            // Idle(component);
        }

        public override void Updating<T>(Component<T> component)
        {
            // SetAnimation(component);
            // Detector(component);
            
            // component.animatorComponent.Request(reqType: RequestType.SetBool, keyword: "EnemyDetectedForAutoAttack",
            //     state: IsEnemyDetectedForAutoAttack.Value);
        }        
         
        #endregion  
                
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