using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trackPlayer : MonoBehaviour
{
    [SerializeField]
    Transform camTransform;

    [SerializeField]
    Transform _targetTransform;

    Button b;
    void Start()
    {
        b = GetComponent<Button>();
        b.onClick.AddListener(Clicked);
    }

    void Clicked() {
        camTransform.position = new Vector3(_targetTransform.position.x, camTransform.position.y, _targetTransform.position.z);
    }
}
