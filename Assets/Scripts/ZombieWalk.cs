using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalk : MonoBehaviour {

    public float speed ;
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = PlaneData.ZombieSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += transform.forward * speed * Time.deltaTime;
        transform.LookAt(player.transform);
        Vector3 rot = transform.eulerAngles;
        rot.x = 0.0f;
        transform.eulerAngles = rot;
    }
}
