using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GenerateButtons : MonoBehaviour
{
    [SerializeField]
    TextAsset locations;

    [SerializeField]
    GameObject buttonPrefab;

    Dictionary<string,string[]> nameDict;
    

    void PopulateDictionary(string text)
    {
        nameDict = new Dictionary<string,string[]>();
        string[] namedCoords = text.Split(new string[] {":", "\n"}, StringSplitOptions.None);
        for (int i = 0; i < namedCoords.Length; i += 4) {
            string[] s = { namedCoords[i + 1], namedCoords[i + 2], namedCoords[i + 3] };
            nameDict.Add(namedCoords[i], s);
        }
    }

    void Awake()
    {
        PopulateDictionary(locations.text);
        GetCoordData.buttonDictionary = nameDict;
    }
    
    

    public void createButtons(Dictionary<string, string[]> nameDict) {
        foreach (KeyValuePair<string, string[]> entry in nameDict) {
            GameObject button = Instantiate(buttonPrefab) as GameObject;
            button.SetActive(true);
            ButtonBehaviour b = button.GetComponent<ButtonBehaviour>();
            b.SetLocationName(entry.Key);
            b.SetDescription(entry.Value[0]);
            b.SetExtra(entry.Value[1]);
            b.SetCoords(entry.Value[2]);
            button.transform.SetParent(buttonPrefab.transform.parent, false);
            button.GetComponent<Button>().onClick.AddListener(b.Button_Click);
            button.GetComponent<Button>().GetComponent<Button>().onClick.AddListener(b.Button_Click);
            Text buttonText = button.transform.GetChild(0).GetComponent<Text>();
            buttonText.text = entry.Key + "\n";
        }
    }


}
