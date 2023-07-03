using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandImageController : MonoBehaviour
{
    [SerializeField]
    private Image _image = null;

    private InputEvent _key = InputEvent.Neutral;

    [SerializeField]
    private Sprite[] _sprites = null;

    public void SetDirection(InputEvent eventType)
    {
        this._key = eventType;
        transform.rotation = Quaternion.Euler(0, 0, 0);

        if ((int)_key < 10)
        {
            _image.sprite = _sprites[0];
        }

        switch (_key)
        {
            case InputEvent.LeftDown:
                transform.rotation = Quaternion.Euler(0, 0, 225);
                break;
            case InputEvent.Down:
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case InputEvent.RightDown:
                transform.rotation = Quaternion.Euler(0, 0, 315);
                break;
            case InputEvent.Left:
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case InputEvent.Neutral:
                _image.enabled = false;
                break;
            case InputEvent.Right:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case InputEvent.LeftUp:
                transform.rotation = Quaternion.Euler(0, 0, 135);
                break;
            case InputEvent.Up:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case InputEvent.RightUp:
                transform.rotation = Quaternion.Euler(0, 0, 45);
                break;
            case InputEvent.LP:
                _image.sprite = _sprites[1];
                break;
            case InputEvent.RP:
                _image.sprite = _sprites[2];
                break;
            case InputEvent.LK:
                _image.sprite = _sprites[3];
                break;
            case InputEvent.RK:
                _image.sprite = _sprites[4];
                break;
        }

        gameObject.SetActive(true);
    }
}
