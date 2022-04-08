using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    public string levelToLoad = "level2";

    private void OnCollisionEnter(Collision other)
    {
        if (PublicVars.key > 0 && other.gameObject.CompareTag("Player"))
        {
            PublicVars.key--;
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
