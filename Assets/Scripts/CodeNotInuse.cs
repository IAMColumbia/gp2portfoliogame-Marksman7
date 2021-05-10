using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeNotInuse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void PlayerTwoEliminator(int Chosens)
    {
        TrackingPalyerTwo();
        TrackingPalyerOne();

        for (int i = 0; i < PlayerOnePeiceType.Count; i++)
        {
            if (PlayerTwo[Chosens].transform.position == PlayerOne[i].transform.position)
            {
                if (PlayerTwoPeiceType[i] == PlayerOnePeiceType[Chosens])
                {
                    RemovePlayerOne(i);

                    RemovePlayerTwo(Chosens);
                    i = 100;
                }
                else if (PlayerOnePeiceType[i] == 2 && PlayerTwoPeiceType[Chosens] == 1)
                {
                    RemovePlayerOne(i);
                    i = 100;
                }
                else if (PlayerOnePeiceType[i] == 3 && PlayerTwoPeiceType[Chosens] == 2)
                {
                    RemovePlayerOne(i);
                    i = 100;
                }
                else if (PlayerOnePeiceType[i] == 1 && PlayerTwoPeiceType[Chosens] == 3)
                {
                    RemovePlayerOne(i);
                    i = 100;
                }
                else
                {
                    RemovePlayerTwo(Chosens);
                    i = 100;
                }

            }
        }
    }

    void PlayerOneEliminator(int Choosen)
    {
        TrackingPalyerTwo();
        TrackingPalyerOne();

        for (int i = 0; i < PlayerOnePeiceType.Count; i++)
        {
            if (PlayerOne[Choosen].transform.position == PlayerTwo[i].transform.position)
            {
                if (PlayerTwoPeiceType[i] == PlayerOnePeiceType[Choosen])
                {
                    RemovePlayerOne(Choosen);

                    RemovePlayerTwo(i);
                    i = 100;
                }
                else if (PlayerOnePeiceType[Choosen] == 1 && PlayerTwoPeiceType[i] == 2)
                {
                    RemovePlayerTwo(i);
                    i = 100;
                }
                else if (PlayerOnePeiceType[Choosen] == 2 && PlayerTwoPeiceType[i] == 3)
                {
                    RemovePlayerTwo(i);
                    i = 100;
                }
                else if (PlayerOnePeiceType[Choosen] == 3 && PlayerTwoPeiceType[i] == 1)
                {
                    
                    RemovePlayerTwo(i);
                    i = 100;
                }
                else
                {
                    RemovePlayerOne(Choosen);
                    i = 100;
                }

            }
        }
    }
    */
}
