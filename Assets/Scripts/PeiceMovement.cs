using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Watched OneWheelStudio becuase ify on undo/redo https://www.youtube.com/watch?v=LRZ1cuXiXTI
public class PeiceMovement : MonoBehaviour
{

    public float PeiceType = 00;
    //Zplane
    public float ZMovement = 1;
    //Xplane
    public float XMovement = 0;

    //public GameObject next;

    //public List<GameObject> Next;

    public GameObject NextUp;

    public GameObject NextLeft;

    public GameObject NextRight;

    public GameObject NextDown;

    public List<Vector3> TrackingThingsToUndo;

    public int HowmanyBack = 1;

    private int HowmanyInlist = 0;

    public void UpARoow()
    {
        this.gameObject.transform.Translate(XMovement, 0, ZMovement);
    }

    public void LeftARoow()
    {
        this.gameObject.transform.Translate(-ZMovement, 0, XMovement);
    }

    public void RightARoow()
    {
        this.gameObject.transform.Translate(ZMovement, 0, -XMovement);
    }

    public void DownARoow()
    {
        this.gameObject.transform.Translate(-XMovement, 0, -ZMovement);
    }
    
    // Start is called before the first frame update
    void Start()
    {

        addMovement(this.gameObject.transform.position);

        NextUp.transform.Translate(XMovement, 0, ZMovement);
        NextLeft.transform.Translate(-ZMovement, 0, XMovement);
        NextRight.transform.Translate(ZMovement, 0, -XMovement);
        NextDown.transform.Translate(-XMovement, 0, -ZMovement);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //addMovement(this.gameObject.transform.position);
            UpARoow();
            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //addMovement(this.gameObject.transform.position);
            RightARoow();
            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //addMovement(this.gameObject.transform.position);
            LeftARoow();
            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //addMovement(this.gameObject.transform.position);
            DownARoow();
            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            undoMovement();
        }
    }

    void addMovement(Vector3 LastArea)
    {
        TrackingThingsToUndo.Add(LastArea);
        HowmanyInlist = HowmanyInlist + 1;
    }


    void undoMovement()
    {
        if(HowmanyInlist >= HowmanyBack )
        {
            for (int i = 1; i < HowmanyBack; i++)
            {
                TrackingThingsToUndo.Remove(TrackingThingsToUndo[HowmanyInlist - 1]);
                HowmanyInlist = HowmanyInlist - 1;
            }

            this.gameObject.transform.position = TrackingThingsToUndo[HowmanyInlist - 1];
            
            HowmanyInlist = HowmanyInlist - 1;
        }
    }

}

//Not in use bacebetter way
/*
void NextAreas()
{
    NextUp.transform.TransformPoint(this.gameObject.transform.position.x + XMovement, 0, this.gameObject.transform.position.z + ZMovement);
    NextLeft.transform.TransformPoint(this.gameObject.transform.position.x - ZMovement, 0, this.gameObject.transform.position.z + XMovement);
    NextRight.transform.TransformPoint(this.gameObject.transform.position.x + ZMovement, 0, this.gameObject.transform.position.z - XMovement);
    NextDown.transform.TransformPoint(this.gameObject.transform.position.x - XMovement, 0, this.gameObject.transform.position.z - ZMovement);
}

void NextArea()
{
    NextUp.transform.TransformPoint(XMovement, 0, ZMovement);
    NextLeft.transform.TransformPoint(-ZMovement, 0, XMovement);
    NextRight.transform.TransformPoint(ZMovement, 0, -XMovement);
    NextDown.transform.TransformPoint(-XMovement, 0, -ZMovement);
}
*/
