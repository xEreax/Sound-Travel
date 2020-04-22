using UnityEngine;
using UnityEngine.UI;

public class soundToggle : MonoBehaviour
{

    [SerializeField]
    GameObject destinationPrefab;

    [SerializeField]
    Sprite onImage;

    [SerializeField]
    Sprite offImage;

    Button b;
    Image i;
    AudioSource a;
    void Start()
    {
        a = destinationPrefab.GetComponent<AudioSource>();
        b = GetComponent<Button>();
        i = b.image;
        b.onClick.AddListener(ToggleSound);   
    }

    void ToggleSound() {
        if (i.sprite == onImage) {
            i.sprite = offImage;
            a.mute = true;
        } else {
            i.sprite = onImage;
            a.mute = false;
        }
    }
}
