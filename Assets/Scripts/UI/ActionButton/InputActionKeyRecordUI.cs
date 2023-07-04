using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionKeyRecordUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _inputButtonImagePrefab = null;

    private Queue<ActionImageController> _inputKeyQueue = new Queue<ActionImageController>();

    private void Awake()
    {


    }
}
