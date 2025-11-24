using UnityEngine;
using UnityEngine.Playables;
public class wrongwaystoper : MonoBehaviour
{
    public PlayableDirector stop;
    public PlayableDirector start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        stop.Stop();
        start.Play();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
