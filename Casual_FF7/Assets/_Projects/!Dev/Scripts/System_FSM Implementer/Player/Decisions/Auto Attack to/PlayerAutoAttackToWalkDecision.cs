using nyy.FSMBuilder;
using nyy.System_Component;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Auto Attack/to Walk", fileName = "new Auto Attack to Walk Data")]
    public class PlayerAutoAttackToWalkDecision : Decision
    {
        #region PROPERTIES
        
        // public BoolRef isEnemyDetectedForAutoAttack;
        
        #endregion
                
        #region EVENT FUNCTIONS
        
        #endregion
                
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
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
        #endregion
    }
}