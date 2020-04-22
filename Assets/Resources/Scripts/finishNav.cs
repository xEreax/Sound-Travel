using System;
using System.Collections;
using UnityEngine;
public class finishNav : MonoBehaviour
{
    [SerializeField]
    GameObject finishPrefab;

    [SerializeField]
    Transform destinationPrefab;

    [SerializeField]
    Transform playerPrefab;

    [SerializeField]
    AudioClip finishAudio;

    [SerializeField]
    AudioSource audioSource;

    void Start()
    {
        StartCoroutine(FinishTimer());
    }
    public IEnumerator FinishTimer() {
        bool navigating = true;
        while (navigating) {
            yield return new WaitForSeconds(2);
            if (playerPrefab.position == destinationPrefab.position) {
                Finish();
                navigating = false;
            }
        }
    }
    void Finish() {
        audioSource.Stop();
        audioSource.clip = finishAudio;
        Handheld.Vibrate();
        audioSource.Play();
        finishPrefab.SetActive(true);
    }
}
