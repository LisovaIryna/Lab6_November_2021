using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("FinishLevel1");
        }

        if (collision.CompareTag("Player2"))
        {
            SceneManager.LoadScene("FinishLevel2");
        }
    }
}