using UnityEngine;

namespace Help
{
    public static class Help 
    {
        public static Animator animator;
        private static string curentAnimation = "";
        //Testing fonction for print 
        public static void TestHelpScript()
        {
            Debug("message");
            Warn("warning");
            Error("error");
        }
        //quik debug fonctions :
        public static void Debug(string message)
        {
            // Print the message in console 
            UnityEngine.Debug.Log(message);
        }

        public static void Warn(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }

        public static void Error(string message)
        {
            UnityEngine.Debug.LogError(message);
        }
        //fonction for animation 
        public static void GetAnimator(GameObject gameObject)
        {
            animator = gameObject.GetComponent<Animator>();
        }
                
        
    }
}



