using System.Text.Json;
using System.Text.RegularExpressions;
using WebAPI.Utilities.Interface;

namespace WebAPI.Utilities
{
    public class Utilities : IUtilities
    {
        public bool Write(object obj, string fileName)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(obj);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
