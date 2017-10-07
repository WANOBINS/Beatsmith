using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefix : MonoBehaviour
{


    /*
     * 0 = ATK
     * 1 = DEF
     * 2 = SPD
     * 3 = DEX
     */
    public Material[] Mats;

    public int[] Stats = new int[4] { 0, 0, 0, 0, };
    public string _prefix;
    public Vector3 OffSet;
    
}
