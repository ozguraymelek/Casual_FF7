using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.FSMBuilder
{
    [CreateAssetMenu(menuName = "Finite State Machine/Transition")]
    public sealed class Transition : SerializedScriptableObject
    {
        #region PROPERTIES
        
        [Title("Select decision for transition")]
        public Decision Decision;

        [Title("Select state for transition or stay")]
        public BaseState NewState;
        public BaseState StayState;
        
        #endregion
        
        #region PUBLIC FUNCTIONS
        
        public void Execute<T>(Component<T> component)
        {
            // if (Decision.Decide(component) && NewState is not RemainInState)
            //     component.StateComponent.Value = NewState;
            //
            // else if (Decision.Decide(component) == false && StayState is not RemainInState)
            //     component.StateComponent.Value = StayState;
        }
        
        #endregion 
    }
}