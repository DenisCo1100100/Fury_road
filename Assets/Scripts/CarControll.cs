using UnityEngine;

public class CarControll : MonoBehaviour
{
    private Vector3 moveLeftVector = new Vector3(-1f, 0, 0);
    private Vector3 moveRightVector = new Vector3(1f, 0, 0);
    public Transform target;
    public float speed;

    void Update()
    {
        Vector3 movePositions = new Vector3(target.position.x, 0.1f, -3.83f);

        if (Input.GetKey(KeyCode.A))
        {
            if (target.transform.position.x > -2.8f)
                target.transform.Translate(moveLeftVector * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (target.transform.position.x < 2.8f)
                target.transform.Translate(moveRightVector * Time.deltaTime * speed);
        }

        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, movePositions, Time.deltaTime * (speed - 0.5f));
    }
}
