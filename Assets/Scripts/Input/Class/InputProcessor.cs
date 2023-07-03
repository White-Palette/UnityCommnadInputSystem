using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputProcessor : InputInformationEditor
{
    public InputProcessor(InputInformation inputInformation) : base(inputInformation) { }

    private InputKeyListSO _inputKeyListSO = null;
    private CommandListSO _commandListSO = null;

    private Stack<InputEvent> _inputEventStack = new Stack<InputEvent>();

    public void Process()
    {
        CheckInputKey();
    }

    private void CheckInputKey()
    {
        if (InputInformation.IsInputChanged)
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
                KeyState keyState = InputInformation.GetKeyState(keyCode);

                if ((int)keyState >= 2)
                {
                    isAllPress = false;
                    break;
                }
            }

            // 여기 조건 약간 변경해야 될듯
            isAllPress = isAllPress && keyCodes.Length == InputInformation.PressingKeyCount;

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
