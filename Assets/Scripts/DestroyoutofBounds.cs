using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyoutofBounds : MonoBehaviour
{
    private float TopBoundary = 30f;
    private float LowerBoundary = -10f;

   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBoundary)
        {
            Destroy(gameObject);
        } else if (transform.position.z <LowerBoundary)
        {
            //Debug.Log("Game Over");
            Destroy(gameObject);
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
