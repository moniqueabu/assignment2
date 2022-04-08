using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCode : MonoBehaviour
{
    // Start is called before the first frame update
    // scoreUI.text="Health: "+3?
    // public TextMeshProUGUI lifeUI;
    Rigidbody _rigidbody;
    bool isAlive = true;
    UnityEngine.AI.NavMeshAgent _navAgent;
    Camera mainCam;
    void Start()
    {
        // lifeUI.text="Life: "+PublicVars.life;
        _navAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        mainCam = Camera.main;
        // Cursor.lockState=CursorLockMode.Locked;
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void fixedupdate()
    {
        if (PublicVars.life <= 0)
        {
            PublicVars.life = 30;
            PublicVars.key = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200))
            {
                _navAgent.destination = hit.point;
            }
        }
        if (PublicVars.life <= 0)
        {
            PublicVars.life = 30;
            PublicVars.key = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    
}

