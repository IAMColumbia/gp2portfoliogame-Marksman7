using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Watched OneWheelStudio becuase ify on undo/redo https://www.youtube.com/watch?v=LRZ1cuXiXTI
public class PeiceMovement : MonoBehaviour
{

    public bool FistPlayerStart = true;
    //muliplies to change neagitve to positve and vise versa
    float Changer = 1;
    //Zplane
    public float ZMovement = 1;
    //Xplane
    public float XMovement = 0;

    private float XMovementBeta = 0;

    private float ZMovementBeta = 0;

    private bool FlipMovementSyle = false;

    private bool StraghtMovementSyle = false;

    //public GameObject next;

    //public List<GameObject> Next;

    //public GameObject NextMovementPeice;

    public List<GameObject> FirstSetOfmovement = new List<GameObject>(4);

    //public List<GameObject> SecondSetOfmovement = new List<GameObject>(4);

    public List<Vector3> TrackingThingsToUndo;

    public int HowmanyBack = 1;

    private int HowmanyInlist = 0;

    float HorizontalMovement;

    float VeticalMovemnt;

    public void MovePeiceOnBoard()
    {
        this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
    }

    public void UpARoow()
    {
        //this.gameObject.transform.Translate(XMovement, 0, ZMovement);
        if (FlipMovementSyle == false)
        {
            HorizontalMovement = this.gameObject.transform.position.x + (XMovement * Changer);
            VeticalMovemnt = this.gameObject.transform.position.z + (ZMovement * Changer);
        }
        else
        {
            if (StraghtMovementSyle == true)
            {
                HorizontalMovement = this.gameObject.transform.position.x + (XMovementBeta * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z + (ZMovementBeta * Changer);
            }
            else
            {
                HorizontalMovement = this.gameObject.transform.position.x + (XMovement * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z - (ZMovement * Changer);
            }
        }
    }

    public void RightARoow()
    {
        //this.gameObject.transform.Translate(-ZMovement, 0, XMovement);
        if (FlipMovementSyle == false)
        {
            HorizontalMovement = this.gameObject.transform.position.x + (ZMovement * Changer);
            VeticalMovemnt = this.gameObject.transform.position.z - (XMovement * Changer);
        }
        else
        {
            if (StraghtMovementSyle == true)
            {
                HorizontalMovement = this.gameObject.transform.position.x + (ZMovementBeta * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z - (XMovementBeta * Changer);
            }
            else
            {
                HorizontalMovement = this.gameObject.transform.position.x + (ZMovement * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z + (XMovement * Changer);
            }
        }
    }

    public void LeftARoow()
    {
        //this.gameObject.transform.Translate(ZMovement, 0, -XMovement);
        if (FlipMovementSyle == false)
        {
            HorizontalMovement = this.gameObject.transform.position.x - (ZMovement * Changer);
            VeticalMovemnt = this.gameObject.transform.position.z + (XMovement * Changer);

        }
        else
        {
            if(StraghtMovementSyle == true)
            {
                HorizontalMovement = this.gameObject.transform.position.x - (ZMovementBeta * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z + (XMovementBeta * Changer);
            }
            else
            {
                HorizontalMovement = this.gameObject.transform.position.x - (ZMovement * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z - (XMovement * Changer);
            }

        }
    }

    public void DownARoow()
    {
        //this.gameObject.transform.Translate(-XMovement, 0, -ZMovement);
        if (FlipMovementSyle == false)
        {
            HorizontalMovement = this.gameObject.transform.position.x - (XMovement * Changer);
            VeticalMovemnt = this.gameObject.transform.position.z - (ZMovement * Changer);

        }
        else
        {
            if(StraghtMovementSyle == true)
            {
                HorizontalMovement = this.gameObject.transform.position.x - (XMovementBeta * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z - (ZMovementBeta * Changer);
            }
            else
            {
                HorizontalMovement = this.gameObject.transform.position.x - (XMovement * Changer);
                VeticalMovemnt = this.gameObject.transform.position.z + (ZMovement * Changer);
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {

        addMovement(this.gameObject.transform.position);
        
        if(FistPlayerStart == true)
        {
            Changer = 1;
        }
        else
        {
            Changer = -1;
        }

        if (ZMovement < 2 && ZMovement < 2)
        {
            StraghtMovementSyle = true;
            XMovementBeta = XMovement * 2;
            ZMovementBeta = ZMovement * 2;
        }
        else
        {
            XMovementBeta = XMovement;
            ZMovementBeta = ZMovement;
        }
        
        FirstSetOfmovement[0].transform.position = this.gameObject.transform.position + new Vector3((XMovement * Changer), 0, (ZMovement * Changer));
        FirstSetOfmovement[1].transform.position = this.gameObject.transform.position + new Vector3((-ZMovement * Changer), 0, (XMovement * Changer));
        FirstSetOfmovement[2].transform.position = this.gameObject.transform.position + new Vector3((ZMovement * Changer), 0, (-XMovement * Changer));
        FirstSetOfmovement[3].transform.position = this.gameObject.transform.position + new Vector3((-XMovement * Changer), 0, (-ZMovement * Changer));
        


        
    }


    //boundries
    public void Switchareas()
    {
        if (this.gameObject.transform.position.z > 12)
        {

            this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, (this.transform.position.z - 12));
        }
        else if (this.gameObject.transform.position.z < 1)
        {
            this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, (this.transform.position.z + 12));
        }
        else if (this.gameObject.transform.position.x > 12)
        {
            this.gameObject.transform.position = new Vector3((this.transform.position.x - 12), this.transform.position.y, this.transform.position.z);
        }
        else if (this.gameObject.transform.position.x < 1)
        {
            this.gameObject.transform.position = new Vector3((this.transform.position.x + 12), this.transform.position.y, this.transform.position.z);
        }
    }
    

    public void SwitchMovement()
    {
        if(FlipMovementSyle == true)
        {
            FlipMovementSyle = false;
                FirstSetOfmovement[0].transform.position = this.gameObject.transform.position + new Vector3((XMovement * Changer), 0, (ZMovement * Changer));
                FirstSetOfmovement[1].transform.position = this.gameObject.transform.position + new Vector3((-ZMovement * Changer), 0, (XMovement * Changer));
                FirstSetOfmovement[2].transform.position = this.gameObject.transform.position + new Vector3((ZMovement * Changer), 0, (-XMovement * Changer));
                FirstSetOfmovement[3].transform.position = this.gameObject.transform.position + new Vector3((-XMovement * Changer), 0, (-ZMovement * Changer));
            
        }
        else
        {
            FlipMovementSyle = true;
            if (StraghtMovementSyle == true)
            {
                //flip version so more options depending on the peice movement opions
                FirstSetOfmovement[0].transform.position = this.gameObject.transform.position + new Vector3((XMovementBeta * Changer), 0, (ZMovementBeta * Changer));
                FirstSetOfmovement[1].transform.position = this.gameObject.transform.position + new Vector3((-ZMovementBeta * Changer), 0, (XMovementBeta * Changer));
                FirstSetOfmovement[2].transform.position = this.gameObject.transform.position + new Vector3((ZMovementBeta * Changer), 0, (-XMovementBeta * Changer));
                FirstSetOfmovement[3].transform.position = this.gameObject.transform.position + new Vector3((-XMovementBeta * Changer), 0, (-ZMovementBeta * Changer));
            }
            else
            {
                FirstSetOfmovement[0].transform.position = this.gameObject.transform.position + new Vector3((XMovement * Changer), 0, (-ZMovement * Changer));
                FirstSetOfmovement[1].transform.position = this.gameObject.transform.position + new Vector3((-ZMovement * Changer), 0, (-XMovement * Changer));
                FirstSetOfmovement[2].transform.position = this.gameObject.transform.position + new Vector3((ZMovement * Changer), 0, (XMovement * Changer));
                FirstSetOfmovement[3].transform.position = this.gameObject.transform.position + new Vector3((-XMovement * Changer), 0, (ZMovement * Changer));
            }
        }
    }


    public void addMovement(Vector3 LastArea)
    {
        TrackingThingsToUndo.Add(LastArea);
        HowmanyInlist = HowmanyInlist + 1;
    }


    public void undoMovement()
    {
        if(HowmanyInlist >= HowmanyBack )
        {
            for (int i = 1; i < HowmanyBack; i++)
            {
                TrackingThingsToUndo.Remove(TrackingThingsToUndo[HowmanyInlist - 1]);
                HowmanyInlist = HowmanyInlist - 1;
            }

            this.gameObject.transform.position = TrackingThingsToUndo[HowmanyInlist - 1];

            VeticalMovemnt = TrackingThingsToUndo[HowmanyInlist - 1].z;

            HorizontalMovement = TrackingThingsToUndo[HowmanyInlist - 1].x;

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
