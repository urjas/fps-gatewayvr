using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunReticle : MonoBehaviour {

    
    private void Start()
    {
       
    }
    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit,20.0f))
        {
            if (hit.collider.CompareTag("Zombie"))
            {
                this.GetComponent<Image>().color = Color.red;

            }
        }
        else {
            this.GetComponent<Image>().color = Color.white;

        }
    }
}
