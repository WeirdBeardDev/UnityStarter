/*
 * This work by Jason "Aj" Comfort (https://weirdbearddev.com) is licensed under 
 * CC BY-SA 4.0. To view a copy of this license, visit https://creativecommons.org/licenses/by-sa/4.0
*/

using UnityEngine;

namespace WeirdBeardDev
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        #region Members
        private static T _instance;
        private static bool _isQuitting = false;
        private static readonly object _lock = new object();
        #endregion Members

        #region MonoBehaviours
        protected virtual void Awake()
        {
            if (_instance == null)
            {
                // If null, instance is now the Singleton instance of the assigned type
                _instance = this as T;
                // Persist the Singleton instance in memory across every scene
                DontDestroyOnLoad(gameObject);
            }
            else
            { // Destory current instance because it must be a duplicate
                Destroy(gameObject);
            }
        }
        protected virtual void OnDestroy() => _isQuitting = true;
        protected virtual void OnApplicationQuit() => _isQuitting = true;
        #endregion MonoBehaviours

        #region Properties
        public static T Instance
        {
            get
            {
                if (_isQuitting)
                { // Game is quitting, don't need a new instance
                    return null;
                }
                lock (_lock) // thread safety
                {
                    if (_instance == null)
                    { // Make sure there are no other instances of the same type in memory
                        _instance = FindObjectOfType<T>();
                        if (_instance == null)
                        { // Make sure there are no other instances of the saem type in memory
                            var obj = new GameObject { name = typeof(T).Name };
                            _instance = obj.AddComponent<T>();
                        }
                    }
                    return _instance;
                }
            }
        }
        #endregion Properties
    }
}
