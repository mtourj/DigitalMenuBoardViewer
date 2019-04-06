using System.Collections;
using System.Collections.Generic;
using Firebase.Database;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// This is the key used to retrieve a database reference from Firebase
    /// </summary>
    const string firebaseReferenceId = "";

    /// <summary>
    /// Insures single instance
    /// </summary>
    public static MenuManager instance;


    static DatabaseReference dbRef;

    // Start is called before the first frame update
    void Start()
    {
        //Make sure only one instance of this exists
        if(instance == null)
        {
            instance = this;
        } else
        {
            Debug.LogWarning("Only one instance of MenuManager is allowed! Destroying additional instance.");
            Destroy(this);
        }

        dbRef = FirebaseDatabase.DefaultInstance.GetReference(firebaseReferenceId);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
