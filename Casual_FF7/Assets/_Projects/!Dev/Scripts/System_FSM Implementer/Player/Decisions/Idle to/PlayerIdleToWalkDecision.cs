using GenericScriptableArchitecture;
using nyy.FSMBuilder;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Idle/to Walk", fileName = "new Idle to Walk Data")]
    public class PlayerIdleToWalkDecision : Decision
    {
        #region IMPLEMENTED FUNCTIONS
        
        public override bool Decide<T>(Component<T> component)
        {
            // var magnitudeOfMovementVector = InputController.Magnitude?.Invoke();
            // var decide = magnitudeOfMovementVector is < .71f and > 0f;
            // return decide;
            return false;
        }             
         
        #endregion
    }
}