using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Car")
        {
            Debug.Log("You loos");
        }
    }
}
