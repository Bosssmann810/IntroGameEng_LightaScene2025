using UnityEngine;

public class death : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
