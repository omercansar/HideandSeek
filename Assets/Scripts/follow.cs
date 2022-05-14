using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject Player;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float newXPosition = Player.transform.position.x - offset.x;
        float newYPosition = Player.transform.position.y - offset.y;
        float newZPosition = Player.transform.position.z - offset.z;
 
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }
}
