using System;

namespace RefreshTokenAuth
{
    public static class Settings
    {
        public static string Secret = Guid.NewGuid().ToString();
    }
}