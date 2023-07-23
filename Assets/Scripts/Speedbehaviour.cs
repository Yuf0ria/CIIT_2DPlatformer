using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Speedbehaviour : MonoBehaviour
{
    public PlayerMovement player;
    public TextMeshProUGUI SpeedValueTextMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedValueTextMeshPro.text = player.moveSpeed.ToString();
    }
}
