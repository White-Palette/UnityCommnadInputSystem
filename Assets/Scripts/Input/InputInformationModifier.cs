using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputInformationModifier
{
    private readonly InputInformation _inputInformation = null;
    protected InputInformation InputInformation => _inputInformation;

    protected InputInformationModifier(InputInformation inputInformation)
    {
        _inputInformation = inputInformation;
    }
}
