using UnityEngine;
using UnityEngine.Playables;

public class fallinglight : MonoBehaviour
{
    public PlayableDirector fall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        fall.Play();
        Destroy(this);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
