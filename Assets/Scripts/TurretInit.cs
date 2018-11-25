using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretInit : MonoBehaviour {

    private bool isTurretInit;
    public GameObject turretPrefab;
	// Use this for initialization
	void Start () {
        isTurretInit = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isTurretInit && Input.GetKeyDown(KeyCode.T))
        {
            isTurretInit = true;
            Instantiate(turretPrefab);
        }
    }
}
