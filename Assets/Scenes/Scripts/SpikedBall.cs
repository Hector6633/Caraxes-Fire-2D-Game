using UnityEngine;

public class SpikedBall : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] private float damage;
    void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
