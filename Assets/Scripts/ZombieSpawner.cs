using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

    public float planeWidth;
    public float planeLength;
    public GameObject zombiePrefab;
    public void Start()
    {
        planeWidth = PlaneData.PlaneWidth;
        planeLength = PlaneData.PlaneLength;
        for (int i=0;i<(planeLength+planeWidth)/4;i++) {
            SpawnZombie();
        }
    }
    public void SpawnZombie() {
        Vector3 pos = new Vector3(Random.Range(-planeLength, planeLength), 0.0f, Random.Range(-planeWidth, planeWidth));
        GameObject zombie = Instantiate(zombiePrefab);
        zombie.transform.position = pos;
     
    }
}
