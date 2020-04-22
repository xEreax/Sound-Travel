using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetButtons : MonoBehaviour
{
    [SerializeField]
    GameObject content;

    [SerializeField]
    GameObject buttonPrefab;
    
    [SerializeField]
    string filterWord;

    Dictionary<string, string[]> finalDict;
    Dictionary<string, string[]> tempDict;

    void filterDictionary(string filterWord) {
        tempDict = GetCoordData.buttonDictionary;
        foreach (KeyValuePair<string, string[]> entry in tempDict) {
            if (entry.Value[0] == filterWord || entry.Value[1] == filterWord) {
                finalDict.Add(entry.Key, entry.Value);
            }
        }
    }
    void Awake() {
        finalDict = new Dictionary<string, string[]>();
        filterDictionary(filterWord);
    }
    void Start() {
        foreach (KeyValuePair<string, string[]> entry in finalDict) {
            GameObject button = Instantiate(buttonPrefab) as GameObject;
            button.SetActive(true);
            ButtonBehaviour b = button.GetComponent<ButtonBehaviour>();
            b.SetLocationName(entry.Key);
            b.SetDescription(entry.Value[0]);
            b.SetExtra(entry.Value[1]);
            b.SetCoords(entry.Value[2]);
            Debug.Log(entry.Value[2]);
            button.transform.SetParent(buttonPrefab.transform.parent, false);
            button.GetComponent<Button>().onClick.AddListener(b.Button_Click);
            button.GetComponent<Button>().GetComponent<Button>().onClick.AddListener(b.Button_Click);
            Text buttonText = button.transform.GetChild(0).GetComponent<Text>();
            buttonText.text = entry.Key + "\n";
        }
    }
}
