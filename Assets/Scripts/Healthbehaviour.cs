using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Healthbehaviour : MonoBehaviour
{
    public PlayerMovement player;
    public TextMeshProUGUI healthValueTextMeshPro;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthValueTextMeshPro.text = player.healthPoints.ToString();

    }

}
