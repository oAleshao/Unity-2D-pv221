using UnityEngine;

public class EnviromentScript : MonoBehaviour
{
    private float speed = 1.0f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
