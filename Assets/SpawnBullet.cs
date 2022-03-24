using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bulletPrefab;
    public GameObject[] bullets;
    Stack<GameObject> Bulletstack = new Stack<GameObject>();




    public Vector3 offset;
    private static SpawnBullet instance;
    public static SpawnBullet Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<SpawnBullet>();
            }
            return instance;
        }
    }
    void Start()
    {
        createBullet();
      
    }

    private void createBullet()
    {
        for (int i = 0; i < 30; i++)
        {

            Bulletstack.Push(Instantiate(bulletPrefab));
            bulletPrefab.SetActive(false);
        }
    }

    public void Spawnbullet(int value)
    {
       
        GameObject temp = Bulletstack.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position + offset;

    }

    
    public void BackToPool(GameObject obj) // Here, the bullet gets again into the pool.
    {
        obj.SetActive(false);
        Bulletstack.Push(obj);

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Spawnbullet(10);
           // Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
        }
        
    }
  
}

