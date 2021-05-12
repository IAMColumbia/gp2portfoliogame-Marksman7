using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
    public GameObject ExitWin;

    //public GameObject CamOne;

    //public GameObject CamTwo;



    public List<GameObject> RedTeamPeice;

    public List<GameObject> BlueTeamPeice;

    public List<GameObject> PeiceLookRed;

    public List<GameObject> PeiceLookBlue;


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

    private int PeiceHandler = 0;

    private int NextTurnHandler = 0;

    //private int PLayOnePeiceHandler = 0;

    //private int PlayTwoPeiceHandler = 0;
    // Start is called before the first frame update
    void Start()
    {
        //CamOne.SetActive(true);
        //CamTwo.SetActive(false);
        SpawnBoard();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerEliminatior();
        if (this.PlayerTurn == true)
        {
            //SelectorPlayerOne();
            Selector(PlayerOne, PlayerTwo);
        }
        else
        {

            //SelectorPlayerTwo();
            Selector(PlayerTwo, PlayerOne);
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




    /*
    void TrackingPalyerOne()
    {
        if (PlayerOne.Count <= 0)
        {
            Debug.LogWarning("TwoWin");

            ExitWin.SetActive(true);
        }
        else
        {
            PlayerOneTracker[NextTurnHandler].transform.position = PlayerOne[NextTurnHandler].transform.position;

        }
    }

    void TrackingPalyerTwo()
    {
        if (PlayerTwo.Count <= 0)
        {
            Debug.LogWarning("TwoWin");

            ExitWin.SetActive(true);
        }
        else
        {
            PlayerTwoTracker[NextTurnHandler].transform.position = PlayerTwo[NextTurnHandler].transform.position;

        }
    }
    */
    void TrackingPalyer(List<GameObject> Player, List<GameObject> Tracker)
    {
        if (Player.Count <= 0)
        {
            Debug.LogWarning("TwoWin");

            ExitWin.SetActive(true);
        }
        else
        {
            if (Player.Count >= (NextTurnHandler + 1))
            {
                Tracker[NextTurnHandler].transform.position = Player[NextTurnHandler].transform.position;
            }

        }
    }

    void Selector(List<GameObject> Player, List<GameObject> OtherPlayer)
    {
        

        
        //CamOne.SetActive(true);
        //CamTwo.SetActive(false);
        if (Player.Count <= 0)
        {
            Debug.LogWarning("TwoWin");

            ExitWin.SetActive(true);
            //won event
        }
        else
        {
            if((NextTurnHandler + 1) <= OtherPlayer.Count)
            {
                OtherPlayer[NextTurnHandler].SetActive(false);

            }
            //PlayerTwoEliminator(keepers);
            //PlayerEliminatior();
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player[PeiceHandler].SetActive(false);
                if (PeiceHandler <= 0)
                {
                    PeiceHandler = (Player.Count - 1);//(PlayerOne.Count - 1);
                }
                else
                {
                    PeiceHandler = PeiceHandler - 1;
                }
                Player[PeiceHandler].SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                Player[PeiceHandler].SetActive(false);
                if (PeiceHandler >= (Player.Count - 1))//(PlayerOne.Count + 1))
                {
                    PeiceHandler = 0;
                }
                else
                {
                    PeiceHandler = PeiceHandler + 1;
                }
                Player[PeiceHandler].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.R))
            {

                if (this.PlayerTurn == true)
                {
                this.PlayerTurn = false;
                }
                else
                {
                    this.PlayerTurn = true;
                }
                NextTurnHandler = PeiceHandler;
                PeiceHandler = 0;
                OtherPlayer[PeiceHandler].SetActive(true);

            }
        }
    }

    /*
    void SelectorPlayerOne()
    {

        //CamOne.SetActive(true);
        //CamTwo.SetActive(false);
        if (PlayerOne.Count <= 0)
        {
            Debug.LogWarning("TwoWin");

            ExitWin.SetActive(true);
            //won event
        }
        else
        {

            PlayerTwo[PlayTwoPeiceHandler].SetActive(false);
            //PlayerTwoEliminator(keepers);
            //PlayerEliminatior();
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerOne[PLayOnePeiceHandler].SetActive(false);
                if (PLayOnePeiceHandler <= 0)
                {
                    PLayOnePeiceHandler = (PlayerOneTracker.Count - 1);//(PlayerOne.Count - 1);
                }
                else
                {
                    PLayOnePeiceHandler = PLayOnePeiceHandler - 1;
                }
                PlayerOne[PLayOnePeiceHandler].SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerOne[PLayOnePeiceHandler].SetActive(false);
                if (PLayOnePeiceHandler >= (PlayerOneTracker.Count - 1))//(PlayerOne.Count + 1))
                {
                    PLayOnePeiceHandler = 0;
                }
                else
                {
                    PLayOnePeiceHandler = PLayOnePeiceHandler + 1;
                }
                PlayerOne[PLayOnePeiceHandler].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.R))
            {


                this.PlayerTurn = false;
                PlayTwoPeiceHandler = 0;
                PlayerTwo[PlayTwoPeiceHandler].SetActive(true);

            }
        }
    }



    void SelectorPlayerTwo()
    {

        //CamTwo.SetActive(true);
        //CamOne.SetActive(false);
        if (PlayerTwo.Count <= 0)
        {
            Debug.LogWarning("OneWin");
            ExitWin.SetActive(true);
            //won event
        }
        else
        {
            PlayerOne[PLayOnePeiceHandler].SetActive(false);
            //PlayerOneEliminator(keeper);
            //PlayerEliminatior();
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerTwo[PlayTwoPeiceHandler].SetActive(false);
                if (PlayTwoPeiceHandler <= 0)
                {
                    PlayTwoPeiceHandler = (PlayerTwoTracker.Count - 1);//(PlayerOne.Count - 1);
                }
                else
                {
                    PlayTwoPeiceHandler = PlayTwoPeiceHandler - 1;
                }
                PlayerTwo[PlayTwoPeiceHandler].SetActive(true);


            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerTwo[PlayTwoPeiceHandler].SetActive(false);
                if (PlayTwoPeiceHandler >= (PlayerTwoTracker.Count - 1))//(PlayerTwo.Count + 1))
                {
                    PlayTwoPeiceHandler = 0;
                }
                else
                {
                    PlayTwoPeiceHandler = PlayTwoPeiceHandler + 1;
                }
                PlayerTwo[PlayTwoPeiceHandler].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.R))
            {

                this.PlayerTurn = true;
                PLayOnePeiceHandler = 0;
                PlayerOne[PLayOnePeiceHandler].SetActive(true);


            }
        }
    }
    */
    void PlayerEliminatior()
    {
        //TrackingPalyerTwo();
        //TrackingPalyerOne();

        TrackingPalyer(PlayerOne, PlayerOneTracker);
        TrackingPalyer(PlayerTwo, PlayerTwoTracker);

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
                    else if (PlayerOnePeiceType[i] == 2 && PlayerTwoPeiceType[k] == 1)
                    {
                        RemovePlayerOne(i);
                        i = 100;
                        k = 100;
                    }
                    else if (PlayerOnePeiceType[i] == 3 && PlayerTwoPeiceType[k] == 2)
                    {
                        RemovePlayerOne(i);
                        i = 100;
                        k = 100;
                    }
                    else if (PlayerOnePeiceType[i] == 1 && PlayerTwoPeiceType[k] == 3)
                    {
                        RemovePlayerOne(i);
                        i = 100;
                        k = 100;
                    }
                    else
                    {
                        RemovePlayerTwo(k);
                        i = 100;
                        k = 100;
                    }
                }
            }

        }


        SameElimatior(PlayerOne, PlayerOnePeiceType, true);
        SameElimatior(PlayerTwo, PlayerTwoPeiceType, false);

    }


    void SameElimatior(List<GameObject> Peiceses, List<int> Numbervalue, bool WhichPlayer)
    {
        for (int i = 0; i < Peiceses.Count; i++)
        {
            for (int k = 0; k < Peiceses.Count; k++)
            {

                if (Peiceses[i].transform.position == Peiceses[k].transform.position)
                {
                    
                    if (Peiceses[i] == null || Peiceses[k] == null)
                    {
                        Debug.Log("Null valuse find out");
                        i = 100;
                        k = 100;
                    }
                    else if(k == i)
                    {
                        //Nope
                    }
                    else if (Numbervalue[i] == 2 && Numbervalue[k] == 1)
                    {
                        if(WhichPlayer == true)
                        {
                            RemovePlayerOne(i);
                        }
                        else
                        {
                            RemovePlayerTwo(i);
                        }
                        i = 100;
                        k = 100;
                    }
                    else if (Numbervalue[i] == 3 && Numbervalue[k] == 2)
                    {
                        if (WhichPlayer == true)
                        {
                            RemovePlayerOne(i);
                        }
                        else
                        {
                            RemovePlayerTwo(i);
                        }
                        i = 100;
                        k = 100;
                    }
                    else if (Numbervalue[i] == 1 && Numbervalue[k] == 3)
                    {
                        if (WhichPlayer == true)
                        {
                            RemovePlayerOne(i);
                        }
                        else
                        {
                            RemovePlayerTwo(i);
                        }
                        i = 100;
                        k = 100;
                    }
                    else if (Numbervalue[i] == Numbervalue[k])
                    {
                        if (WhichPlayer == true)
                        {
                            RemovePlayerOne(k);
                            RemovePlayerOne(i);
                        }
                        else
                        {
                            RemovePlayerTwo(k);
                            RemovePlayerTwo(i);
                        }
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

            PlayerOne.Add(Instantiate(RedTeamPeice[0], transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLookRed[0], transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
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
            PlayerOne.Add(Instantiate(RedTeamPeice[1], transform.TransformPoint(i, 0, (3 - minusing)), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLookRed[1], transform.TransformPoint(i, 0, (3 - minusing)), this.gameObject.transform.rotation));
            PlayerOnePeiceType.Add(2);
            PlayerOne[i].SetActive(false);




        }

        for (int i = 8; i < 12; i++)
        {


            PlayerOne.Add(Instantiate(RedTeamPeice[2], transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOneTracker.Add(Instantiate(PeiceLookRed[2], transform.TransformPoint(i, 0, 2), this.gameObject.transform.rotation));
            PlayerOnePeiceType.Add(3);
            PlayerOne[i].SetActive(false);
            // Board[Mathf.CeilToInt(PlayerOneTracker[i].transform.position.x), Mathf.CeilToInt(PlayerOneTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }

        for (int i = 0; i < 4; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerTwo.Add(Instantiate(BlueTeamPeice[0], transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLookBlue[0], transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
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

            PlayerTwo.Add(Instantiate(BlueTeamPeice[1], transform.TransformPoint(i, 0, (8 + Adding)), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLookBlue[1], transform.TransformPoint(i, 0, (8 + Adding)), this.gameObject.transform.rotation));
            PlayerTwoPeiceType.Add(2);
            PlayerTwo[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

            // Board[Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.x), Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }

        for (int i = 8; i < 12; i++)
        {
            //GameObject here = Instantiate(objectSpaned, new Vector3((this.gameObject.transform.position.x + 1), this.gameObject.transform.position.y , (this.gameObject.transform.position.z + 1));

            PlayerTwo.Add(Instantiate(BlueTeamPeice[2], transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoTracker.Add(Instantiate(PeiceLookBlue[2], transform.TransformPoint(i, 0, 9), this.gameObject.transform.rotation));
            PlayerTwoPeiceType.Add(3);
            PlayerTwo[i].SetActive(false);
            // PlayerOneTracker[i].transform.position.x

            // Board[Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.x), Mathf.CeilToInt(PlayerTwoTracker[i].transform.position.z)] = PlayerOnePeiceType[i];



        }

        //PlayerOneTrack = PlayerOne.Count;

        //PlayerTwoTrack = PlayerTwo.Count;

    }




}
