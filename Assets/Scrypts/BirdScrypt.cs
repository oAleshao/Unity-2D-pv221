using UnityEngine;

public class BirdScrypt : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * 300);
        }
        this.transform.eulerAngles = new Vector3(0, 0, rb2d.linearVelocityY * 1.5f);
    }
}
