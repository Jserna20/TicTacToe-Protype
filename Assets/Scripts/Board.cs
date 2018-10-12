using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [Header("Set Dynamically")]
    public GameObject space;
    public GameObject space1;
    public GameObject space2;
    public GameObject space3;
    public GameObject space4;
    public GameObject space5;
    public GameObject space6;
    public GameObject space7;
    public GameObject space8;
    public Vector3 spacePos;
    public Vector3 space1Pos;
    public Vector3 space2Pos;
    public Vector3 space3Pos;
    public Vector3 space4Pos;
    public Vector3 space5Pos;
    public Vector3 space6Pos;
    public Vector3 space7Pos;
    public Vector3 space8Pos;
    
   


    void Awake()
    {
        Transform spaceTrans = transform.FindChild("space");
        space = spaceTrans.gameObject;
        space.SetActive(false);
        spacePos = spaceTrans.position;

        Transform space1Trans = transform.FindChild("space1");
        space1 = space1Trans.gameObject;
        space1.SetActive(false);
        space1Pos = space1Trans.position;

        Transform space2Trans = transform.FindChild("space2");
        space2 = space2Trans.gameObject;
        space2.SetActive(false);
        space2Pos = space2Trans.position;

        Transform space3Trans = transform.FindChild("space3");
        space3 = space3Trans.gameObject;
        space3.SetActive(false);
        space3Pos = space3Trans.position;

        Transform space4Trans = transform.FindChild("space4");
        space4 = space4Trans.gameObject;
        space4.SetActive(false);
        space4Pos = space4Trans.position;

        Transform space5Trans = transform.FindChild("space5");
        space5 = space5Trans.gameObject;
        space5.SetActive(false);
        space5Pos = space5Trans.position;

        Transform space6Trans = transform.FindChild("space6");
        space6 = space6Trans.gameObject;
        space6.SetActive(false);
        space6Pos = space6Trans.position;

        Transform space7Trans = transform.FindChild("space7");
        space7 = space7Trans.gameObject;
        space7.SetActive(false);
        space7Pos = space7Trans.position;

        Transform space8Trans = transform.FindChild("space8");
        space8 = space8Trans.gameObject;
        space8.SetActive(false);
        space8Pos = space8Trans.position;
    }

    void OnMouseEnter()
    {
        //Gives me an error if I try set more than 1 at a time
        print("mouse in");
        space.SetActive(true);
        space1.SetActive(true);
        space2.SetActive(true);
        space3.SetActive(true);
        space4.SetActive(true);
        space5.SetActive(true);
        space6.SetActive(true);
        space7.SetActive(true);
        space8.SetActive(true);
    }

    void OnMouseExit()
    {
        print("mouse out");
        space.SetActive(false);
        space1.SetActive(false);
        space2.SetActive(false);
        space3.SetActive(false);
        space4.SetActive(false);
        space5.SetActive(false);
        space6.SetActive(false);
        space7.SetActive(false);
        space8.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
   
    }
}
