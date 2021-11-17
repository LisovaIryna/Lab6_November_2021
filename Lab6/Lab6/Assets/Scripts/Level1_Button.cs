using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1_Button : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("level1");
    }
}