using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    public GameObject door;
    private bool doorDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Apple Count: " + coinCount.ToString();

        if(coinCount == 20 && !doorDestroyed)
        {
            doorDestroyed = true;
            Destroy(door);
        }
    }
}
