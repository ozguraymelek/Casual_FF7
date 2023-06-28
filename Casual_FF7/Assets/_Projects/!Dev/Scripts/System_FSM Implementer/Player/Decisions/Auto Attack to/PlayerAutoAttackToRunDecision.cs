using nyy.FSMBuilder;
using UnityEngine;
using nyy.System_Component;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Auto Attack/to Run", fileName = "new Auto Attack to Run Decision")]
    public class PlayerAutoAttackToRunDecision : Decision
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
            // var decide = magnitudeOfMovementVector is > .71f and <= 1f;
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