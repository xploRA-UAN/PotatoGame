using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpPresionar : MonoBehaviour
{

    [SerializeField] private Transform m_target = null;
    [SerializeField] private float m_speed = 0.0f;
    [SerializeField] private float m_followRate = 0.0f;
    private int count = 0;
    public GameObject explosionEffect;

    Animation animar;

    // Use this for initialization
    void Start()
    {

        animar = this.gameObject.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            count = 1;
        }

        if (count == 1) {
            Disparo();
        }
    }

    private void Disparo()
    {

        Quaternion desireRotation = Quaternion.LookRotation(m_target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desireRotation, m_followRate * Time.deltaTime);

        transform.Translate(Vector3.forward * Time.deltaTime * m_speed);

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        /* if (hit.collider != null)
         {
             //Instantiate(explosionEffect, transform.position, transform.rotation);
             //transform.Rotate (0, 0, zSpeed);
             Explotar();
             //animar.Play ("animacion");

         }
     }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        Explotar();
    }

    private void Explotar()
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}