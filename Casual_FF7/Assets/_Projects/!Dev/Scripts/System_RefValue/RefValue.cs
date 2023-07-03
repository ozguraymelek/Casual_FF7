using GenericScriptableArchitecture;
using Sirenix.OdinInspector;

namespace nyy.System_ReferenceValue
{
    public class RefValue : SerializedScriptableObject
    {
        #region PROPERTIES

        [InfoBox("You can add an event that will be triggered when this reference value changes")]
        [BoxGroup]
        public ScriptableEvent OnValueChanged;

        #endregion

        #region PUBLIC FUNCTIONS

        protected void ValueHasChanged()
        {
            OnValueChanged.Invoke();
        }
        
        #endregion
    }
}