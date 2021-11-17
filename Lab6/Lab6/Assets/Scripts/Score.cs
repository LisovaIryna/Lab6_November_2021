using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text Text;
    private int _score;
    public float speed;
    private Vector2 _targetPos = Vector2.zero;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Block"))
        {
            _score++;
            Text.text = _score.ToString();
        }
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _targetPos = new Vector2(_targetPos.x + 2, _targetPos.y);
        }
    }
}