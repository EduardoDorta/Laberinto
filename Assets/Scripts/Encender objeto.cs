using UnityEngine;

public class Encenderobjeto : MonoBehaviour
{
    public Material materialEncendido;
    bool encendido = false;
    float cronometro = 5f;
    public Material materialApagado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (encendido == true) {
            cronometro = cronometro - Time.deltaTime;
            if (cronometro < 0f) {
                encendido = false;
                GetComponent<MeshRenderer>().material = materialApagado;
                cronometro = 5f;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material = materialEncendido;
        encendido = true;
    }
}
