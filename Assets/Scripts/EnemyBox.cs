using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Car")
        {
            Debug.Log("You loos");
        }
    }
}
