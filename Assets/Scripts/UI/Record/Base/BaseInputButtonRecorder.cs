using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseInputButtonRecorder<T> : MonoBehaviour
{
    private BaseImageController<T> _imageBaseController = null;

    private Queue<BaseImageController<T>> _inputKeyQueue = new();

    private void Awake()
    {
        _imageBaseController = transform.GetChild(0).GetComponent<BaseImageController<T>>();
    }

    protected virtual void Start() { }

    public BaseImageController<T> ButtonSetting(T eventType)
    {
        var keyUI = Instantiate(_imageBaseController.gameObject, transform).GetComponent<BaseImageController<T>>();
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
