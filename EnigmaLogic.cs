namespace EnigmaAPI;
public static class EnigmaLogic
{
    public static string Encrypt(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++) buffer[i] = (char)(buffer[i] + 1);
        return new string(buffer);
    }
    public static string Decrypt(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++) buffer[i] = (char)(buffer[i] - 1);
        return new string(buffer);
    }
}