using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serealization_
{
    [Serializable]
    public class Song // for XML-Serialized
    {
        public string Name { get; set; }
        [XmlAttribute("SINGER")]
        public string Singer { get; set; }
        [XmlIgnore]
        public TimeSpan Duration { get; set; }
        static int lastId = 0;
        [XmlElement("ID")]
        public int id = ++lastId;
        public override string ToString()
        {
            return $"Song : {Name}\nSinger : {Singer}\nDuration {Duration}";
        }
        //default ctor

    }

    class Program
    {

        static void Main(string[] args)
        {
            Song song = new Song()
            {
                Name = "Du Hust",
                Singer = "Rammstein",
                Duration = TimeSpan.FromMinutes(4.23)
            };
            Song song1 = new Song()
            {
                Name = "Ride",
                Singer = "Twenty One Pilots",
                Duration = TimeSpan.FromMinutes(4.23)
            };

            //Song[] songs = new Song[] { song, song1 };
            //Console.WriteLine(song);
            //string path = "Song.dat";
            //BinarySerializated(songs, path);
            //XmlSerialization(song);
            //JSONSerialized(song1);
            string json = JsonConvert.SerializeObject(song1);
            Song res = JsonConvert.DeserializeObject<Song>(json);
            Console.WriteLine(res);

            WebClient wc = new WebClient();
            string jsonStr = wc.DownloadString("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
            Console.WriteLine(jsonStr);

        }

        private static void JSONSerialized(Song song1)
        {
            string fname = "song.json";
            string jsonStr = System.Text.Json.JsonSerializer.Serialize<Song>(song1);
            File.WriteAllText(fname, jsonStr);
            Console.WriteLine("----JSON----");
            Console.WriteLine(jsonStr);
            Song result = System.Text.Json.JsonSerializer.Deserialize<Song>(jsonStr);
            Console.WriteLine($"Recovered song {result}");
        }

        private static void XmlSerialization(Song song)
        {
            string fname = "Song.xml";

            XmlSerializer xs = new XmlSerializer(typeof(Song));
            using (TextWriter tw = new StreamWriter(fname)) // write
            {
                xs.Serialize(tw, song);
            }
            // read
            using (TextReader tr = new StreamReader(fname))
            {
                Song result = (Song)xs.Deserialize(tr);
                Console.WriteLine($"Recovered song {result}");
            }
        }

        private static void BinarySerializated(Song[] songs, string path)
        {
            BinaryFormatter bf = new BinaryFormatter();


            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, songs);
                Console.WriteLine($"Serealize okey!");
            }

            // for read

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Song[] newSong = (Song[])bf.Deserialize(fs);
                foreach (var item in newSong)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
