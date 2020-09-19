using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    [SerializeField]private Vector3 moveVector;
    private float speead = 3;
    private float timeBeforeDestroy = 10;
    
    void Start()
    {
        Destroy(gameObject, timeBeforeDestroy);
    }

    void Update()
    {
        transform.Translate(moveVector * Time.deltaTime * speead, Space.World);
    }
}
