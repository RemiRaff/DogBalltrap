using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // pour DateTime

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private DateTime lastSpawnTime;
    private DateTime maxSpawnDelay;

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
            TimeSpan time = lastSpawnTime - DateTime.Now;
            Debug.Log(time.ToString());

            // si c pluq que le delay on spawn et met à jour le temps
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawnTime = DateTime.Now;

        }
    }
}
