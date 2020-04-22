using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LaunchMap : MonoBehaviour
{
    [SerializeField]
    GameObject buttonPrefab;

    //Load game scene
    public void StartGame()
    {
        buttonPrefab.GetComponent<Button>();
        SceneManager.LoadScene("NavigationScene");
    }
}
