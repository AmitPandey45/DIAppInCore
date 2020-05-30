using System;

namespace Core.Framework.ApplicationConfig
{
    public interface IApplicationConfig
    {
        string Read(string configKey);
        string Read(string configKey, string defaultValue);
    }
}
