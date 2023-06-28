using System.Collections.Generic;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

namespace nyy.FSMBuilder
{
    [CreateAssetMenu(menuName = "Finite State Machine/Player/States/State", fileName = "new Player State")]
    public class State : BaseState
    {
        #region PROPERTIES
        
        [Title("All actions for this state")]
        public List<Action> Actions = new List<Action>();
        
        [Title("All transitions for this state")]
        public List<Transition> Transitions = new List<Transition>();
        
        #endregion
                
        #region IMPLEMENTED FUNCTIONS
        
        public override void Onset<T>(Component<T> component)
        {
            foreach (var action in Actions)
            {
                action.Onset(component);
            }
        }
        
        public override void Updating<T>(Component<T> component)
        {
            foreach (var action in Actions)
            {
                action.Updating(component);
            }
            
            foreach (var transition in Transitions)
            {
                transition.Execute(component);
            }
        }
        
        #endregion  
        
        #region PUBLIC FUNCTIONS
        
        #endregion  
                
        #region PRIVATE FUNCTIONS
        
        #endregion
    }
}