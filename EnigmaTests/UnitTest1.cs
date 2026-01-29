using Xunit;
using EnigmaAPI;

public class CipherTests
{
    [Fact]
    public void TestEncryption_ShouldShiftCharForward()
    {
        Assert.Equal("BCD", EnigmaLogic.Encrypt("ABC"));
    }

    [Fact]
    public void TestDecryption_ShouldShiftCharBackward()
    {
        Assert.Equal("ABC", EnigmaLogic.Decrypt("BCD"));
    }
}