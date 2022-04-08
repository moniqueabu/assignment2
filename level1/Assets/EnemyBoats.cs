using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoats : MonoBehaviour
{

    Transform player;
    Animator _animator;
    Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(SlimeMove());
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > transform.position.x && transform.localScale.x < 0 || player.position.x < transform.position.x && transform.localScale.x > 0)
        {
            transform.localScale *= new Vector2(-1, 1);
        }
        
        
    }

    IEnumerator SlimeMove()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 5f));
            _rigidbody.AddForce(new Vector2(transform.localScale.x * 100, 100));
        }
    }
}
