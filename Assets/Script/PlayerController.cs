using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;

    public GameObject bulletPrefab;

    bool isShoot = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") != 0) {
            float vMove = Input.GetAxisRaw("Vertical");
            transform.Translate(
                0,
                vMove * moveSpeed * Time.deltaTime,
                0
            );
        }

        if (Input.GetAxisRaw("Horizontal") != 0) {
            float hMove = Input.GetAxisRaw("Horizontal");
            transform.Rotate(
                0,
                0,
                -hMove * rotateSpeed * Time.deltaTime
            );
        }

        if (Input.GetAxisRaw("Fire1") == 1) {
            if (isShoot == false) {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.transform.rotation = transform.rotation;
                isShoot = true;
            }
        }
        else if (Input.GetAxisRaw("Fire1") == 0) {
            if (isShoot == true) {
                isShoot = false;
            }
        }
	}
}
