using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningInTheArea : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown()
    {
        AttemptToPlaceDefender(MousePos());
    }
    public void selectedDefender(Defender currentDefender)
    {
        defender = currentDefender;
    }
    public void AttemptToPlaceDefender(Vector2 pos)
    {
        var StarDisplay = FindObjectOfType<starsDisplay>();
        int defenderCost = defender.starCost();
        if (StarDisplay.checkIfEnoughStars(defenderCost))
        {
            InstantiateDefender(pos);
            StarDisplay.SpendStars(defenderCost);
        }
    }
    Vector2 MousePos()
    {
        Vector2 mousepos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 mousePosWorld = Camera.main.ScreenToWorldPoint(mousepos);       
        return gridding(mousePosWorld);
    }
    Vector2 gridding(Vector2 posGiven)
    {
        float newX = Mathf.RoundToInt(posGiven.x);
        float newY = Mathf.RoundToInt(posGiven.y);
        return new Vector2(newX, newY);
    }

    private void InstantiateDefender(Vector2 mousePos)
    {
        Instantiate(defender, mousePos, Quaternion.identity);
        
    }
}
