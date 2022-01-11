public class TV : IDevice
{
    private bool _enabled;
    private int _channel;
    private int _volume;

    public TV()
    {
        _enabled = false;
        _channel = 1;
        _volume = 20;
    }
    public void Disable()
    {
        _enabled = false;
        Console.WriteLine("El dispositivo se apagó");
    }

    public void Enable()
    {
        _enabled = true;
        Console.WriteLine("El dispositivo se encendió");
    }

    public int GetChannel() => _channel;
    

    public int GetVolume() => _volume;

    public bool IsEnabled() => _enabled;

    public void SetChannel(int channel)
    {
        _channel = channel;
        if(_channel > 60)
            _channel = 1;
        if(_channel < 1)
            _channel = 60;        
        Console.WriteLine($"El canal actual es {_channel}");
    }

    public void SetVolume(int increment)
    {
        _volume+= increment;
        if(_volume < 0)
            _volume = 0;
        if(_volume > 100)
            _volume = 100;
        Console.WriteLine($"El volumen actual es de {_volume}");
    }
}