using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 3f;
    float dirction;
    Animator DoorAnimation;
    GameObject key;

    private void Start()
    {
        key = GameObject.FindGameObjectWithTag("Key");
    }
    private void Awake()
    {
        DoorAnimation = GetComponent<Animator>();
        DoorAnimation.enabled = false;
    }
    private void Update()
    {
        dirction = Input.GetAxisRaw("Vertical");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player") && !key.activeSelf)
        {
            StartCoroutine(LoadNextLevel());
            DoorAnimation.enabled=true;
        }
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

}
