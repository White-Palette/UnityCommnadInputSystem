using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionImageController : MonoBehaviour
{
    [SerializeField]
    private Image _image = null;

    private InputEvent _key = InputEvent.Neutral;

    public void SetDirection(InputEvent eventType)
    {
        this._key = eventType;

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
        }

        gameObject.SetActive(true);
    }
}
