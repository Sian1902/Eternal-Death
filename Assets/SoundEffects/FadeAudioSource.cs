using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAudioSource : MonoBehaviour
{
    [SerializeField] AudioSource WaterSound;
    float duration = 44f;
    float targetVolume = 0f;
    private void Start()
    {
        StartCoroutine(StartFade(WaterSound,duration,targetVolume));
    }
    IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
        {
            float currentTime = 0;
            float start = audioSource.volume;
            while (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
                yield return null;
            }
            yield break;
        }
    
}
