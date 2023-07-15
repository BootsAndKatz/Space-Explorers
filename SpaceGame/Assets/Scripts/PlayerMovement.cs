using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float positionOffset = 4;

    //0 = left, 1 = middle, 2 = right;

    int currentPos = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentPos > 0)
        {
            //Debug.Log("Move Left");
            Vector3 leftPos = new Vector3(-positionOffset, 0, 0);
            currentPos--;
            transform.Translate(leftPos);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentPos < 2)
        {
            //Debug.Log("Move Right");
            Vector3 rightPos = new Vector3(positionOffset, 0, 0);
            currentPos++;
            transform.Translate(rightPos);
        }
    }
}
