using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Text timeText;
    [SerializeField] Transform spawnPoint;
    [SerializeField] private Text speedText;
    [SerializeField] private Text distanceText;
    [SerializeField] GameObject Cube;
    private float timeSpawn;
    private float time;
    public static float speed;
    public static float distance;

    void Update()
    {
        if (time > 0)
        {
            if (timeSpawn <= 0f)
            {
                Instantiate(Cube, spawnPoint.position, spawnPoint.rotation);
                timeSpawn = time;
            }
            else
            {
                timeSpawn -= Time.deltaTime;
            }
        }
    }
    public void buttonFire()
    {
        time = float.Parse(timeText.text);
        timeSpawn = time;
        speed = float.Parse(speedText.text);
        distance = float.Parse(distanceText.text);
        Instantiate(Cube, spawnPoint.position, spawnPoint.rotation);
    
    }
}
