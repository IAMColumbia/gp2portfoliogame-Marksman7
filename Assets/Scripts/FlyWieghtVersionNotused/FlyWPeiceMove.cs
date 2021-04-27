using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class FlyWPeiceMove : MonoBehaviour
{
    public int PeiceType = 00;
    //Zplane
    public float ZMovement = 1;
    //Xplane
    public float XMovement = 0;


    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;

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
}
