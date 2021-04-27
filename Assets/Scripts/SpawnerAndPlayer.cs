using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAndPlayer : MonoBehaviour
{

    public GameObject ExitWin;

    public GameObject CamOne;

    public GameObject CamTwo;


    public GameObject RedTeamPeice01;

    public GameObject RedTeamPeice02;

    public GameObject RedTeamPeice03;

    public GameObject BlueTeamPeice01;

    public GameObject BlueTeamPeice02;

    public GameObject BlueTeamPeice03;

    public GameObject PeiceLookRed01;

    public GameObject PeiceLookRed02;

    public GameObject PeiceLookRed03;

    public GameObject PeiceLookBlue01;

    public GameObject PeiceLookBlue02;

    public GameObject PeiceLookBlue03;

    //private int PlayerOneTrack = 12;

    //private int PlayerTwoTrack = 12;

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

        PlayerEliminatior();
        if (this.PlayerTurn == true)
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

        //testing to remove peace off game board
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerOne[keeper].SetActive(false);
            PlayerOne.Remove(PlayerOne[keeper]);
            PlayerOneTracker[keeper].SetActive(false);
            PlayerOneTracker.Remove(PlayerOneTracker[keeper]);
        }
        */



        //TrackingPalyerTwo();
        //TrackingPalyerOne();
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

            ExitWin.SetActive(true);
            //won event
        }
        else
        {
            
            PlayerTwo[keepers].SetActive(false);
            //PlayerTwoEliminator(keepers);
            //PlayerEliminatior();
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerOne[keeper].SetActive(false);
                if (keeper <= 0)
                {
                    keeper = (PlayerOneTracker.Count - 1);//(PlayerOne.Count - 1);
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
                if (keeper >= (PlayerOneTracker.Count - 1))//(PlayerOne.Count + 1))
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
            ExitWin.SetActive(true);
            //won event
        }
        else
        {
            PlayerOne[keeper].SetActive(false);
            //PlayerOneEliminator(keeper);
            //PlayerEliminatior();
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerTwo[keepers].SetActive(false);
                if (keepers <= 0)
                {
                    keepers = (PlayerTwoTracker.Count - 1);//(PlayerOne.Count - 1);
                }
                else
                {
                    keepers = keepers - 1;
                }
                PlayerTwo[keepers].SetActive(true);
                

            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerTwo[keepers].SetActive(false);
                if (keepers >= (PlayerTwoTracker.Count - 1))//(PlayerTwo.Count + 1))
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

    void PlayerEliminatior()
    {
        TrackingPalyerTwo();
        TrackingPalyerOne();

        for (int i = 0; i < PlayerOnePeiceType.Count; i++)
        {
            for (int k = 0; k < PlayerTwoPeiceType.Count; k++)
            {
                if (PlayerOne[i].transform.position == PlayerTwo[k].transform.position)
                {
                    if (PlayerTwo[k] == null || PlayerOne[i] == null)
                    {
                        Debug.Log("Null valuse find out");
                        i = 100;
                        k = 100;
                    }
                    else if (PlayerTwoPeiceType[k] == PlayerOnePeiceType[i])
                    {
                        RemovePlayerOne(i);

                        RemovePlayerTwo(k);
                        i = 100;
                        k = 100;
                    }
                    else if (PlayerOnePeiceType[k] == 2 && PlayerTwoPeiceType[k] == 1)
                    {
                        RemovePlayerOne(k);
                        i = 100;
                        k = 100;
                    }
                    else if (PlayerOnePeiceType[k] == 3 && PlayerTwoPeiceType[i] == 2)
                    {
                        RemovePlayerOne(k);
                        i = 100;
                        k = 100;
                    }
                    else if (PlayerOnePeiceType[k] == 1 && PlayerTwoPeiceType[i] == 3)
                    {
                        RemovePlayerOne(k);
                        i = 100;
                        k = 100;
                    }
                    else
                    {
                        RemovePlayerTwo(i);
                        i = 100;
                        k = 100;
                    }
                }
            }
        }
    }

    

    void RemovePlayerTwo(int i)
    {
        PlayerTwo[i].SetActive(false);
        PlayerTwo.Remove(PlayerTwo[i]);
        PlayerTwoTracker[i].SetActive(false);
        PlayerTwoTracker.Remove(PlayerTwoTracker[i]);
        PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[i]);
        //PlayerTwoTrack = PlayerTwoTrack - 1;
    }

    void RemovePlayerOne(int i)
    {
        PlayerOne[i].SetActive(false);
        PlayerOne.Remove(PlayerOne[i]);
        PlayerOneTracker[i].SetActive(false);
        PlayerOneTracker.Remove(PlayerOneTracker[i]);
        PlayerOnePeiceType.Remove(PlayerOnePeiceType[i]);
        //PlayerOneTrack = PlayerOneTrack - 1;
    }


    void SpawnBoard()
    {
        for (int i = 0; i < 4; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerOne.Add(Instantiate(RedTeamPeice01, transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLookRed01, transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOnePeiceType.Add(1);
            PlayerOne[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x
            // Board[Mathf.CeilToInt(PlayerOneTracker[i].transform.position.x), Mathf.CeilToInt(PlayerOneTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }
        PlayerOne[0].SetActive(true);

        for (int i = 4; i < 8; i++)
        {
            int minusing = 0;

            if (i == 4 || i == 7)
            {
                minusing = 1;
            }
            PlayerOne.Add(Instantiate(RedTeamPeice02, transform.TransformPoint(i, 0, (3 - minusing)), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLookRed02, transform.TransformPoint(i, 0, (3 - minusing)), this.gameObject.transform.rotation));
            PlayerOnePeiceType.Add(2);
            PlayerOne[i].SetActive(false);
            



        }

        for (int i = 8; i < 12; i++)
        {
            

            PlayerOne.Add(Instantiate(RedTeamPeice03, transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLookRed03, transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOnePeiceType.Add(3);
            PlayerOne[i].SetActive(false);
            // Board[Mathf.CeilToInt(PlayerOneTracker[i].transform.position.x), Mathf.CeilToInt(PlayerOneTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }

        for (int i = 0; i < 4; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerTwo.Add(Instantiate(BlueTeamPeice01, transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLookBlue01, transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoPeiceType.Add(1);
            PlayerTwo[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

           // Board[Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.x), Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }
        //PlayerTwo[0].SetActive(true);

        for (int i = 4; i < 8; i++)
        {

            int Adding = 0;

            if (i == 4 || i == 7)
            {
                Adding = 1;
            }
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerTwo.Add(Instantiate(BlueTeamPeice02, transform.TransformPoint(i, 0, (8 + Adding)), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLookBlue02, transform.TransformPoint(i, 0, (8 + Adding)), this.gameObject.transform.rotation));
            PlayerTwoPeiceType.Add(2);
            PlayerTwo[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

            // Board[Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.x), Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }

        for (int i = 8; i < 12; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerTwo.Add(Instantiate(BlueTeamPeice03, transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLookBlue03, transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoPeiceType.Add(3);
            PlayerTwo[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

            // Board[Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.x), Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }

        //PlayerOneTrack = PlayerOne.Count;

        //PlayerTwoTrack = PlayerTwo.Count;

    }



    
}

