using UnityEngine;
using System.Collections.Generic;

public class Objects : MonoBehaviour
{
    [SerializeField]
    private List<Rigidbody> m_rigidBodies;
	
    void Update()
    {
        foreach (Rigidbody body in m_rigidBodies)
        {
            for (int i = 0; i < m_rigidBodies.Count; i++)
            {
                if (m_rigidBodies[i] != body)
                {
                    Gravitate(m_rigidBodies[i], body);
                }
            }
        }
    }


    private void Gravitate(Rigidbody subject, Rigidbody source)
    {
        
        Vector3 gravity = new Vector3();
        float gravityOverDistance = source.mass / Vector3.SqrMagnitude(source.position - subject.position);
        gravity += (source.position - subject.position).normalized * gravityOverDistance;

        subject.AddForce(gravity, ForceMode.Acceleration);        
    }
}

