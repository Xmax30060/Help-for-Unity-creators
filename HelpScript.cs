// Pour les fonctions d'animation, je me suis basé sur la vidéo du YouTuber Small Hedge Games : https://www.youtube.com/watch?v=I3_i-x9nCjs&t=417s
// For animation functions, I drew inspiration from the video by YouTuber Small Hedge Games: https://www.youtube.com/watch?v=I3_i-x9nCjs&t=417s


// Utilisation de l'espace de noms UnityEngine
// Using the UnityEngine namespace
using UnityEngine;

// Déclaration de l'espace de noms Help
// Declaring the Help namespace
namespace Help
{
    // Déclaration de la classe statique Help
    // Declaring the static Help class
    public static class Help
    {
        // Déclaration d'une variable statique publique de type Animator
        // Declaring a public static variable of type Animator
        public static Animator animator;

        // Déclaration d'une chaîne privée statique pour suivre l'animation actuelle
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

        // Fonction de débogage rapide pour afficher un message
        // Quick debug function to display a message
        public static void Debug(string message)
        {
            // Affiche le message dans la console
            // Prints the message in the console
            UnityEngine.Debug.Log(message);
        }

        // Fonction de débogage rapide pour afficher un avertissement
        // Quick debug function to display a warning
        public static void Warn(string message)
        {
            // Affiche un avertissement dans la console
            // Displays a warning in the console
            UnityEngine.Debug.LogWarning(message);
        }

        // Fonction de débogage rapide pour afficher une erreur
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
            // Attribue l'Animator du GameObject à la variable animator
            // Assigns the GameObject's Animator to the animator variable
            animator = gameObject.GetComponent<Animator>();
        }

        // Fonction pour changer l'animation
        // Function to change the animation
        public static void ChangeAnimation(string animation, float crossfade = 0.2f)
        {
            // Vérifie si l'animation actuelle est différente de la nouvelle animation
            // Checks if the current animation is different from the new animation
            if (currentAnimation != animation)
            {
                // Met à jour l'animation actuelle et déclenche le fondu enchaîné
                // Updates the current animation and triggers the crossfade
                currentAnimation = animation;
                animator.CrossFade(animation, crossfade);
            }
        }
    }
}
