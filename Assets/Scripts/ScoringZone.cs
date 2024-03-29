using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            // EventSystem.current = you can assign a specific method to invoke
            // whenever this trigger happens.
            // In our case, when the ball collides with the left or right wall,
            // it will invoke a specific method that I assigned in the editor 
            // ie. GameManager's score method
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
