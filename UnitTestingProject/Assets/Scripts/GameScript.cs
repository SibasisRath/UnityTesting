using System.Collections;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    [SerializeField] private GameObject[] holes;
    [SerializeField] private GameObject penguin;
    private Animator penguinAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        penguinAnimator = penguin.GetComponent<Animator>();

    }

    private IEnumerator GamePlay()
    {
        /*while (true)
        {

        }*/
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Transform RandomSpawnHoleDecider() 
    {
        int num = (int)Random.Range(0,holes.Length-1);
        return holes[num].gameObject.transform;
    }
}
