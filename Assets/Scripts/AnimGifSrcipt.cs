using UnityEngine;
using UnityEngine.UI;

public class AnimGifSrcipt : MonoBehaviour
{
    public Texture2D[] frame;
    private float framePerSecond = 5f;

    private RawImage image = null;

    void Awake()
    {
        image = GetComponent<RawImage>();
    }

    void Update()
    {
        float index = Time.time * framePerSecond;
        index = index % frame.Length;
        image.texture = frame[(int)index];
    }
}
