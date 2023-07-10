using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class InputButtonBaseRecorder<T> : MonoBehaviour
{
    private ImageBaseController<T> _imageBaseController = null;

    private Queue<ImageBaseController<T>> _inputKeyQueue = new();

    private void Awake()
    {
        _imageBaseController = transform.GetChild(0).GetComponent<ImageBaseController<T>>();
    }

    protected virtual void Start() { }

    public ImageBaseController<T> ButtonSetting(T eventType)
    {
        var keyUI = Instantiate(_imageBaseController.gameObject, transform).GetComponent<ImageBaseController<T>>();
        keyUI.SetImage(eventType);

        _inputKeyQueue.Enqueue(keyUI);

        if (_inputKeyQueue.Count > 32)
        {
            var key = _inputKeyQueue.Dequeue();
            Destroy(key.gameObject);
        }

        return keyUI;
    }
}
