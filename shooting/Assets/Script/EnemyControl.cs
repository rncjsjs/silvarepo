using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    public float Speed = 8.0f;
	
	void Update () {

        float moveAmnt = Speed * Time.deltaTime;
        transform.Translate(Vector3.back * moveAmnt);

        if(transform.position.z < -7.0f)
        {
            InitPosition();
        }
    }

    void InitPosition()
    {
        transform.position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 50.0f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("bullet"))
        {
            Main.Score += 100;
            GetComponent<AudioSource>().Play();
            GetComponent<ParticleSystem>().Play();
            InitPosition();
        }
    }
}
