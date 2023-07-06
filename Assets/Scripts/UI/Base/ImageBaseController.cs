using System;
using UnityEngine.UI;
using UnityEngine;

public abstract class ImageBaseController<T> : MonoBehaviour where T : Enum
{
    private Image _image = null;
    protected Image CommandImage => _image ??= GetComponent<Image>();

    public abstract void SetImage(T eventType);
}
