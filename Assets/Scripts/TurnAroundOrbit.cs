using UnityEngine;

public class TurnAroundOrbit : MonoBehaviour
{
    [SerializeField] GameObject pivotPoint;
    [SerializeField] float turnSpeed;

    void Update()
    {

        transform.RotateAround(pivotPoint.transform.position, Vector3.down, turnSpeed * Time.deltaTime); //Rotates around the referenced object.


    }
