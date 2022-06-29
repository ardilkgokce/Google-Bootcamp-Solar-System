using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetDayTurn : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {

        transform.Rotate(Vector3.up * Time.deltaTime *-speed); // Planet rotates on its axis.
    }

}
