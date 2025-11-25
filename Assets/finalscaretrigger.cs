using UnityEngine;
using UnityEngine.Playables;
public class finalscaretrigger : MonoBehaviour
{
    public PlayableDirector final;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        final.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
