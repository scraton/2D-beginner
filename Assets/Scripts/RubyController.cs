using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private int direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + (0.1f * direction);
        
        if (position.x > 320) {
            direction = direction * -1;
        }
        
        transform.position = position;
    }
}
