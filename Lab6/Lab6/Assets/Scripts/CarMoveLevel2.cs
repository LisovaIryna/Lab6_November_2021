using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CarMoveLevel2 : MonoBehaviour
{
    public float Health;
    public float speed;
    public float YIncrement;
    public float MinHeight, MaxHeight;
    public TMP_Text Text;

    private Vector2 _targetPos = Vector2.zero;

    private void Start()
    {
        Text.text = Health.ToString();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && _targetPos.y < MaxHeight)
        {
            _targetPos = new Vector2(_targetPos.x, _targetPos.y + YIncrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && _targetPos.y > MinHeight)
        {
            _targetPos = new Vector2(_targetPos.x, _targetPos.y - YIncrement);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            _targetPos = new Vector2(_targetPos.x + 2, _targetPos.y);
        }
    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        Text.text = Health.ToString();

        if (Health <= 0)
            SceneManager.LoadScene("LoseLevel2");
    }
}