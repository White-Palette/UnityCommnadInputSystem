using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionKeyRecordUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _inputKeyPrefab = null;

    private RectTransform rectTransform = null;
    private Queue<DirectionImageController> _inputKeyQueue = new Queue<DirectionImageController>();

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();


    }
}
