using nyy.FSMBuilder;
using nyy.System_Component;
using nyy.System_Input;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Idle/to Run", fileName = "new Idle to Run Data")]
    public class PlayerIdleToRunDecision : Decision
    {
        #region IMPLEMENTED FUNCTIONS
        
        public override bool Decide<T>(Component<T> component)
        {
            var magnitudeOfMovementVector = InputController.Magnitude?.Invoke();
            var decide = magnitudeOfMovementVector is > .71f and <= 1f;
            
            return decide;
        }             
         
        #endregion
    }
}