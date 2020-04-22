using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using Mapbox.Unity.Utilities;



public class PositionAtCoordinate : MonoBehaviour
{
    [SerializeField]
    AbstractMap map;

    private string[] coords;

    private string[] getCoords() {
        string[] temp = new string[]{ "0", "0" };
        if (GetCoordData.coords != null) {
            temp = GetCoordData.coords.Split(","[0]);
        }
        return temp;
    }

    void Start()
    {
        coords = getCoords();
        transform.localPosition = map.GeoToWorldPosition(new Vector2d(Convert.ToDouble(coords[1]), Convert.ToDouble(coords[0])));
        
    }

    //note that coords are switched
    void LateUpdate()
    {

        if (coords != null) {
            transform.localPosition = map.GeoToWorldPosition(new Vector2d(Convert.ToDouble(coords[1]), Convert.ToDouble(coords[0])));
        }
    }
}
