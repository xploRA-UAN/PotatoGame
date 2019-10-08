using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour
{
    [SerializeField] private Transform m_target = null;
    [SerializeField] private float m_speed = 0.0f;
    [SerializeField] private float m_followRate = 0.0f;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            Quaternion desireRotation = Quaternion.LookRotation(m_target.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, desireRotation, m_followRate * Time.deltaTime);

            transform.Translate(Vector3.forward * Time.deltaTime * m_speed);
        }
    }
}
