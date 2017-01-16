using UnityEngine;
using System.Collections;

public class s_bulletProperties : MonoBehaviour {

    public float speed;
    public Rigidbody2D bullet;
    public Camera cam;

	// Use this for initialization
	void Start ()
    {
        bullet = bullet.GetComponent<Rigidbody2D>();
        moveBullet();
    }

    // Update is called once per frame
    void Update ()
    {
        
    }

    void moveBullet()
    {
        Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y);

        Vector2 direction = target - myPos;
        direction.Normalize();

        bullet.velocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Walls")
        {
            Destroy(gameObject);
        }
    }
}
