using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ButtonBehaviour : MonoBehaviour
{
    private string locationName;
    private string coords;
    private string description;
    private string extra;


    public void SetLocationName(string name){
        locationName = name;
    }

    public void SetCoords(string coordinates){
         coords = coordinates;
    }

    public void SetDescription(string desc) {
        description = desc;
    }

    public void SetExtra(string ex) {
        extra = ex;
    }

     public string GetLocationName(){
         return locationName;
    }

    public string GetCoords(){
         return coords;
    }

    public string GetDescription() {
        return description;
    }

    public string GetExtra() {
        return extra;
    }

    public void Button_Click(){
       GetCoordData.coords = coords;
       GetCoordData.coordName = locationName;
       SceneManager.LoadScene("NavigationScene");
    }
   
}
