using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform arrowEnd, arrowStart;
    Vector3 originArrowPosition;
    Rigidbody arrowRigidbody;
    GameObject currentArrow;
    Rigidbody currentArrowRigidbody;
    void Start()
    {
        arrowRigidbody = arrowPrefab.GetComponent<Rigidbody>();
        originArrowPosition = arrowPrefab.transform.localPosition;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            arrowPrefab.transform.position = Vector3.MoveTowards(arrowPrefab.transform.position, arrowEnd.position, Time.deltaTime / 2);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            currentArrow = Instantiate(arrowPrefab, arrowPrefab.transform.position, arrowPrefab.transform.rotation);
            currentArrow.transform.localScale = arrowPrefab.transform.localScale * 4;
            currentArrowRigidbody = currentArrow.GetComponent<Rigidbody>();
            currentArrowRigidbody.freezeRotation = false;
            currentArrowRigidbody.constraints = RigidbodyConstraints.None;
            currentArrowRigidbody.AddForce((arrowStart.position - arrowPrefab.transform.position) * 2000);
            currentArrowRigidbody.useGravity = true;
        }
        else
        {
            arrowPrefab.transform.localPosition = originArrowPosition;
        }
    }
}
