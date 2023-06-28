using nyy.FSMBuilder;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Action/Run", fileName = "new Run Data")]
    public class PlayerRunAction : Action
    {
        #region PROPERTIES
        
        #endregion

        #region IMPLEMENTED FUNCTIONS
        
        public override void Updating<T>(Component<T> component)
        {
            // Run(component);
            // Rotate(component);
            //
            // Detector(component);
            //
            // SetAnimation(component);
            //
            // component.animatorComponent.Request(reqType: RequestType.SetBool, keyword: "EnemyDetectedForAutoAttack",
            //     state: IsEnemyDetectedForAutoAttack.Value);
        }

        #endregion

        #region PRIVATE FUNCTIONS

        private void Run<T>(Component<T> component)
        {
            // component.rigidbodyComponent.Request(reqType: RequestType.Velocity,
            //     float3: MovementVector.Value * (data.RunSpeed * Time.fixedDeltaTime));
        }

        private void Rotate<T>(Component<T> component)
        {
            // if (HorizontalInput.Value == 0 && VerticalInput.Value == 0) return;
            //
            // var direction = (Vector3.forward * VerticalInput.Value + Vector3.right * HorizontalInput.Value).normalized;
            //
            // var rotGoal = Quaternion.LookRotation(direction);
            //
            // component.transform.rotation = Quaternion.Slerp(component.transform.rotation, rotGoal, data.RotationSpeed * Time.deltaTime);
        }

        private void SetAnimation<T>(Component<T> component)
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
            // component.detectComponent.Request(reqType: RequestType.Detector, floatValue: data.Range);
        }
        
        #endregion
    }
}