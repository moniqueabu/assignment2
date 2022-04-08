using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealthBar : MonoBehaviour
{
    public AudioClip keysound;
    public AudioClip woundsound;
    AudioSource _audiosource;
    public TextMeshProUGUI lifeUI;
    public TextMeshProUGUI keyUI;
    public string leveltoload = "level2";
    
    // Start is called before the first frame update
    private void Start()
    {
        lifeUI.text = "life: " + PublicVars.life;
        keyUI.text = "key: " + PublicVars.key;
        _audiosource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            _audiosource.PlayOneShot(woundsound);
            PublicVars.life--;
            lifeUI.text = "life: " + PublicVars.life;
        }
        if (other.CompareTag("key"))
        {
           // _audiosource.PlayOneShot(keysound);
            Destroy(other.gameObject);
            PublicVars.key++;
            keyUI.text = "key: " + PublicVars.key;
        }
    }
}
