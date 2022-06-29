using UnityEngine;

public class TurnAroundOrbit : MonoBehaviour
{
    [SerializeField] GameObject pivotPoint;
    //[SerializeField] GameObject logEuler;
    [SerializeField] float turnSpeed;

    void Update()
    {
        transform.RotateAround(pivotPoint.transform.position, Vector3.down, turnSpeed * Time.deltaTime);

        //if (transform.localEulerAngles.y < 360 && transform.localEulerAngles.y > 358)
        //{
        //    transform.localEulerAngles = Vector3.zero;
        //    Debug.Log($"{gameObject.name} has made a lap around {pivotPoint.name}");
        //}
        ////Debug.Log("Log euler  " + logEuler.transform.localEulerAngles);






    }
}
