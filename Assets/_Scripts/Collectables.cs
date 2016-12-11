using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Collectables : MonoBehaviour {
    //PUBLIC INSTANCE VARIABLES
    public GameController1 gamecontroller;

    [Header("Sound Clips")]
    public AudioSource CoinSound;
    //public AudioSource BottleSound;

    //PRIVATE INSTANCE VARIABLES
    private int score = 0;
    //private int treasure = 3;

    private int scorevalue;
    //private int treasurevalue;


    //pooling coins
 
    //public int CoinNumber;
    //public Transform SpawnPoint;





    // Use this for initialization


    // Update is called once per frame
    void Update () {

    }

    void Start()
    {
        //this.Player.transform.position = SpawnPoint.position; // spawn the player at the SpawnPoint



    }




private void OnTriggerEnter(Collider other)
    {
        //coin trigger increments score
        if (other.gameObject.CompareTag("Coin"))
        {
            //this.gamecontroller.ScoreValue += 100;
            Destroy(other.gameObject);
            this.CoinSound.Play();
        }
            //bottle pickup
            //    if (other.gameObject.CompareTag("Bottle"))
            //    {
            //        this.gamecontroller.TreasureValue -= 1;
            //        Destroy(other.gameObject);
            //        this.BottleSound.Play();
            //    }
        }
}
