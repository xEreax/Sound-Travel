using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class customLocation
{

        public string title; //{get; set;}
        public int coordinates; //{get; set;}
        
}


[System.Serializable]
public class Locations
{

    public customLocation[] locations; //{get; set;}

} 


[System.Serializable]
public class readJson : MonoBehaviour
{

    [SerializeField]
	TextAsset customPoints;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(customPoints.text);
       
        Locations jsonLocations = JsonUtility.FromJson<Locations>(customPoints.text);
			
        Debug.Log(jsonLocations.locations);
			/*foreach(customLocation l in jsonLocations.locations)
            {
        	    Debug.Log("location title: " + l);
            }*/
        
    }

  
}
