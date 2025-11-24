using UnityEngine;
using UnityEngine.Playables;
public class wrongwaytrigger : MonoBehaviour
{
    public PlayableDirector thing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        thing.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
