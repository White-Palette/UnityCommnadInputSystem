using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private DirectionSettingSO _buttonSettingSO = null;

    [SerializeField]
    private ButtonSettingSO _directionSettingSO = null;

    [SerializeField]
    private InputActionSO _inputDirectionActionSO = null;

    [SerializeField]
    private InputButtonActionSO _inputButtonActionSO = null;

    private InputDirectionInformation _inputInformation = null;
    private InputButtonInformation _inputButtonInformation = null;

    private DirectionInputDetector _directionInputDetector = null;
    private ButtonInputDetector _buttonInputDetector = null;

    private InputDirectionActionExecutor _inputActionExecutor = null;
    private InputButtonActionExecutor _inputButtonActionExecutor = null;

    private void Awake()
    {
        _inputInformation = new InputDirectionInformation();
        _inputButtonInformation = new InputButtonInformation();

        _directionInputDetector = new DirectionInputDetector(_inputInformation, _buttonSettingSO);
        _buttonInputDetector = new ButtonInputDetector(_inputButtonInformation, _directionSettingSO);

        _inputActionExecutor = new InputDirectionActionExecutor(_inputInformation, _inputDirectionActionSO);
        _inputButtonActionExecutor = new InputButtonActionExecutor(_inputButtonInformation, _inputButtonActionSO);

    }

    private void Update()
    {
        _directionInputDetector.RecognizeInput();
        _buttonInputDetector.RecognizeInput();

        _inputActionExecutor.CheckAndExecutor();
        _inputButtonActionExecutor.CheckAndExecutor();
    }
}

