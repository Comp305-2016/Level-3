using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndContoller : MonoBehaviour {
    public GameController1 gamecontroller;

    private string _scene;
	// Use this for initialization
	void Start () {
        Scene _curScene = SceneManager.GetActiveScene();
        _scene = _curScene.name;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void CheckEnd()
    {
        if (this._scene == "Game")
        {
            //if (gamecontroller.KeyValue <= 0)
            //{
                SceneManager.LoadScene("InstructionL2Scene");
            //}
        }/* else if( this._scene== "GameL2") {
            if (gamecontroller.KeyValue <= 0 && gamecontroller.WeaponValue<=0)
            {
                SceneManager.LoadScene("InstructionL3Scene");
            }
        }
        }*/
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            
            CheckEnd();
            Debug.Log("end game");
            

        }
    }
}
