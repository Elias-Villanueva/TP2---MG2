using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    public float start;
    public float end;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x <= end)
        {
            if(gameObject.tag == "obstacle")
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector3 (start, transform.position.y, transform.position.z);
            }
            
        }
    }

    
}
