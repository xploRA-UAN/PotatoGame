using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explotar : MonoBehaviour
{

    public GameObject explotarFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Explotar();
    }

    private void Explotar()
    {
        Instantiate(explotarFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
