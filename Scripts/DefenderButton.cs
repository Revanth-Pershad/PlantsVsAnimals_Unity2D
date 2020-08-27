using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender selectedDefender1;
    private void OnMouseDown()

    {

        var buttons = FindObjectsOfType<DefenderButton>(); foreach (DefenderButton button in buttons)

        {

            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);

        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<SpawningInTheArea>().selectedDefender(selectedDefender1);

    }


}
