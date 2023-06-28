using nyy.FSMBuilder;
using nyy.System_Component;
using UnityEngine;

namespace nyy.FSMImplement
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/Decision/Walk/to Auto Attack", fileName = "new Walk to Auto Attack Data")]
    public class PlayerWalkToAutoAttackDecision : Decision
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