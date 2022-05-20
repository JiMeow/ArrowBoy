using UnityEngine;

public class TriggerWithBoard : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Board")
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GameObject ChildGameObject2 = other.gameObject.transform.GetChild(0).gameObject;
            ChildGameObject2 = ChildGameObject2.transform.GetChild(0).gameObject;
            //get last 2 digits of ChildGameObject2.name
            string lastDigits = ChildGameObject2.name.Substring(ChildGameObject2.name.Length - 1);
            int score = int.Parse(lastDigits);
            scoreManager.AddScore(score);
        }
    }
}
