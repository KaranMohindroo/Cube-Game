using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
