using UnityEngine;
using UnityEngine.UI;

public class ShowScreen : MonoBehaviour
{
    [SerializeField]
    GameObject disableScreen;

    [SerializeField]
    GameObject enableScreen;
    
    Button b;
    void Start()
    {
        b = GetComponent<Button>();
        b.onClick.AddListener(showMenu);
    }

    void showMenu() {
        disableScreen.SetActive(false);
        enableScreen.SetActive(true);
    }

}
