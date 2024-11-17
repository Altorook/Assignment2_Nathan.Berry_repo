using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    // Property to access the singleton instance
    public static T Instance
    {
        get
        {
            return _instance;
        }
    }
    // Protected METHODS: -----------------------------------------------------------------------
    // Ensure the instance isn't destryoyed when loading a new scene
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            // If the object has a parent, detach it to prevent it from being destroyed
            if (transform.parent != null)
            {
                transform.SetParent(null);
            }
        }
        else
        {
            // If another instance already exists, destroy this one
            Destroy(gameObject);
        }
    }
    // Clear the instance when the object is destroyed
    protected virtual void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}
