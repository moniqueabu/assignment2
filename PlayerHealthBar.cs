using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealthBar : MonoBehaviour
{
    public TextMeshProUGUI lifeUI;
    public TextMeshProUGUI keyUI;
    public string leveltoload="SampleScene";
    // Start is called before the first frame update
    private void Start(){
           lifeUI.text="life: "+PublicVars.life;
           keyUI.text="key: "+PublicVars.key;
       }
    private void OnTriggerEnter(Collider other){
           if(other.CompareTag("Enemy")){
                      // _audioSource.PlayOneShot(woundSound);
                       PublicVars.life--;
                       lifeUI.text="life: "+PublicVars.life;
                   }
            if(other.CompareTag("Key")){
                       //_audioSource.PlayOneShot(coinSound);
                        Destroy(other.gameObject);
                        PublicVars.key++;
                        keyUI.text="key: "+PublicVars.key;
                    }
     }
}
