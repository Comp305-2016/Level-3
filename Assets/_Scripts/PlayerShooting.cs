using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
    public AudioSource weaponSound;
    public Transform flashPoint;
    public GameObject muzzleFlash;

    public GameObject BulletImpact;
    public GameObject Explosion;


    public Transform PlayerCam;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(this.muzzleFlash, this.flashPoint.position, Quaternion.identity);

            // need a variable to hold the location of our Raycast Hit
            RaycastHit hit;
            // if raycast hits an object then do something...
            if (Physics.Raycast(this.PlayerCam.position, this.PlayerCam.forward, out hit))
            {

                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    Instantiate(this.Explosion, hit.point, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    Instantiate(this.BulletImpact, hit.point, Quaternion.identity);
                }


            }

            //play sound
            this.weaponSound.Play();

        }
	}
}
