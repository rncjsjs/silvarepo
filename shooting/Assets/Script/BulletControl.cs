using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    public float Speed = 7.0f;
	
	
	void Update () {

        float moveAmnt = Time.deltaTime * Speed;
        transform.Translate(Vector3.forward * moveAmnt);

        if (transform.position.z > 35.0f)
            Destroy(gameObject);
        
	}

}
