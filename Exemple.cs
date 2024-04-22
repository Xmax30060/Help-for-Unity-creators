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
    private void TestFindAcualGameOBject()
    {
        Transform parentTransform = gameObject.transform; // Replace with your actual GameObject
        string targetChildName = "MyChildObject"; // Replace with the desired child name
        Transform foundChild = parentTransform.FindDeepChild(targetChildName);
        if (foundChild != null)
        {
            // Do something with the found child...
            Debug.Log($"Found child '{targetChildName}'");
        }
        else
        {
            Debug.LogWarning($"Child '{targetChildName}' not found.");
        }
    }
    private void LayerChildUI() 
    {
        // Exemple d'utilisation de la fonction SetLayerRecursively
        // Créez un GameObject dans votre scène Unity et attribuez-lui un nom.
        // Example of using the SetLayerRecursively function
        // Create a GameObject in your Unity scene and give it a name.
        GameObject monObjet = new GameObject("MonObjet");
        // Définissez le layer 'UI' pour cet objet et tous ses enfants récursivement.
        // Assurez-vous que le layer 'UI' existe dans les paramètres de votre projet Unity.
        // Set the 'UI' layer for this object and all its children recursively.
        // Make sure that the 'UI' layer exists in your Unity project settings.
        SetLayerRecursively(monObjet, "UI");       
    }
}



