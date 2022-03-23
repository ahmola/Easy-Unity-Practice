using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(-1.5f, Random.Range(-3.5f, -0.4f), 0);
            timer = 0;
            Destroy(newPipe, 3.0f);
        }
        if(CountScore.score > 5 && timeDiff > 0.7f)
        {
            timeDiff = timeDiff - 0.05f * Time.deltaTime;
        }
    }
}
