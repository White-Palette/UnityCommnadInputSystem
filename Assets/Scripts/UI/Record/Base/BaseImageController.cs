using System;
using UnityEngine.UI;
using UnityEngine;

public abstract class BaseImageController<T> : MonoBehaviour
{
    private Image _image = null;
    protected Image CommandImage => _image ??= GetComponent<Image>();

    public abstract void SetImage(T eventType);
}
