using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int Damage;
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<CarMove>().ApplyDamage(Damage);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player2"))
        {
            collision.GetComponent<CarMoveLevel2>().ApplyDamage(Damage);
            Destroy(gameObject);
        }
    }
}