using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputKeyRecordUI _inputKeyRecordUI = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Right);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Down);
        }
    }
}
