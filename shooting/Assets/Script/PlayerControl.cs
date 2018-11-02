using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float Speed = 0.10f;
    public GameObject bullet;
        
	void Update () {

        float moveAmnt = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float moveAmnt2 = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        Vector3 moveVector = Vector3.right * moveAmnt + Vector3.up * moveAmnt2;
        transform.Translate(moveVector);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
