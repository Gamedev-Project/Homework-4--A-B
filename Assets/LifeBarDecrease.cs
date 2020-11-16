using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class LifeBarDecrease : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] LifeBarChanger scoreField;
    [SerializeField] int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            
            scoreField.SetNumber(scoreField.GetNumber() + pointsToAdd);
            //GAME_STATUS.playerScore = scoreField.GetNumber(); // Keep the score for the next level
        }
    }

    public void SetScoreField(LifeBarChanger newTextField) {
        this.scoreField = newTextField;
    }
}