using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchBar : MonoBehaviour
{

    [SerializeField]
    GameObject buttonContainer;

    [SerializeField]
    InputField searchBox;

    Button[] buttons;

    Text t;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        //searchBox = GetComponent<InputField>();
        buttons = buttonContainer.GetComponents<Button>();
        //searchBox.onValueChanged.AddListener(delegate { searchForLocation(); });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void searchForLocation() {
        foreach(Button b in buttons) {
            string searchText = searchBox.text;
            string buttonText = b.GetComponent<Text>().text;
            if (!buttonText.Contains(searchText)){
                b.enabled = false;
            } else {
                b.enabled = true;
            }
        }

        Debug.Log("It runs");
    }
}
