using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
    public AudioSource weaponSound;
    public Transform flashPoint;
    public GameObject muzzleFlash;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(this.muzzleFlash, this.flashPoint.position, Quaternion.identity);

            //play sound
            this.weaponSound.Play();

        }
	}
}
