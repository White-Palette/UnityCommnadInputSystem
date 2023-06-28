using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyRecordUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _inputKeyPrefab = null;

    private RectTransform rectTransform = null;
    private Queue<ArrowImageDirection> _inputKeyQueue = new Queue<ArrowImageDirection>();

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void InputDirectionKey(Direction direction)
    {
        var keyUI = Instantiate(_inputKeyPrefab, transform).GetComponent<ArrowImageDirection>();
        keyUI.SetDirection(direction);
        _inputKeyQueue.Enqueue(keyUI);

        if (_inputKeyQueue.Count > 32)
        {
            var key = _inputKeyQueue.Dequeue();
            Destroy(key.gameObject);
        }
    }
}
