using UnityEngine;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections.Generic;
using Mapbox.Directions;
using System.Linq;
//using Data;
//using Modifiers;
using System.Collections;


public class GetDestination : MonoBehaviour
{
   
   [SerializeField]
		AbstractMap _map;
   
   [SerializeField]
	GameObject destinationPrefab;
    // Start is called before the first frame update

    void Awake()
    {
        Vector2d destination = Conversions.StringToLatLon("-0.3324412, 5.5910487");
        //GameObject instance = Instantiate(destinationPrefab) as GameObject;
        //destinationPrefab.transform.MoveToGeocoordinate(destination, new Vector2d(0,0), 10f);
       //instance.transform.localPosition = _map.GeoToWorldPosition(destination, true);
       //instance.transform.localScale = new Vector3(1f, 1f, 1f);
        //var latLng = destinationPrefab.transform.GetGeoPosition(_map.CenterMercator, 1);
       // Debug.Log(latLng);
       
        //Debug.Log(destinationPrefab.transform.localPosition);
    }
    
}
