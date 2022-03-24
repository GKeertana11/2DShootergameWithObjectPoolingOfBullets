using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMoment : MonoBehaviour
{
    public float bulletspeed;
    public int Score;
    ScoreManager score;
    SpawnBullet SpawnBullet;

   



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletspeed, 0);
      
    }
   private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (Enemy.tag == "MyEnemy")
        {
            
            Destroy(Enemy.gameObject);
            score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            score.ScoreCalculator(10);
            SpawnBullet.BackToPool(gameObject);

        }

    }


  
}
