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
        
        // ReSharper disable Unity.PerformanceAnalysis
        public override void Updating<T>(Component<T> component)
        {
            Run(component);
            Rotate(component);
            SetAnimation(component);
        }

        #endregion

        #region PRIVATE FUNCTIONS

        private void Run<T>(Component<T> component)
        {
            var request = typeof(PhysicComponent<Rigidbody>).GetMethod("Request");

            request!.Invoke(component.GetComponent<PhysicComponent<Rigidbody>>(),
                new object[] { RequestType.Velocity, MovementVector.Value, 85f, 0, "", false });
        }

        private void Rotate<T>(Component<T> component)
        {
            if (HorizontalInput.Value == 0 && VerticalInput.Value == 0) return;
            
            var direction = (Vector3.forward * VerticalInput.Value + Vector3.right * HorizontalInput.Value).normalized;
            
            var rotGoal = Quaternion.LookRotation(direction);
            
            component.transform.rotation = Quaternion.Slerp(component.transform.rotation, rotGoal, 50f * Time.deltaTime);
        }

        private void SetAnimation<T>(Component<T> component)
        {
            var request = typeof(ArtComponent<Animator>).GetMethod("Request");
            
            if (Mathf.Abs(VerticalInput.Value) > Mathf.Abs(HorizontalInput.Value))
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
            // component.detectComponent.Request(reqType: RequestType.Detector, floatValue: data.Range);
        }
        
        #endregion
    }
}