using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffenCreator : MonoBehaviour
{
    public GameObject blue, green, yellow, red;

    public Transform blueSpawn, greenSpawn, yellowSpawn, redSpawn;

    private Vector3 offsetX = new Vector3(0, 1.1f, 0);
    private Vector3 offsetY = new Vector3(1.1f, 0, 0);

    GameObject[] winRed, winBlue, winYellow, winGreen;
    
     
    private void Start()
    {
        winRed = GameObject.FindGameObjectsWithTag("Red");
        winBlue = GameObject.FindGameObjectsWithTag("Blue");
        winYellow = GameObject.FindGameObjectsWithTag("Yellow");
        winGreen = GameObject.FindGameObjectsWithTag("Green");
    }
    void Update()
    {
        if (winRed.Length >= 4)
        {
            Debug.Log("Red Win");
        }
        if (winBlue.Length >= 4)
        {
            Debug.Log("Blue Win");
        }
        if (winYellow.Length >= 4)
        {
            Debug.Log("Yellow Win");
        }
        if (winGreen.Length >= 4)
        {
            Debug.Log("Green Win");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] colors = { blue, green, yellow, red };
            Transform[] spawns = { blueSpawn, greenSpawn, yellowSpawn, redSpawn };
            int randomIndex = Random.Range(0, colors.Length);
            Instantiate(colors[randomIndex], spawns[randomIndex].position, Quaternion.identity);
            if(colors[randomIndex] == blue || colors[randomIndex] == yellow) { spawns[randomIndex].position += offsetY; }
            else { spawns[randomIndex].position += offsetX; }
            
        }
    }
}


