using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Transform parent = collision.gameObject.transform.parent;
        
        Destroy(collision.gameObject);
        
        if(parent != null)
        {
            Destroy(parent.gameObject);
        }
    }
}
