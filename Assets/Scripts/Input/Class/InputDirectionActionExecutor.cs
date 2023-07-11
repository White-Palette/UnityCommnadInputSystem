using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputDirectionActionExecutor : BaseInputInformationEditor<EnableDirection>
{
    private readonly InputActionSO _inputActionSO = null;

    public InputDirectionActionExecutor(InputDirectionInformation inputInformation, InputActionSO inputActionSO) : base(inputInformation)
    {
        _inputActionSO = inputActionSO;
    }

    public void CheckAndExecutor()
    {
        _inputActionSO._inputActionMappings.ToList().ForEach(inputActionMapping =>
        {
            if (inputActionMapping.EnableButton.ToList().TrueForAll(enableButton => InputInformation.KeyStateDictionary[enableButton] == KeyState.Press) && inputActionMapping.EnableButton.Length == InputInformation.PressingCount)
            {
                InputEventManager.ExecuteEvent(inputActionMapping.InputName);
            }
        });
    }
}
