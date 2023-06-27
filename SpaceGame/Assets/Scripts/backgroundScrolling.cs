using UnityEngine;

public class backgroundScrolling : MonoBehaviour
{
    public float scrollSpeed = 0.25f;
    MeshRenderer mr;
    Material mat;
    

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    private void Update()
    {
        Vector2 offset = mat.mainTextureOffset;
        offset.y += scrollSpeed * Time.deltaTime;
        mat.mainTextureOffset = offset;
    }
}