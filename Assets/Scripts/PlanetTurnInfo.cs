using UnityEngine;

public class PlanetTurnInfo : MonoBehaviour
{

    void Update()
    {

        if (Quaternion.Euler(0,180,0) == transform.rotation)
        {

            Debug.Log($"{gameObject.name} bir tur dondu");
        }
        
    }

}
