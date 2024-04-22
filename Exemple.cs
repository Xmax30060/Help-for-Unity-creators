using Help;
using UnityEngine;


public class Exemple : MonoBehaviour
{
    public void PerformTest()
    {
        Help.Help.TestHelpScript();
    }
    private void Start()
    {
        Help.Help.TestHelpScript();
    }
    private void LauchMyAnimation() //This function launches the animation called "MyAnimation."
    {
        Help.Help.GetAnimator(gameObject);
        float opionalCroosFade = 1.0f;
        Help.Help.ChangeAnimation("MyAnimation", opionalCroosFade);
    }
}



