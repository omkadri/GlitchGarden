using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject DefenderType;

    private void OnMouseDown()
    {
        Debug.Log("Mouse was clicked");

        SpawnDefender(GetSquareClicked());
        //this passes the mouse vector data to the spawner
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // creates a vector containing the current mouse coordinates

        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos); 
        //this gets mouse coordinates relative the withing the game window (as opposed to raw mouse coordinate data)
        
        
        return worldPos;
    }

    private void SpawnDefender(Vector2 worldPos) //this function cannot run without getting the worldPos vector
    {
        GameObject newDefender = Instantiate(DefenderType, worldPos, Quaternion.identity) as GameObject;
        //"as gameObject" allows us to see the instance in the unity hierarchy, as well as interact with it
    }

}

