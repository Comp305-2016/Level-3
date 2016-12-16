using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public AudioSource CoinSound;
    private WaitForSeconds waitTime = new WaitForSeconds(0.2f);

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void onTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) 
        {
            StartCoroutine(PlaySoundAndDestroy());
        //CoinSound.Play();
            }
    }
    IEnumerator PlaySoundAndDestroy()
    {
        CoinSound.Play();
        yield return this.waitTime;
        Destroy(this.gameObject);

    }

}
