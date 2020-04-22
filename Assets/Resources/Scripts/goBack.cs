using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class goBack : MonoBehaviour
{
    Button b;
    // Start is called before the first frame update
    void Start()
    {
        b = GetComponent<Button>();
        b.onClick.AddListener(GoBack);
    }

    // Update is called once per frame
    void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
