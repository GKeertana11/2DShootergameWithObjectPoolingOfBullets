using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MomentOfPlayer(playerSpeed);
       
    


    }

    private void MomentOfPlayer(float speedOfPlayer)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x<=5.0f)
        {
            transform.Translate(speedOfPlayer, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x>=-5.0f)
        {
            transform.Translate(-speedOfPlayer, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<=3.9f)
        {
            transform.Translate(0, speedOfPlayer, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y>=-4.0f)
        {
            transform.Translate(0, -speedOfPlayer, 0);
        }

    }
}
