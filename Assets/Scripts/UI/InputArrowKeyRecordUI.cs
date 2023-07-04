using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputArrowKeyRecordUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _inputKeyPrefab = null;

    private RectTransform rectTransform = null;
    private Queue<DirectionImageController> _inputKeyQueue = new Queue<DirectionImageController>();

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();

        InputEventManager.AddEvent(InputEvent.Up, () => InputDirectionKey(InputEvent.Up));
        InputEventManager.AddEvent(InputEvent.Down, () => InputDirectionKey(InputEvent.Down));
        InputEventManager.AddEvent(InputEvent.Left, () => InputDirectionKey(InputEvent.Left));
        InputEventManager.AddEvent(InputEvent.Right, () => InputDirectionKey(InputEvent.Right));
        InputEventManager.AddEvent(InputEvent.LeftUp, () => InputDirectionKey(InputEvent.LeftUp));
        InputEventManager.AddEvent(InputEvent.LeftDown, () => InputDirectionKey(InputEvent.LeftDown));
        InputEventManager.AddEvent(InputEvent.RightUp, () => InputDirectionKey(InputEvent.RightUp));
        InputEventManager.AddEvent(InputEvent.RightDown, () => InputDirectionKey(InputEvent.RightDown));

        InputEventManager.AddEvent(InputEvent.Neutral, () => InputDirectionKey(InputEvent.Neutral));
    }

    public void InputDirectionKey(InputEvent direction)
    {
        var keyUI = Instantiate(_inputKeyPrefab, transform).GetComponent<DirectionImageController>();
        keyUI.SetDirection(direction);
        _inputKeyQueue.Enqueue(keyUI);

        if (_inputKeyQueue.Count > 32)
        {
            var key = _inputKeyQueue.Dequeue();
            Destroy(key.gameObject);
        }
    }
}
