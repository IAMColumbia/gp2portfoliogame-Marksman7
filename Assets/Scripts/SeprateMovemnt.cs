using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeprateMovemnt : PeiceMovement
{
     void Update()
    {

        if (FistPlayerStart == true)
        {
            PlayeroneKeycodes();
        }
        else
        {
            PlayerTwoKeycodes();
        }

        
    }

    void PlayeroneKeycodes()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //addMovement(this.gameObject.transform.position);
            UpARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //addMovement(this.gameObject.transform.position);
            RightARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //addMovement(this.gameObject.transform.position);
            LeftARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //addMovement(this.gameObject.transform.position);
            DownARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            undoMovement();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchMovement();
        }
    }

    void PlayerTwoKeycodes()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //addMovement(this.gameObject.transform.position);
            UpARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //addMovement(this.gameObject.transform.position);
            RightARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //addMovement(this.gameObject.transform.position);
            LeftARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //addMovement(this.gameObject.transform.position);
            DownARoow();
            MovePeiceOnBoard();
            //this.transform.position = new Vector3(HorizontalMovement, this.gameObject.transform.position.y, VeticalMovemnt);
            Switchareas();

            addMovement(this.gameObject.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            undoMovement();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SwitchMovement();
        }
    }
}
