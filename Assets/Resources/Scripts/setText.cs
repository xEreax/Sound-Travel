using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text t = GetComponent<Text>();
        t.text = "To: " + GetCoordData.coordName;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
