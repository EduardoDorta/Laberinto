using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocidad = 0.03f;

    //AND -> &&
    //OR -> ||
    //NOT -> !
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
       
        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * velocidad;
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.left * velocidad;
        }
        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.forward * velocidad;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position += Vector3.back * velocidad;
        }
    }
}
