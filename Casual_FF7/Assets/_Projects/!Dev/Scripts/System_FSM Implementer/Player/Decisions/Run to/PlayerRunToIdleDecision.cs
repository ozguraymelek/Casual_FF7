using nyy.FSMBuilder;
using nyy.System_Component;
using nyy.System_Input;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Run/to Idle", fileName = "new Run to Idle Data")]
    public class PlayerRunToIdleDecision : Decision
    {
        #region IMPLEMENTED FUNCTIONS
        
        public override bool Decide<T>(Component<T> component)
        {
            var magnitudeOfMovementVector = InputController.Magnitude?.Invoke();
            var decide = magnitudeOfMovementVector is 0f;
                
            return decide;
        }             
         
        #endregion  
    }
}