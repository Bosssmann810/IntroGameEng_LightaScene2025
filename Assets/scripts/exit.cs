using UnityEngine;

public class exit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("would have left");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
