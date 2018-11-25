using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDie : MonoBehaviour {

    public float zombieHP ;

    private float currentHP;

    private void Start()
    {
        zombieHP = PlaneData.ZombieHP;
        currentHP = zombieHP;
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) {
            Destroy(collision.gameObject);
            currentHP -= 50.0f;
            GetComponentInChildren<TextMesh>().text = currentHP.ToString();
            if(currentHP < 0.0f)
            {
                GameObject.FindGameObjectWithTag("HUDManager").GetComponent<HUDManager>().kill++;
                Destroy(this.gameObject);


            }
        }
    }


}
