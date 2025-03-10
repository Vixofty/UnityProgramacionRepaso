using UnityEngine;

public class WorldRef : MonoBehaviour
{
    private Camera _cam;
    
    private void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        Vector3 camRotation = _cam.transform.eulerAngles;
        transform.rotation = Quaternion.Euler(0, camRotation.y, 0);
        
    }
}
