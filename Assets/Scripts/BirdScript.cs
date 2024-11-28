using System.Linq;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public static int score;

    [SerializeField]
    private GameObject content;
    private Rigidbody2D rb2d;
    private Collider2D[] colliders;

    void Start()
    {
        score = 0;
        rb2d = this.GetComponent<Rigidbody2D>();
        colliders = this.GetComponents<Collider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * 300);
        }
        this.transform.eulerAngles = new Vector3(0, 0, rb2d.linearVelocityY * 1.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            content.SetActive(true);
            Time.timeScale = content.activeInHierarchy ? 0.0f : 1.0f;
            ModalScript.isPause = false;
            content.transform.Find("Pause").gameObject.SetActive(false);
            content.transform.Find("GameOver").gameObject.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe" && !colliders.Any(c => c.IsTouching(collision)))
        {
            score++;
        }
    }
}
