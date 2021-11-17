using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BlockPref;
    public float StartTimeBtwStart;
    public float[] YSpawnPosition;

    private float _timeBtwStart = 0;

    void Update()
    {
        if (_timeBtwStart <= 0)
        {
            int rand = Random.Range(0, YSpawnPosition.Length);
            Instantiate(BlockPref, new Vector2(transform.position.x, YSpawnPosition[rand]), Quaternion.identity);
            _timeBtwStart = StartTimeBtwStart;
        }
        else
        {
            _timeBtwStart -= Time.deltaTime;
        }
    }
}