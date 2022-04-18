using UnityEngine;

public class GroundScript : MonoBehaviour
{
    // Scroll main texture based on time

    float scrollSpeed = 3.0f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}