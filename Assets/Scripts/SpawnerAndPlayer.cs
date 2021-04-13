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

            ExitWin.SetActive(true);
            //won event
        }
        else
        {

            PlayerTwoEliminator(keepers);
            PlayerTwo[keepers].SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerOne[keeper].SetActive(false);
                if (keeper <= 0)
                {
                    keeper = (PlayerOne.Count - 1);//(PlayerOne.Count - 1);
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
                if (keeper >= (PlayerOne.Count - 1))//(PlayerOne.Count + 1))
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
    
    void PlayerOneEliminator(int Choosen)
    {
        for (int i = 0; i < PlayerOnePeiceType.Count; i++)
        {
            if (PlayerOne[Choosen].transform.position == PlayerTwo[i].transform.position)
            {
                if (PlayerTwoPeiceType[i] == PlayerOnePeiceType[Choosen])
                {
                    PlayerOne[Choosen].SetActive(false);
                    PlayerOne.Remove(PlayerOne[Choosen]);
                    PlayerOneTracker[Choosen].SetActive(false);
                    PlayerOneTracker.Remove(PlayerOneTracker[Choosen]);
                    PlayerOnePeiceType.Remove(PlayerOnePeiceType[Choosen]);

                    PlayerTwo[i].SetActive(false);
                    PlayerTwo.Remove(PlayerTwo[i]);
                    PlayerTwoTracker[i].SetActive(false);
                    PlayerTwoTracker.Remove(PlayerTwoTracker[i]);
                    PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[i]);

                    i = 100;
                }
                else if (PlayerOnePeiceType[Choosen] == 1 && PlayerTwoPeiceType[i] == 2)
                {

                    PlayerTwo[i].SetActive(false);
                    PlayerTwo.Remove(PlayerTwo[i]);
                    PlayerTwoTracker[i].SetActive(false);
                    PlayerTwoTracker.Remove(PlayerTwoTracker[i]);
                    PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[i]);

                    i = 100;
                }
                else if (PlayerOnePeiceType[Choosen] == 2 && PlayerTwoPeiceType[i] == 3)
                {

                    PlayerTwo[i].SetActive(false);
                    PlayerTwo.Remove(PlayerTwo[i]);
                    PlayerTwoTracker[i].SetActive(false);
                    PlayerTwoTracker.Remove(PlayerTwoTracker[i]);
                    PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[i]);

                    i = 100;
                }
                else if (PlayerOnePeiceType[Choosen] == 3 && PlayerTwoPeiceType[i] == 1)
                {

                    PlayerTwo[i].SetActive(false);
                    PlayerTwo.Remove(PlayerTwo[i]);
                    PlayerTwoTracker[i].SetActive(false);
                    PlayerTwoTracker.Remove(PlayerTwoTracker[i]);
                    PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[i]);

                    i = 100;
                }
                else
                {
                    PlayerOne[Choosen].SetActive(false);
                    PlayerOne.Remove(PlayerOne[Choosen]);
                    PlayerOneTracker[Choosen].SetActive(false);
                    PlayerOneTracker.Remove(PlayerOneTracker[Choosen]);
                    PlayerOnePeiceType.Remove(PlayerOnePeiceType[Choosen]);

                    i = 100;
                }

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
            PlayerOneEliminator(keeper);
            PlayerOne[keeper].SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerTwo[keepers].SetActive(false);
                if (keepers <= 0)
                {
                    keepers = (PlayerTwo.Count - 1);//(PlayerOne.Count - 1);
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
                if (keepers >= (PlayerTwo.Count - 1))//(PlayerTwo.Count + 1))
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

    void PlayerTwoEliminator(int Chosens)
    {
        for (int i = 0; i < PlayerOnePeiceType.Count; i++)
        {
            if (PlayerTwo[Chosens].transform.position == PlayerOne[i].transform.position)
            {
                if (PlayerTwoPeiceType[i] == PlayerOnePeiceType[Chosens])
                {
                    PlayerOne[i].SetActive(false);
                    PlayerOne.Remove(PlayerOne[i]);
                    PlayerOneTracker[i].SetActive(false);
                    PlayerOneTracker.Remove(PlayerOneTracker[i]);
                    PlayerOnePeiceType.Remove(PlayerOnePeiceType[i]);

                    PlayerTwo[Chosens].SetActive(false);
                    PlayerTwo.Remove(PlayerTwo[Chosens]);
                    PlayerTwoTracker[Chosens].SetActive(false);
                    PlayerTwoTracker.Remove(PlayerTwoTracker[Chosens]);
                    PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[Chosens]);

                    i = 100;
                }
                else if (PlayerOnePeiceType[i] == 2 && PlayerTwoPeiceType[Chosens] == 1)
                {

                    PlayerOne[i].SetActive(false);
                    PlayerOne.Remove(PlayerOne[i]);
                    PlayerOneTracker[i].SetActive(false);
                    PlayerOneTracker.Remove(PlayerOneTracker[i]);
                    PlayerOnePeiceType.Remove(PlayerOnePeiceType[i]);

                    i = 100;
                }
                else if (PlayerOnePeiceType[i] == 3 && PlayerTwoPeiceType[Chosens] == 2)
                {

                    PlayerOne[i].SetActive(false);
                    PlayerOne.Remove(PlayerOne[i]);
                    PlayerOneTracker[i].SetActive(false);
                    PlayerOneTracker.Remove(PlayerOneTracker[i]);
                    PlayerOnePeiceType.Remove(PlayerOnePeiceType[i]);

                    i = 100;
                }
                else if (PlayerOnePeiceType[i] == 1 && PlayerTwoPeiceType[Chosens] == 3)
                {

                    PlayerOne[i].SetActive(false);
                    PlayerOne.Remove(PlayerOne[i]);
                    PlayerOneTracker[i].SetActive(false);
                    PlayerOneTracker.Remove(PlayerOneTracker[i]);
                    PlayerOnePeiceType.Remove(PlayerOnePeiceType[i]);

                    i = 100;
                }
                else
                {
                    PlayerTwo[Chosens].SetActive(false);
                    PlayerTwo.Remove(PlayerTwo[Chosens]);
                    PlayerTwoTracker[Chosens].SetActive(false);
                    PlayerTwoTracker.Remove(PlayerTwoTracker[Chosens]);
                    PlayerTwoPeiceType.Remove(PlayerTwoPeiceType[Chosens]);
                    i = 100;
                }

            }
        }
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
    }
}
