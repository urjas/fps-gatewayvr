using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 5f;
    public float lifetime = 1.5f;

    private float timer;
	// Use this for initialization
	void Start () {
        timer = lifetime;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;

        timer -= Time.deltaTime;
        if (timer <= 0f) {
            Destroy(this.gameObject);
        }
	}

  
}
