using UnityEngine;
using System.Collections;

public class s_enemyShoot : MonoBehaviour {

    public Rigidbody2D bullet;
    
    private float distance;

    private GameObject player;
    private float fireRate = 0.8f;

    private bool isCoroutineExecuting;

    private Vector2 playerPos;
    private Vector2 enemyPos;

    private s_gameSystem gameSystem;
    private GameObject gameSystemGameObject;



    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        gameSystemGameObject = GameObject.FindGameObjectWithTag("MainCamera");
        gameSystem = gameSystemGameObject.GetComponent<s_gameSystem>();

    }

    // Update is called once per frame
    void Update ()
    {
        playerPos = player.transform.position;
        enemyPos = transform.position;

        float distance = Vector2.Distance(playerPos, enemyPos);



        if (distance < 5f)
        {
            StartCoroutine(ExecuteAfterTime(fireRate));
        }
        

    }

    IEnumerator ExecuteAfterTime(float time)
    {

        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);

        shootBullet();


        isCoroutineExecuting = false;

    }


    void shootBullet()
    {
        //Debug.Log("Shoot");
        Instantiate(bullet, transform.position, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Works");
        if(col.tag == "playerBullet")
        {
            gameSystem.UpdateScore(100);
            gameSystem.kills += 1;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
