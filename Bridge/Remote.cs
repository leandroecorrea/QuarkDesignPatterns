public class Remote
{
    private IDevice _device;
    public Remote(IDevice device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        if(_device.IsEnabled()) 
            _device.Disable();
        else 
            _device.Enable(); 
    }
    
    public void VolumeUp()
    {
        _device.SetVolume(1);        
    }
    public void VolumeDown()
    {
        _device.SetVolume(-1);
    }

    public void ChannelDown()
    {
        int currentChannel = _device.GetChannel();
        _device.SetChannel(currentChannel - 1);
    }
    public void ChannelUp()
    {
        int currentChannel = _device.GetChannel();
        _device.SetChannel(currentChannel + 1);
    }
}
