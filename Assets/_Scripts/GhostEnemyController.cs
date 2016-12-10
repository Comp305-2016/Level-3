using UnityEngine;
using System.Collections;

public class GhostEnemyController : MonoBehaviour {
    //PUBLIC INSTANCE VARIABLES
    public float Min;
    public float Max;

    public float speedx;
    public float speedy;
    public float speedz;

    public int directionSwitch;
    public GameController gamecontroller;

    public AudioSource hurtSound;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector3 _position;
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update () {
        // Get current position of the enemy
        this._position = this._transform.position;

        // Check the direction the enemy will be moving
        if (this.speedx != 0)
        {
            if (this._position.x >= this.Min)
            {
                this.directionSwitch = 0;
            }

            if (this._position.x <= this.Max)
            {
                this.directionSwitch = 1;
            }
        }

        if (this.speedy != 0)
        {
            if (this._position.y >= this.Min)
            {
                this.directionSwitch = 0;
            }

            if (this._position.y <= this.Max)
            {
                this.directionSwitch = 1;
            }
        }

        if (this.speedz != 0)
        {
            if (this._position.z >= this.Min)
            {
                this.directionSwitch = 0;
            }

            if (this._position.z <= this.Max)
            {
                this.directionSwitch = 1;
            }
        }

        // The enemy will switch directions when it reaches the min and max coordinates 
        if (this.directionSwitch == 0)
        {
            this._position -= new Vector3(this.speedx, this.speedy, this.speedz);
            this._transform.position = this._position;
        }
        if (this.directionSwitch == 1)
        {
            this._position += new Vector3(this.speedx, this.speedy, this.speedz);
            this._transform.position = this._position;
        }

    }
    ////Method opens gameover scene when player dies;
    //public void EndMenu()
    //{
    //    SceneManager.LoadScene("GameOverScene");
    //}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            this.gamecontroller.LivesValue -= 1;
            this.hurtSound.Play();
        }
    }
}
