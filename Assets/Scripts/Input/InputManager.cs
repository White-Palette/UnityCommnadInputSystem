using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private ButtonSettingSO _buttonSettingSO = null;

    [SerializeField]
    private InputActionSO _inputActionSO = null;

    private InputInformation _inputInformation = null;

    private ButtonInputDetector _inputDetector = null;
    private InputActionExecutor _inputActionExecutor = null;

    private void Awake()
    {
        KeyCode[] keyCodes = new KeyCode[_buttonSettingSO._buttonMappings.Length];

        for (int i = 0; i < _buttonSettingSO._buttonMappings.Length; ++i)
        {
            keyCodes[i] = _buttonSettingSO._buttonMappings[i].KeyCode;
        }

        _inputInformation = new InputInformation(keyCodes);
        _inputDetector = new ButtonInputDetector(_inputInformation);
        _inputActionExecutor = new InputActionExecutor(_inputInformation, _inputActionSO);
    }

    private void Update()
    {
        _inputDetector.RecognizeInput();
        _inputActionExecutor.CheckAndExecutor();
    }
}

