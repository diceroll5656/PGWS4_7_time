using UnityEngine;

public class RotationMonoBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float rotationSpeed = 360.0f * Time.deltaTime / 10.0f;
        this.transform.Rotate(0, rotationSpeed, 0);
    }
}
