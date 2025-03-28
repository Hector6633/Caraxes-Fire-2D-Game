using UnityEngine;

public class rotate : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}
