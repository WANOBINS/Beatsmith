using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject MyPoint;
    public GameObject[] MovePoints;
    public int I;
	// Use this for initialization
	void Start ()
    {
        GameObject MyPoint = MovePoints[0];
        I = 0;
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            if(I != MovePoints.Length)
            {
                I++;
            }
            else
            {
                I = 0;
            }
            MyPoint = MovePoints[I];
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (I != 0)
            {
                I--;
            }
            else
            {
                I = MovePoints.Length;
            }
            MyPoint = MovePoints[I];
        }

        if (gameObject.transform.position != MyPoint.transform.position)
        {
            if (gameObject.transform.position.x <= (MyPoint.transform.position.x + 0.5f) && gameObject.transform.position.x >= (MyPoint.transform.position.x - 0.5f))
            {
                gameObject.transform.position = MyPoint.transform.position;
            }
            else               
            transform.position = Vector3.MoveTowards(transform.position, MyPoint.transform.position, Time.deltaTime * 16);
        }
            
        

    }
}
