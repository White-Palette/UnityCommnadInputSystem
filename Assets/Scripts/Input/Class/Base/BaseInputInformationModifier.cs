using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseInputInformationEditor<T> where T : Enum
{
    private readonly BaseInputInformation<T> _inputInformation = null;
    protected BaseInputInformation<T> InputInformation => _inputInformation;

    protected BaseInputInformationEditor(BaseInputInformation<T> inputInformation)
    {
        _inputInformation = inputInformation;
    }
}
