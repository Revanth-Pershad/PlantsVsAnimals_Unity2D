using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoaderScroll : MonoBehaviour
{
    [SerializeField] float levelTime = 10;
    bool TimerTriggerd = false;

    // Update is called once per frame
    void Update()
    {
        if (TimerTriggerd) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            TimerTriggerd = true;
            FindObjectOfType<LevelLoader>().LevelTimerEnd();
        }
    }
}
