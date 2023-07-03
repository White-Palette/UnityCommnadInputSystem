using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputKeyListSO _inputKeyListSO = null;

    [SerializeField]
    private CommandListSO _commandListSO = null;

    private InputInformation _inputInformation = null;

    private InputDetector _inputDetector = null;

    private Stack<InputEvent> _inputEventStack = new Stack<InputEvent>();

    private int _pressedKeyCount = 0;
    private int _pressingKeyCount = 0;

    void Awake()
    {
        _inputInformation = new InputInformation(_inputKeyListSO.GetUseKeyArray());
        _inputDetector = new InputDetector(_inputInformation);
    }

    private void Update()
    {
        _pressedKeyCount = _pressingKeyCount;
        _pressingKeyCount = 0;

        _inputDetector.RecognizeInput();

        CheckInputKey();
    }

    private void CheckInputKey()
    {


        if (_pressingKeyCount != _pressedKeyCount)
        {
            CheckCommand();
        }
    }

    private void CheckCommand()
    {
        bool isAllUp = true;

        for (int i = 0; i < _inputKeyListSO.Length; ++i)
        {
            InputKey inputKey = _inputKeyListSO.inputKeys[i];

            KeyCode[] keyCodes = inputKey.keyCodes;
            bool isAllPress = true;
            for (int j = 0; j < keyCodes.Length; ++j)
            {
                KeyCode keyCode = keyCodes[j];
                KeyState keyState;// = _useKeyArray.First(x => x.keyCode == keyCode).state;

                // if ((int)keyState >= 2)
                // {
                //     isAllPress = false;
                //     break;
                // }
            }

            // 여기 조건 약간 변경해야 될듯
            isAllPress = isAllPress && keyCodes.Length == _pressingKeyCount;

            if (isAllPress)
            {
                isAllUp = false;
                InputEventManager.ExecuteEvent(inputKey.EventName);
                _inputEventStack.Push(inputKey.EventName);
                break;
            }
        }

        // command 입력 확인하는 코드
        var stackTemp = new Stack<InputEvent>(_inputEventStack);
        List<InputEvent> inputEventList = new List<InputEvent>();

        int count = stackTemp.Count;

        for (int i = 0; i < _commandListSO.inputKeys.Length; ++i)
        {
            if (count < _commandListSO.inputKeys.Length)
            {
                break;
            }
            inputEventList.Add(stackTemp.Pop());
        }

        if (inputEventList.SequenceEqual(_commandListSO.inputKeys))
        {
            Debug.Log(_commandListSO.commandName);
            _inputEventStack.Clear();
        }

        if (isAllUp)
        {
            InputEventManager.ExecuteEvent(InputEvent.Neutral);
        }
    }
}

