// Pour les fonctions d'animation, je me suis bas� sur la vid�o du YouTuber Small Hedge Games : https://www.youtube.com/watch?v=I3_i-x9nCjs&t=417s
// For animation functions, I drew inspiration from the video by YouTuber Small Hedge Games: https://www.youtube.com/watch?v=I3_i-x9nCjs&t=417s


// Utilisation de l'espace de noms UnityEngine
// Using the UnityEngine namespace
using UnityEngine;

// D�claration de l'espace de noms Help
// Declaring the Help namespace
namespace Help
{
    // D�claration de la classe statique Help
    // Declaring the static Help class
    public static class Help
    {
        // D�claration d'une variable statique publique de type Animator
        // Declaring a public static variable of type Animator
        public static Animator animator;

        // D�claration d'une cha�ne priv�e statique pour suivre l'animation actuelle
        // Declaring a private static string to track the current animation
        private static string currentAnimation = "";

        // Fonction de test pour imprimer des messages dans la console
        // Test function for printing messages in the console
        public static void TestHelpScript()
        {
            Debug("message");
            Warn("warning");
            Error("error");
        }

        // Fonction de d�bogage rapide pour afficher un message
        // Quick debug function to display a message
        public static void Debug(string message)
        {
            // Affiche le message dans la console
            // Prints the message in the console
            UnityEngine.Debug.Log(message);
        }

        // Fonction de d�bogage rapide pour afficher un avertissement
        // Quick debug function to display a warning
        public static void Warn(string message)
        {
            // Affiche un avertissement dans la console
            // Displays a warning in the console
            UnityEngine.Debug.LogWarning(message);
        }

        // Fonction de d�bogage rapide pour afficher une erreur
        // Quick debug function to display an error
        public static void Error(string message)
        {
            // Affiche une erreur dans la console
            // Displays an error in the console
            UnityEngine.Debug.LogError(message);
        }

        // Fonction pour obtenir l'Animator d'un GameObject
        // Function to get the Animator of a GameObject
        public static void GetAnimator(GameObject gameObject)
        {
            // Attribue l'Animator du GameObject � la variable animator
            // Assigns the GameObject's Animator to the animator variable
            animator = gameObject.GetComponent<Animator>();
        }

        // Fonction pour changer l'animation
        // Function to change the animation
        public static void ChangeAnimation(string animation, float crossfade = 0.2f)
        {
            // V�rifie si l'animation actuelle est diff�rente de la nouvelle animation
            // Checks if the current animation is different from the new animation
            if (currentAnimation != animation)
            {
                // Met � jour l'animation actuelle et d�clenche le fondu encha�n�
                // Updates the current animation and triggers the crossfade
                currentAnimation = animation;
                animator.CrossFade(animation, crossfade);
            }
        }

        //Fran�ais :
        // Cette fonction recherche r�cursivement un enfant (ou un descendant) du Transform parent
        // dont le nom correspond au param�tre 'name'.
        // Si l'enfant est trouv�, il est renvoy� ; sinon, la recherche continue dans les enfants de l'enfant.
        //English: 
        // This function recursively searches for a child (or descendant) of the parent Transform
        // whose name matches the 'name' parameter.
        // If the child is found, it is returned; otherwise, the search continues in the child's children.
        public static Transform FindDeepChild(this Transform parent, string name)
        {
            foreach (Transform child in parent)
            {
                if (child.name == name)
                    return child;
                var result = child.FindDeepChild(name);
                if (result != null)
                    return result;
            }
            return null;
        }

        // Fran�ais :
        // Cette fonction d�finit r�cursivement la couche (layer) d'un GameObject et de tous ses enfants.
        // Elle prend en param�tre un GameObject 'obj' et une cha�ne de caract�res 'newLayerName' repr�sentant le nom de la nouvelle couche.
        // English:
        // This function recursively sets the layer of a GameObject and all its children.
        // It takes a GameObject 'obj' and a string 'newLayerName' representing the name of the new layer.
        public static void SetLayerRecursively(GameObject obj, string newLayerName)
        {
            int newLayer = LayerMask.NameToLayer(newLayerName);
            if (null == obj)
                return;
            obj.layer = newLayer;
            foreach (Transform child in obj.transform)
            {
                if (null == child)
                    continue;
                SetLayerRecursively(child.gameObject, newLayerName);
            }
        }
    }    
}
