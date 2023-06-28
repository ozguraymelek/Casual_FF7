using nyy.FSMBuilder;
using UnityEngine;
using nyy.System_Component;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Auto Attack/to Idle", fileName = "new Auto Attack to Idle Decision")]
    public class PlayerAutoAttackToIdleDecision : Decision
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
            // var decide = magnitudeOfMovementVector is 0f;
            //
            // return !isEnemyDetectedForAutoAttack.Value && decide;
            return false;
        }             
         
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
        #endregion
    }
}