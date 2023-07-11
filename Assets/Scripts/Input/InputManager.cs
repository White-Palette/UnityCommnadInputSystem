using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private DirectionSettingSO _buttonSettingSO = null;

    [SerializeField]
    private ButtonSettingSO _directionSettingSO = null;

    [SerializeField]
    private InputActionSO _inputActionSO = null;

    private InputDirectionInformation _inputInformation = null;
    private InputButtonInformation _inputButtonInformation = null;

    private DirectionInputDetector _directionInputDetector = null;
    private ButtonInputDetector _buttonInputDetector = null;

    private InputActionExecutor _inputActionExecutor = null;

    private void Awake()
    {
        _inputInformation = new InputDirectionInformation();
        _inputButtonInformation = new InputButtonInformation();

        _directionInputDetector = new DirectionInputDetector(_inputInformation, _buttonSettingSO);
        _buttonInputDetector = new ButtonInputDetector(_inputButtonInformation, _directionSettingSO);

        _inputActionExecutor = new InputActionExecutor(_inputInformation, _inputActionSO);

    }

    private void Update()
    {
        _directionInputDetector.RecognizeInput();
        _buttonInputDetector.RecognizeInput();

        _inputActionExecutor.CheckAndExecutor();
    }
}

