using UnityEngine;
using UnityEngine.Playables;
public class doorslamtrigger : MonoBehaviour
{
    public PlayableDirector slam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        slam.Play();
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
