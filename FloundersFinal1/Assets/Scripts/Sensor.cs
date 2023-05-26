using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        //Destroy(gameObject);
        if(!gameObject.CompareTag("Human"))
        {
            Debug.Log("I am calling game over");
            gameManager.GameOver();
            
        }
    }
}