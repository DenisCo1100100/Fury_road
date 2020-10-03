using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Car")
        {
            GameOverController.Instance.gameObject.SetActive(true);
            Destroy(other);
        }
    }
}
