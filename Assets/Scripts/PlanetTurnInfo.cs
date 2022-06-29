using UnityEngine;

public class PlanetTurnInfo : MonoBehaviour
{

    void Update()
    {

        if (Quaternion.Euler(0,180,0) == transform.rotation)//Every time the Euler angle is 180
        {

            Debug.Log($"{gameObject.name} bir tur dondu");
        }
        
    }

}
