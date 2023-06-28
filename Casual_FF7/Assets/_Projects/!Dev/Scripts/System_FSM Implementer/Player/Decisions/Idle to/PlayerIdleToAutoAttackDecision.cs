using nyy.FSMBuilder;
using UnityEngine;
using nyy.System_Component;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Idle/to Auto Attack", fileName = "new Idle to Auto Attack Data")]
    public class PlayerIdleToAutoAttackDecision : Decision
    {
        #region PROPERTIES
        
        // public BoolRef isEnemyDetectedForAutoAttack;
        
        #endregion
                
        #region EVENT FUNCTIONS
        
        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        public override bool Decide<T>(Component<T> component)
        {
            // return isEnemyDetectedForAutoAttack.Value;
            return false;
        }             
         
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
        #endregion
    }
}