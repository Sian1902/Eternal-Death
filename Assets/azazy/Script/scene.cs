using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float wait = 37f;
    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(time());
    }
    IEnumerator time()
    {
        yield return new WaitForSeconds(wait);
        SceneManager.LoadScene(2);
    }
}
