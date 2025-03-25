using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotateSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotateSpeed*Time.deltaTime);
    }


}
