using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAndPlayer : MonoBehaviour
{

    public GameObject CamOne;

    public GameObject CamTwo;


    public GameObject objectSpaned;

    public GameObject objectBackward;

    public GameObject PeiceLook;

    public List<GameObject> PlayerOne;
    //visaly repestnatiaion of each peace
    public List<GameObject> PlayerOneTracker;
    //tracks position on 2d array
    public List<int> PlayerOnePeiceType;

    public List<GameObject> PlayerTwo;

    public List<GameObject> PlayerTwoTracker;

    public List<int> PlayerTwoPeiceType;
    //playone = =true and playertwo = false
    bool PlayerTurn = true; 

    //public List<List<int>> Board;

    //int[,] Board = new int[8,8] { { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 } };

    private int keeper = 0;

    private int keepers = 0;
    // Start is called before the first frame update
    void Start()
    {
        CamOne.SetActive(true);
        CamTwo.SetActive(false);
        SpawnBoard();
    }

    // Update is called once per frame
    void Update()
    {

        if(this.PlayerTurn == true)
        {
            SelectorPlayerOne();
        }
        else
        {
            SelectorPlayerTwo();
        }

       

        /*
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.R))
        {
            if (PlayerTurn == true)
            {
                PlayerTurn = false;
            }
            else if (PlayerTurn == false)
            {
                PlayerTurn = true;
            }
        }\*/
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerOne[keeper].SetActive(false);
            PlayerOne.Remove(PlayerOne[keeper]);
            PlayerOneTracker[keeper].SetActive(false);
            PlayerOneTracker.Remove(PlayerOneTracker[keeper]);
        }


        TrackingPalyerOne();
        TrackingPalyerTwo();
    }


    
        

    void TrackingPalyerOne()
    {
        PlayerOneTracker[keeper].transform.position = PlayerOne[keeper].transform.position;
    }

    void TrackingPalyerTwo()
    {
        PlayerTwoTracker[keepers].transform.position = PlayerTwo[keepers].transform.position;
    }

    void SelectorPlayerOne()
    {
        CamOne.SetActive(true);
        CamTwo.SetActive(false);
        if (PlayerOne == null)
        {
            Debug.LogWarning("TwoWin");
            //won event
        }
        else
        {

            PlayerTwo[keepers].SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerOne[keeper].SetActive(false);
                if (keeper <= 0)
                {
                    keeper = 3;//(PlayerOne.Count - 1);
                }
                else
                {
                    keeper = keeper - 1;
                }
                PlayerOne[keeper].SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerOne[keeper].SetActive(false);
                if (keeper >= 3)//(PlayerOne.Count + 1))
                {
                    keeper = 0;
                }
                else
                {
                    keeper = keeper + 1;
                }
                PlayerOne[keeper].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.R))
            {
                this.PlayerTurn = false;
                keepers = 0;
                PlayerTwo[keepers].SetActive(true);
            }
        }
    }
    

    void SelectorPlayerTwo()
    {
        CamTwo.SetActive(true);
        CamOne.SetActive(false);
        if (PlayerTwo == null)
        {
            Debug.LogWarning("OneWin");
            //won event
        }
        else
        {

            PlayerOne[keeper].SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerTwo[keepers].SetActive(false);
                if (keeper <= 0)
                {
                    keepers = 3;//(PlayerOne.Count - 1);
                }
                else
                {
                    keepers = keepers - 1;
                }
                PlayerTwo[keeper].SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerTwo[keepers].SetActive(false);
                if (keepers >= 3)//(PlayerOne.Count + 1))
                {
                    keepers = 0;
                }
                else
                {
                    keepers = keepers + 1;
                }
                PlayerTwo[keepers].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.R))
            {
                this.PlayerTurn = true;
                keeper = 0;
                PlayerOne[keeper].SetActive(true);
            }
        }
    }

    void SpawnBoard()
    {
        for (int i = 0; i < 4; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerOne.Add(Instantiate(objectSpaned, transform.TransformPoint(i, 0, 0), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLook, transform.TransformPoint(i, 0, 0), this.gameObject.transform.rotation));
            PlayerOnePeiceType.Add(10 + i);
            PlayerOne[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

           // Board[Mathf.CeilToInt(PlayerOneTracker[i].transform.position.x), Mathf.CeilToInt(PlayerOneTracker[i].transform.position.z)] = PlayerOnePeiceType[i];

            

        }
        PlayerOne[0].SetActive(true);

        for (int i = 0; i < 4; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerTwo.Add(Instantiate(objectBackward, transform.TransformPoint(i, 0, 8), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLook, transform.TransformPoint(i, 0, 8), this.gameObject.transform.rotation));
            PlayerTwoPeiceType.Add(10 + i);
            PlayerTwo[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

           // Board[Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.x), Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }
        //PlayerTwo[0].SetActive(true);
    }
}
