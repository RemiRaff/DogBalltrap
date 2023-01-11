using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // pour DateTime

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private DateTime lastSpawnTime;
    private TimeSpan minSpawnDelay = new TimeSpan(0, 0, 0, 0, 250);

    private void Start()
    {
        lastSpawnTime = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TimeSpan time = DateTime.Now - lastSpawnTime;
            // Debug.Log(time.ToString());

            // si c plus que le delay on spawn et met à jour le temps
            // Autre façon de faire coroutine WaitForSeconds
            if (minSpawnDelay < time)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastSpawnTime = DateTime.Now;
            }
        }
    }
}
