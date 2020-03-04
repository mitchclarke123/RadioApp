using System;
using System.IO;
using Newtonsoft.Json;
using System.Media;
using System.Windows;

namespace RadioApp
{

    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;
        private int _volume = 1;
        string path = @"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 5\ClassesExercises\Radio.txt";


        //volume get set
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (_on == true && value <= 10 && value >= 0)
                {
                    _volume = value;
                }
            }
        }

        // get set with on, and sets the property to new value on / off 
        public bool On
        {
            get
            {
                return _on;
            }
            set
            {
                _on = value;
            }
        }

        // same logic as the channel read 
        public int VolumeRead
        {
            get { return _volume; }
            set
            {
                if ( value <= 10 && value >= 0)
                {
                    _volume = value;
                }
            }
        }


        // method for volume display on gui, checks if radio is on and returns a string
        public string VolumeUpDown()
        {
            bool isOn = _on;
            if (isOn == true)
            {
                return $"{_volume}";
            }
            else
            {
                return "Off";
            }
        }


        // channel get set
        public int Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                if (value <= 4 && value > 0 && _on == true)
                {
                    _channel = value;
                }
            }
        }


        // channel get set for read function due to difference in permissions needed
        public int ChannelRead
        {
            get
            {
                return _channel;
            }
            set
            {
                if (value <= 4 && value > 0)
                {
                    _channel = value;
                }
            }
        }


        // radio turn on method
        public void TurnOn()
        {
            _on = true;
        }


        // radio turn off method sets radio _on to false
        public void TurnOff()
        {
            _on = false;
        }


        // radio play method where it will only display channel name if radio on is true, else it will display that radio is off
        public string Play()
        {
            bool isOn = _on;
            int channelNumber = _channel;

            if (isOn == true)
            {
                return $"Playing channel {channelNumber}";
            }

            else
            {
                return "Radio off";
            }
        }

        // Write Method for volume and channel for the object we specified earlier in a json file format in the path 

        public void Write()
        {
            _channel = Channel;
            _volume = Volume;
            string output = JsonConvert.SerializeObject(this); 
            File.WriteAllText(path, output);
        }


        // Read Method reads the file from the path specified and deserializes the object with the channel and volume properties to set them in get set
        public void Read()
        
        {
           string dRadio = File.ReadAllText(path); // reads path 
           Radio r = JsonConvert.DeserializeObject<Radio>(dRadio); // deserializes json file into a string and then applies it to the r object properties
           Channel = r.ChannelRead;
           Volume = r.VolumeRead;
        }
        

        //public void Song1() failed media player
        //{
        //    MediaPlayer Sound1 = new MediaPlayer();
        //    Sound1.Open(new Uri(@"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 5\Music\Channel 1"));
        //    Sound1.Play(); 
        //}
    }
}
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the INSTRUCTIONS document in this solution   
