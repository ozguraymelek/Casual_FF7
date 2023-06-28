using nyy.FSMBuilder;
using nyy.System_Component;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Walk/to Idle", fileName = "new Walk to Idle Data")]
    public class PlayerWalkToIdleDecision : Decision
    {
        #region PROPERTIES
         
        #endregion
                
        #region EVENT FUNCTIONS
        
        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        public override bool Decide<T>(Component<T> component)
        {
            // var magnitudeOfMovementVector = InputController.Magnitude?.Invoke();
            // var decide = magnitudeOfMovementVector is 0f;
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