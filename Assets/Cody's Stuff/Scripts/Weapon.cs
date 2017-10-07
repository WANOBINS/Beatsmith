using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Prefix {

    /*
    * 0 = ATK
    * 1 = DEF
    * 2 = SPD
    * 3 = DEX
    */

    
    public int type_id = -1; 
    public Prefix[] P_List = new Prefix[8];
    public Prefix MyPrefix;
    public Handle[] H_List;
    public Handle MyHandle;
    public MidSection[] M_List;
    public MidSection MyMidSection;
    public GameObject[] Sword_List;
    public GameObject[] Dagger_List;
    public GameObject[] GW_List;
    public bool WholeWeaponSpawn = true;
    public bool SongFinished;
    public float GoldValue;
    
    public GameObject MyBlade;
    

    public int[] Total_Stats;
    public string Name = "";

    // Use this for initialization
	void Start ()
    {
            
            

        Sword_List = GameObject.FindGameObjectsWithTag("Sword");
        GW_List = GameObject.FindGameObjectsWithTag("GWeapon");
        Dagger_List = GameObject.FindGameObjectsWithTag("Dagger");

        InitiliazeLists();
        if(WholeWeaponSpawn == true)
            GenerateWholeWeapon();
        
        else
        {
            
            SpawnWeapon();
            
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (SongFinished == true)
        {
            GenerateHandle();
            SongFinished = false;
        }

    }


    void RandomizeType()
    {
        type_id = Random.Range(0, 2);
    }

    void InitiliazeLists()
    {
        //PREFIXES

        for (int i = 0; i < 8; i++)
        {

            P_List[i] = new Prefix();
        }

        
        P_List[0]._prefix = "Sturdy";
        P_List[0].Stats[0] = 0;
        P_List[0].Stats[1] = 2;
        P_List[0].Stats[2] = 0;
        P_List[0].Stats[3] = 0;
        //
        
        P_List[1]._prefix = "Quick";
        P_List[1].Stats[0] = 0;
        P_List[1].Stats[1] = 0;
        P_List[1].Stats[2] = 2;
        P_List[1].Stats[3] = 0;
        //
        P_List[2]._prefix = "Sharp";
        P_List[2].Stats[0] = 2;
        P_List[2].Stats[1] = 0;
        P_List[2].Stats[2] = 0;
        P_List[2].Stats[3] = 0;
        //
        P_List[3]._prefix = "Agile";
        P_List[3].Stats[0] = 0;
        P_List[3].Stats[1] = 0;
        P_List[3].Stats[2] = 0;
        P_List[3].Stats[3] = 2;
        //
        P_List[4]._prefix = "Hasty";
        P_List[4].Stats[0] = 0;
        P_List[4].Stats[1] = -2;
        P_List[4].Stats[2] = 1;
        P_List[4].Stats[3] = 3;
        //
        P_List[5]._prefix = "Heavy";
        P_List[5].Stats[0] = 2;
        P_List[5].Stats[1] = 3;
        P_List[5].Stats[2] = -1;
        P_List[5].Stats[3] = -2;
        //
        P_List[6]._prefix = "Frenzied";
        P_List[6].Stats[0] = 2;
        P_List[6].Stats[1] = -3;
        P_List[6].Stats[2] = 0;
        P_List[6].Stats[3] = 2;
        //
        P_List[7]._prefix = "Cowardly";
        P_List[7].Stats[0] = -2;
        P_List[7].Stats[1] = 0;
        P_List[7].Stats[2] = 5;
        P_List[7].Stats[3] = 0;

        ////////////////////////////////////////////////////////////
    }

    void GenerateWholeWeapon()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        type_id = Random.Range(0, 3);
        MyPrefix = P_List[Random.Range(0, P_List.Length)];
        MyHandle = H_List[Random.Range(0, H_List.Length)];
        MyMidSection = M_List[Random.Range(0, M_List.Length)];
        

        Instantiate(MyHandle, (gameObject.transform.position + MyHandle.OffSet) , Quaternion.identity, gameObject.transform);
        Instantiate(MyMidSection, (gameObject.transform.position + MyMidSection.OffSet), Quaternion.identity, gameObject.transform);
        GenerateBlade();

        
/*
        Debug.Log(MyPrefix._prefix + " " + MyMurderPart._prefix);
        Debug.Log("ATK " + Total_Stats[0]);
        Debug.Log("DEF " + Total_Stats[1]);
        Debug.Log("SPD " + Total_Stats[2]);
        Debug.Log("DEX " + Total_Stats[3]);
*/
    }



    public void MainMenu()
    {
        GenerateWholeWeapon();

    }

    public void GenerateHandle()
    {
        MyPrefix = P_List[Random.Range(0, P_List.Length)];
        MyHandle = H_List[Random.Range(0, H_List.Length)];
        MyMidSection = M_List[Random.Range(0, M_List.Length)];


    }

    void GenerateBlade()
    {
        if (type_id == -1)
            type_id = Random.Range(0, 3);
        if (type_id == 1)
            MyBlade = Sword_List[Random.Range(0, Sword_List.Length)];
        if (type_id == 0)
            MyBlade = Dagger_List[Random.Range(0, Dagger_List.Length)];
        if (type_id == 2)
            MyBlade = GW_List[Random.Range(0, GW_List.Length)];
        



        Instantiate(MyBlade, gameObject.transform.position, Quaternion.identity, gameObject.transform);
    }

    public void SpawnWeapon()
    {
        Instantiate(MyHandle, (gameObject.transform.position + MyHandle.OffSet), Quaternion.identity, gameObject.transform);
        Instantiate(MyMidSection, (gameObject.transform.position + MyMidSection.OffSet), Quaternion.identity, gameObject.transform);
        Instantiate(MyBlade, gameObject.transform.position, Quaternion.identity, gameObject.transform);
    }
}
