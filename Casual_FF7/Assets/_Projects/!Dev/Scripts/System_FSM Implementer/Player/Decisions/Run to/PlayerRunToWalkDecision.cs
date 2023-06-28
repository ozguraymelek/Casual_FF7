using nyy.FSMBuilder;
using nyy.System_Component;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Run/to Walk", fileName = "new Run to Walk Data")]
    public class PlayerRunToWalkDecision : Decision
    {
        #region IMPLEMENTED FUNCTIONS
        
        public override bool Decide<T>(Component<T> component)
        {
            // var magnitudeOfMovementVector = InputController.Magnitude?.Invoke();
            // var decide = magnitudeOfMovementVector is < .71f and > 0f;
            //
            // return decide;
            return false;
        }             
         
        #endregion  
    }
}