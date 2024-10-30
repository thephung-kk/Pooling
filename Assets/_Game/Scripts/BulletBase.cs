using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : GameUnit
{
    [SerializeField] float speed = 5;
    float damge;

    private void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    public void OnInit(float damge)
    {
        this.damge = damge;
    }

    public void OnDespawn()
    {
        //Destroy(gameObject);
        SimplePool.Despawn(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            //to do: set damge
            OnDespawn();
        }
    }
}
