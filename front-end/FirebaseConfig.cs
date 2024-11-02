namespace EMS;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Database;

public class FirebaseConfig
{
    public static void InitializeFirebase()
    {
        string pathToKey = "firebase-config.json"; // Chemin vers votre fichier clé JSON
        FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.FromFile(pathToKey)
        });
    }
}

