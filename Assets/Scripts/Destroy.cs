using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score();
    }

    public void score()
    {
        if(UIManager.Instance.score==40)
        {
            Destroy(gameObject);
        }
    }
}
