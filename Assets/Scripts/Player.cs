using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int level = 2;
    void Start()
    {
        Debug.Log("Player started");
        Debug.Log("Player level: " + level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
