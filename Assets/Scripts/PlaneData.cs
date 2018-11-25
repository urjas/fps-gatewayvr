using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlaneData {
    private static float planeLength;
    private static float planeWidth;
    private static float zombieSpeed;
    private static float playerHP;
    private static float zombieHP;

    public static float PlaneLength
    {
        get { return planeLength; }
        set { planeLength = value; }
    }

    public static float PlaneWidth
    {
        get { return planeWidth; }
        set { planeWidth = value; }
    }
    public static float ZombieSpeed
    {
        get { return zombieSpeed; }
        set { zombieSpeed = value; }
    }
    public static float PlayerHP
    {
        get { return playerHP; }
        set { playerHP = value; }
    }
    public static float ZombieHP
    {
        get { return zombieHP; }
        set { zombieHP = value; }
    }
}
