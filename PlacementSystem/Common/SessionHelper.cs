using System.Text.Json;

namespace PlacementSystem.Common
{
    public static class SessionHelper
    {
        // Store complex object
        public static void SetObject<T>(ISession session, string key, T value)
        {
            var jsonData = JsonSerializer.Serialize(value);
            session.SetString(key, jsonData);
        }

        // Retrieve complex object
        public static T GetObject<T>(ISession session, string key)
        {
            var value = session.GetString(key);
            return string.IsNullOrEmpty(value) ? default : JsonSerializer.Deserialize<T>(value);
        }

        // Store string
        public static void SetString(ISession session, string key, string value)
        {
            session.SetString(key, value);
        }

        // Get string
        public static string GetString(ISession session, string key)
        {
            return session.GetString(key);
        }

        // Store int
        public static void SetInt(ISession session, string key, int value)
        {
            session.SetInt32(key, value);
        }

        // Get int
        public static int? GetInt(ISession session, string key)
        {
            return session.GetInt32(key);
        }

        // Remove specific key
        public static void Remove(ISession session, string key)
        {
            session.Remove(key);
        }

        // Clear entire session
        public static void Clear(ISession session)
        {
            session.Clear();
        }
    }

}
