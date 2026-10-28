using UnityEngine;

public class Respawn : MonoBehaviour
    
{
    public GameObject empty;
    private void Update()
    {
        if (transform.position.y < -5f)
            transform.position = empty.transform.position;
    }

    

}
