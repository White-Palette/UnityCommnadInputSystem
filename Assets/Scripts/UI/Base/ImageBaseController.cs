using System;
using UnityEngine.UI;
using UnityEngine;

public abstract class ImageBaseController<T> : MonoBehaviour where T : Enum
{
    protected Image _image = null;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public abstract void SetImage(T eventType);
}
