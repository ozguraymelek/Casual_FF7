using nyy.System_Component;
using UnityEngine;

namespace nyy.FSMBuilder
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Action/Auto Attack", fileName = "new Auto Attack Data")]
    public class PlayerAutoAttack : Action
    {
        #region PROPERTIES
        
        #endregion
                
        #region EVENT FUNCTIONS
        
        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        public override void Onset<T>(Component<T> component)
        {
            
        }

        public override void Updating<T>(Component<T> component)
        {
            // component.animatorComponent.Request(reqType: RequestType.SetFloat, keyword: "Speed",
            //     floatValue: 0);
            //
            // component.animatorComponent.Request(reqType: RequestType.SetBool, keyword: "EnemyDetectedForAutoAttack",
            //     state: IsEnemyDetectedForAutoAttack.Value);
            //
            // LookAt(component);
            // Move(component);
            //
            // Detector(component);
            //     
            // SetStepAnimation(component);
        }        
         
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
        private void LookAt<T>(Component<T> component)
        {
            // if (HorizontalInput.Value != 0 && VerticalInput.Value != 0) return;
            //
            // var targetPos = component.DetectComponent.Value.collider.transform.position;
            //
            // targetPos.y = component.transform.position.y;
            //
            // var targetDir = Quaternion.LookRotation(targetPos - component.transform.position);
            //
            // component.transform.rotation =
            //     Quaternion.Slerp(component.transform.rotation, targetDir, 25 * Time.deltaTime);
        }
        
        private void Move<T>(Component<T> component)
        {
            // component.rigidbodyComponent.Request(reqType: RequestType.Velocity,
            //     float3: MovementVector.Value * (120 * Time.fixedDeltaTime));
        }
        
        private void Rotate<T>(Component<T> component)
        {
            // if (HorizontalInput.Value == 0 && VerticalInput.Value == 0) return;
            // if (IsEnemyDetectedForAutoAttack.Value == true) return;
            //
            // var direction = (Vector3.forward * VerticalInput.Value + Vector3.right * HorizontalInput.Value).normalized;
            //
            // var rotGoal = Quaternion.LookRotation(direction);
            //
            // component.transform.rotation = Quaternion.Slerp(component.transform.rotation, rotGoal, 30 * Time.deltaTime);
        }
        
        private void SetStepAnimation<T>(Component<T> component)
        {
            // if (Mathf.Abs(VerticalInput.Value) > Mathf.Abs(HorizontalInput.Value))
            //     component.animatorComponent.Request(reqType: RequestType.SetFloat, keyword: "Speed",
            //         floatValue: Mathf.Abs(VerticalInput.Value));
            //
            // if (Mathf.Abs(HorizontalInput.Value) > Mathf.Abs(VerticalInput.Value))
            //     component.animatorComponent.Request(reqType: RequestType.SetFloat, keyword: "Speed",
            //         floatValue: Mathf.Abs(HorizontalInput.Value));
        }
        
        private void Detector<T>(Component<T> component)
        {
            // if (HorizontalInput.Value != 0 && VerticalInput.Value != 0) return;
            // component.detectComponent.Request(reqType: RequestType.Detector, floatValue: .5f);
        }
        
        #endregion
    }
}