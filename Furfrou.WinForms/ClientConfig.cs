using SysBot.Base;

namespace Furfrou.WinForms;

public class ClientConfig
{
    // Connection
    public string IP { get; set; } = "192.168.0.0";
    public int UsbPort { get; set; } = 0;
    public SwitchProtocol Protocol { get; set; } = SwitchProtocol.WiFi;

    // Fields
    public int TID { get; set; } = 1337;
    public int SID { get; set; } = 1390;
}
