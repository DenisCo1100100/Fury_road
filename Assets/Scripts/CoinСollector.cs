using UnityEngine;

public class CoinСollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Car")
        {
            GameState.AddCoin(1);
            Destroy(gameObject, 0.01f);
        }
    }
}
