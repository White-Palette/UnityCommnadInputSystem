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
        _inputInformation = new InputInformation();
        _inputDetector = new ButtonInputDetector(_inputInformation, _buttonSettingSO);
        _inputActionExecutor = new InputActionExecutor(_inputInformation, _inputActionSO);
    }

    private void Update()
    {
        _inputDetector.RecognizeInput();
        _inputActionExecutor.CheckAndExecutor();
    }
}

