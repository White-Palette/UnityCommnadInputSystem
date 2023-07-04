using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionImageController : MonoBehaviour
{
    [SerializeField]
    private Image _image = null;

    private Direction _key = Direction.Neutral;

    public void SetDirection(Direction eventType)
    {
        this._key = eventType;

        switch (_key)
        {
            case Direction.LeftDown:
                transform.rotation = Quaternion.Euler(0, 0, 225);
                break;
            case Direction.Down:
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case Direction.RightDown:
                transform.rotation = Quaternion.Euler(0, 0, 315);
                break;
            case Direction.Left:
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case Direction.Neutral:
                _image.enabled = false;
                break;
            case Direction.Right:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case Direction.LeftUp:
                transform.rotation = Quaternion.Euler(0, 0, 135);
                break;
            case Direction.Up:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case Direction.RightUp:
                transform.rotation = Quaternion.Euler(0, 0, 45);
                break;
        }

        gameObject.SetActive(true);
    }
}
