using UnityEngine;
using System.Collections;

public class s_enemyBulletPropeties : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Walls")
        {
            Destroy(gameObject);
        }
    }
}
