using System;

namespace MediaPlayers
{
    public interface IStreamingDevice
    {
        string deviceName { get; set; }
        bool Play();
        void Pause();
        void Ffwd();
        void Rewind();
        bool Stop();

    }

    public class CassettePlayer : IStreamingDevice
    {
        public string deviceName { get => "Walkman"; set => deviceName = "Walkman"; }
        public bool Play()
        {
            Console.WriteLine("Play Cassette");
            return true;
        }
        public void Pause()
        {
            Console.WriteLine("Pause Cassette");
        }
        public void Ffwd()
        {
            Console.WriteLine("FFWD Cassette Player");
        }
        public void Rewind()
        {
            Console.WriteLine("Rewind Cassette Player");
        }
        public bool Stop()
        {
            Console.WriteLine("Stop Cassette");
            return false;
        }
    }
    class Program
    {
        static void start(IStreamingDevice player)
        {
            player.Play();
        }
        static void skipAhead(IStreamingDevice player)
        {
            player.Ffwd();
        }
        static void stop(IStreamingDevice player)
        {
            player.Stop();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MediaPlayers.Program.Main()");

            var mobileDevice = new CassettePlayer();

            Console.WriteLine($"My {mobileDevice.deviceName} totally rocks!");
            start(mobileDevice);
            skipAhead(mobileDevice);
            stop(mobileDevice);

            Console.ReadKey();
            
        }
    }
}
