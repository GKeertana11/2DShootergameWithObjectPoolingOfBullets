using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float time;
    float time1;
   

    public GameObject enemyPrefab;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      
        time = time + Time.deltaTime;
        float x = Random.Range(-6.0f, 6.0f);
        float y = Random.Range(0.0f, 4.0f);
        time = time + Time.deltaTime;
        if (time >= 3.0f)
        {

            Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
            time = 0;

        }

       
        
    }

   


}

