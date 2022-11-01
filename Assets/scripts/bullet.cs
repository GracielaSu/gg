using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject bulletEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        if (hitInfo.name != "Collider")
        {
            GameObject effect1 = Instantiate( bulletEffect, transform.position, transform.rotation);

            Destroy(gameObject);
            Destroy(effect1,0.35f);
        }
    }
        
}
